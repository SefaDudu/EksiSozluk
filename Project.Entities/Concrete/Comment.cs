using Project.Entities.Abstract;
using Project.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Entities.Concrete
{
    public class Comment: BaseEntity, IEntity
    {
        //Kullanıcı
        public User User { get; set; }
        public Guid UserId { get; set; }
        //Konu Başlığı
        public Subject Subject { get; set; }
        public Guid SubjectId { get; set; }
        //Yorumu
        public string CommentText { get; set; }
    


        public ICollection<CommentReport> CommentReport { get; set; }
        public ICollection<CommentVote> CommentVote { get; set; }


    }
}
