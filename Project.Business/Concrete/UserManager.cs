using Project.Business.Abstract;
using Project.Business.DependencyResolvers.Ninject;
using Project.DataAccess.Abstract;
using Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Business.Concrete
{
    public class UserManager : IUserService
    {
        private IUserDal userDal;
        public UserManager()
        {
            userDal = InstanceFactory.GetInstance<IUserDal>();
        }
        public void add(User entity)
        {
            userDal.Add(entity);
        }

        public void delete(User entity)
        {
            userDal.Delete(entity);
        }

        public User GetById(Guid id)
        {
            var rest = userDal.Get(x => x.Id == id);
            return rest;
        }

        public List<User> GetList()
        {
            return userDal.GetAll();
        }

        public void update(User entity)
        {
            userDal.Update(entity);
        }
    }
}
