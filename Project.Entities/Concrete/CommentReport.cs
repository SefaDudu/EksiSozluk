using Project.Entities.Abstract;
using Project.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Entities.Concrete
{
    public class CommentReport: BaseEntity, IEntity
    {
        public Comment Comment { get; set; }
        public Guid CommentId { get; set; }



        //Şikayet Eden Kişi
        public User User { get; set; }
        public Guid UserId { get; set; }
       


        public string CommentText { get; set; }


    }
}
