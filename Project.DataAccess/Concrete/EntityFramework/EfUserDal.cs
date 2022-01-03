using Microsoft.EntityFrameworkCore;
using Project.Core.DataAccess.EntityFramework;
using Project.DataAccess.Abstract;
using Project.Entities.Abstract;
using Project.Entities.Concrete;
using Project.Entities.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Project.DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepository<User, ProjectContext>, IUserDal
    {
        public List<Role> GetClaims(User user)
        {
            using (var context = new ProjectContext())
            {
                var result = from role in context.Roles
                             join userRoles in context.UserRoles
                                 on role.Id equals userRoles.Role.Id
                             where userRoles.UserId == user.Id
                             select new Role { Id = role.Id, Name = role.Name };
                return result.ToList();

            }
        }
    }
}

