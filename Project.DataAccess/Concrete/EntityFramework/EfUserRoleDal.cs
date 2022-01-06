using Project.Core.DataAccess.EntityFramework;
using Project.DataAccess.Abstract;
using Project.Entities.Concrete;
using Project.DataAccess.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.DataAccess.Concrete.EntityFramework
{
  public  class EfUserRoleDal:EfEntityRepository<UserRole,ProjectContext>,IUserRoleDal
    {
    }
}
