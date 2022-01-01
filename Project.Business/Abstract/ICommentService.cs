using Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Business.Abstract
{
  public  interface ICommentService
    {
        List<Comment> GetList();
        Comment GetById(Guid id);
        void add(Comment entity);
        void delete(Comment entity);
        void update(Comment entity);
    }
}
