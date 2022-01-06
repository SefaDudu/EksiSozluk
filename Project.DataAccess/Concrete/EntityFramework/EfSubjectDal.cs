using Project.Core.DataAccess.EntityFramework;
using Project.DataAccess.Abstract;
using Project.Entities.Concrete;
using Project.Entities.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Project.DataAccess.Concrete.EntityFramework
{
    public class EfSubjectDal : EfEntityRepository<Subject, ProjectContext>, ISubjectDal
    {
        public List<Subject> Top10Subject(Expression<Func<Subject, bool>> filter=null)
        {
            using (ProjectContext context = new ProjectContext())
            {
                return filter == null
                    ? context.Set<Subject>().Take(10).ToList()
                    : context.Set<Subject>().Where(filter).ToList();
            }
        }
    }
}
