using Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Business.Abstract
{
   public interface ICommentReportService
    {
        List<CommentReport> GetList();
        CommentReport GetById(Guid id);
        void add(CommentReport entity);
        void delete(CommentReport entity);
        void update(CommentReport entity);
    }
}
