using Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Business.Abstract
{
    public interface IUserReportService
    {
        List<UserReport> GetList();
        UserReport GetById(Guid id);
        void add(UserReport entity);
        void delete(UserReport entity);
        void update(UserReport entity);
    }
}
