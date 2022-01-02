using Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Business.Abstract
{
    public interface IUserRoleService
    {
        List<UserRole> GetList();
        UserRole GetById(Guid id);
        void add(UserRole entity);
        void delete(UserRole entity);
        void update(UserRole entity);
    }
}
