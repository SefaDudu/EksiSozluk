using Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Business.Abstract
{
    public interface ISubjectService
    {
        List<Subject> GetList();
        Subject GetById(Guid id);
        void add(Subject entity);
        void delete(Subject entity);
        void update(Subject entity);
        List<Subject> Top10();
    }
}
