using Project.Business.Abstract;
using Project.Business.Constants;
using Project.Business.DependencyResolvers.Ninject;
using Project.Core.Utilities.Results;
using Project.Core.Utilities.Security.Hashing;
using Project.Core.Utilities.Security.JWT;
using Project.Entities.Concrete;
using Project.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Business.Concrete
{

    public class AuthManager : IAuthService
    {
        private IUserService _userService;
        private ITokenHelper _tokenHelper;

        public AuthManager()
        {
            _userService = InstanceFactory.GetInstance<IUserService>();
            _tokenHelper = InstanceFactory.GetInstance<ITokenHelper>();
        }

        public IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
            var user = new User
            {
                Email = userForRegisterDto.Email,
                UserName = userForRegisterDto.UserName,
                BirthDate = userForRegisterDto.BirthDay,
                Phone = userForRegisterDto.Phone,
                                
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
              
            };
            _userService.add(user);
            return new SuccessDataResult<User>(user, "Kayıt oldu");
        }

        public IDataResult<User> Login(UserForLoginDto userForLoginDto)
        {
            var userToCheck = _userService.GetByMail(userForLoginDto.Email);
            if (userToCheck == null)
            {
                return new ErrorDataResult<User>("Kullanıcı bulunamadı");
            }

            if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, userToCheck.PasswordHash, userToCheck.PasswordSalt))
            {
                return new ErrorDataResult<User>("Parola hatası");
            }

            return new SuccessDataResult<User>(userToCheck, "Başarılı giriş");
        }

        public IResult UserExists(string email)
        {
            if (_userService.GetByMail(email) != null)
            {
                return new ErrorResult("Kullanıcı mevcut");
            }
            return new SuccessResult();
        }

        public IDataResult<AccessToken> CreateAccessToken(User user)
        {
            var claims = _userService.GetClaims(user);
            var accessToken = _tokenHelper.CreateToken(user, claims);
            return new SuccessDataResult<AccessToken>(accessToken, "Token oluşturuldu");
        }
    }
}
