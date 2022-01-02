using Project.Business.Abstract;
using Project.Business.DependencyResolvers.Ninject;
using Project.DataAccess.Abstract;
using Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Business.Concrete
{
    public class UserReportManager : IUserReportService
    {
        private IUserReportDal userReportDal;
        public UserReportManager()
        {
            userReportDal = InstanceFactory.GetInstance<IUserReportDal>();
        }
        public void add(UserReport entity)
        {
            userReportDal.Add(entity);
        }

        public void delete(UserReport entity)
        {
            userReportDal.Delete(entity);
        }

        public UserReport GetById(Guid id)
        {

            var rest = userReportDal.Get(x => x.Id == id);
            return rest;
        }

        public List<UserReport> GetList()
        {
            return userReportDal.GetAll();
        }

        public void update(UserReport entity)
        {
            userReportDal.Update(entity);
        }
    }
}
