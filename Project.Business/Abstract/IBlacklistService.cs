using Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Business.Abstract
{
   public interface IBlacklistService
    {
        List<Blacklist> GetList();
        Blacklist GetById(Guid id);
        void add(Blacklist entity);
        void delete(Blacklist entity);
        void update(Blacklist entity);
    }
}
