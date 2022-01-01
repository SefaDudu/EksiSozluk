using Project.Business.Abstract;
using Project.Business.DependencyResolvers.Ninject;
using Project.DataAccess.Abstract;
using Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Business.Concrete
{
    public class BlacklistManager : IBlacklistService
    {
        private IBlacklistDal blacklistDal;
        public BlacklistManager()
        {
            blacklistDal = InstanceFactory.GetInstance<IBlacklistDal>();
        }
        public void add(Blacklist entity)
        {
            blacklistDal.Add(entity);
        }

        public void delete(Blacklist entity)
        {
            blacklistDal.Delete(entity);
        }

        public Blacklist GetById(Guid id)
        {
            var rest = blacklistDal.Get(x => x.Id == id);
            return rest;
        }

        public List<Blacklist> GetList()
        {
            return blacklistDal.GetAll();
        }

        public void update(Blacklist entity)
        {
            blacklistDal.Update(entity);
        }
    }
}
