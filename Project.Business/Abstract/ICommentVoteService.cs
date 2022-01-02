using Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Business.Abstract
{
   public interface ICommentVoteService
    {
        List<CommentVote> GetList();
        CommentVote GetById(Guid id);
        void add(CommentVote entity);
        void delete(CommentVote entity);
        void update(CommentVote entity);
    }
}
