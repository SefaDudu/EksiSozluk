using Project.Business.Abstract;
using Project.Business.DependencyResolvers.Ninject;
using Project.DataAccess.Abstract;
using Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Business.Concrete
{
    public class CommentVoteManager : ICommentVoteService
    {
        private ICommentVoteDal commentVoteDal;
        public CommentVoteManager()
        {
            commentVoteDal = InstanceFactory.GetInstance<ICommentVoteDal>();
        }
        public void add(CommentVote entity)
        {
            commentVoteDal.Add(entity);
        }

        public void delete(CommentVote entity)
        {
            commentVoteDal.Delete(entity);
        }

        public CommentVote GetById(Guid id)
        {
            var rest = commentVoteDal.Get(s => s.Id == id);

            return rest;
        }

        public List<CommentVote> GetList()
        {
            return commentVoteDal.GetAll();
        }

        public void update(CommentVote entity)
        {
            commentVoteDal.Update(entity);
        }
    }
}
