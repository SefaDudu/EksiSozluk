using Project.Business.Abstract;
using Project.Business.DependencyResolvers.Ninject;
using Project.DataAccess.Abstract;
using Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Business.Concrete
{
    public class SubjectManager : ISubjectService
    {
        private ISubjectDal SubjectDal;
        public SubjectManager()
        {
            SubjectDal = InstanceFactory.GetInstance<ISubjectDal>();
        }
        public void add(Subject entity)
        {
            SubjectDal.Add(entity);
        }

        public void delete(Subject entity)
        {
            SubjectDal.Delete(entity);
        }

        public Subject GetById(Guid id)
        {
            var rest = SubjectDal.Get(s => s.Id == id);
            return rest;
        }

        public List<Subject> GetList()
        {
            return SubjectDal.GetAll();
        }

        public void update(Subject entity)
        {
            SubjectDal.Update(entity);
        }
    }
}
