using Project.Business.Abstract;
using Project.Business.DependencyResolvers.Ninject;
using Project.DataAccess.Abstract;
using Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Business.Concrete
{
    public class RoleManager : IRoleService
    {
        private IRoleDal roleDal;
        public RoleManager()
        {
            roleDal = InstanceFactory.GetInstance<IRoleDal>();
        }
        public void add(Role entity)
        {
            roleDal.Add(entity);
        }

        public void delete(Role entity)
        {
            roleDal.Delete(entity);
        }

        public Role GetById(Guid id)
        {
            var rest = roleDal.Get(x => x.Id == id);
            return rest;
        }

        public List<Role> GetList()
        {
            return roleDal.GetAll();
        }

        public void update(Role entity)
        {
            roleDal.Update(entity);
        }
    }
}
