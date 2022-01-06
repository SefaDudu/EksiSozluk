using Project.Core.DataAccess.EntityFramework;
using Project.DataAccess.Abstract;
using Project.DataAccess.Domain;
using Project.Entities.Concrete;

using Project.Entities.VmModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.DataAccess.Concrete.EntityFramework
{
    public class EfCommentDal : EfEntityRepository<Comment, ProjectContext>, ICommentDal
    {
        private  ProjectContext context = new ProjectContext();
        public List<MainComment> MainComment()
        {

            var result = (from Com in context.Comments
                          join Sub in context.Subjects
                          on Com.SubjectId equals Sub.Id
                          join Us in context.Users
                          on Com.UserId equals Us.Id
                          select new MainComment
                          {
                              CommentId = Com.Id,
                              CommentUserId = Com.UserId,
                              FirstName = Us.FirstName,
                              LastName = Us.LastName,
                              SubjectId = Com.SubjectId,
                              subjectTitle = Sub.SubjectTitle,
                              UserPhoto = Us.Photo
                          }).Take(10).ToList();

            return result;
               


            

        }
    }
}
