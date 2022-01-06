using Project.Core.DataAccess;
using Project.Entities.Concrete;
using Project.Entities.VmModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.DataAccess.Abstract
{
    public interface ICommentDal: IEntityRepository<Comment>
    {
        public List<MainComment> MainComment();
    }
}
