using Project.Business.Abstract;
using Project.Business.DependencyResolvers.Ninject;
using Project.DataAccess.Abstract;
using Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Business.Concrete
{
    public class UserRoleManager : IUserRoleService
    {
        private IUserRoleDal userRoleDal;
        public UserRoleManager()
        {
            userRoleDal = InstanceFactory.GetInstance<IUserRoleDal>();
        }
        public void add(UserRole entity)
        {
            userRoleDal.Add(entity);
        }

        public void delete(UserRole entity)
        {
            userRoleDal.Delete(entity);
        }

        public UserRole GetById(Guid id)
        {
            var rest = userRoleDal.Get(x => x.Id == id);
            return rest;
        }

        public List<UserRole> GetList()
        {
            return userRoleDal.GetAll();
        }

        public void update(UserRole entity)
        {
            userRoleDal.Update(entity);
        }
    }
}
