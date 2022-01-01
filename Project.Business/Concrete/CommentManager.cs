using Project.Business.Abstract;
using Project.Business.DependencyResolvers.Ninject;
using Project.DataAccess.Abstract;
using Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Business.Concrete
{
    public class CommentManager : ICommentService
    {
        private ICommentDal CommentDal;
        public CommentManager()
        {
            CommentDal = InstanceFactory.GetInstance<ICommentDal>();
        }
        public void add(Comment entity)
        {
            CommentDal.Add(entity);
        }

        public void delete(Comment entity)
        {
            CommentDal.Delete(entity);
        }

        public Comment GetById(Guid id)
        {
            var rest = CommentDal.Get(x => x.Id == id);
            return rest;
        }

        public List<Comment> GetList()
        {

            return CommentDal.GetAll();
        }

        public void update(Comment entity)
        {
            CommentDal.Update(entity);
        }
    }
}
