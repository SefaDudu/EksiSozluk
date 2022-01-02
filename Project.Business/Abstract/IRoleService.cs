using Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Business.Abstract
{
  public  interface IRoleService
    {
        List<Role> GetList();
        Role GetById(Guid id);
        void add(Role entity);
        void delete(Role entity);
        void update(Role entity);
    }
}
