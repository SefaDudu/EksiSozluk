using Project.Core.DataAccess;
using Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Project.DataAccess.Abstract
{
   public interface ISubjectDal:IEntityRepository<Subject>
    {

        List<Subject> Top10Subject(Expression<Func<Subject, bool>> filter=null);
    }
}
