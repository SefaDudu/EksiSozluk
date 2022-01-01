using Project.Core.DataAccess.EntityFramework;
using Project.DataAccess.Abstract;
using Project.Entities.Concrete;
using Project.Entities.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.DataAccess.Concrete.EntityFramework
{
   public class EfCommentReportDal:EfEntityRepository<CommentReport,ProjectContext>,ICommentReportDal
    {
    }
}
