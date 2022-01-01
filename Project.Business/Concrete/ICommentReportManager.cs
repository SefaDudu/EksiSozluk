using Project.Business.Abstract;
using Project.Business.DependencyResolvers.Ninject;
using Project.DataAccess.Abstract;
using Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Business.Concrete
{
    public class ICommentReportManager : ICommentReportService
    {
        private ICommentReportDal commentReportDal;
        public ICommentReportManager()
        {
            commentReportDal = InstanceFactory.GetInstance<ICommentReportDal>();
        }
        public void add(CommentReport entity)
        {
            commentReportDal.Add(entity);
           }

        public void delete(CommentReport entity)
        {
            commentReportDal.Delete(entity);
        }

        public CommentReport GetById(Guid id)
        {
            var rest = commentReportDal.Get(s => s.Id == id);
            return rest;
        }

        public List<CommentReport> GetList()
        {
            return commentReportDal.GetAll();
        }

        public void update(CommentReport entity)
        {
            commentReportDal.Update(entity);
        }
    }
}
