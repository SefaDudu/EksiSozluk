using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Entities.VmModel
{
   public class MainComment
    {
        public string subjectTitle { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserPhoto { get; set; }
        public Guid CommentId { get; set; }
        public Guid SubjectId { get; set; }
        public Guid CommentUserId { get; set; }
    }
}
