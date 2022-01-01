using Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Business.Abstract
{
   public  interface IUserService
    {
        List<User> GetList();
        User GetById(Guid id);
        void add(User entity);
        void delete(User entity);
        void update(User entity);
    }
}
