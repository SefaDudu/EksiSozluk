using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project.Business.Abstract;
using Project.Business.BusinessAspects.Autofac;
using Project.Business.DependencyResolvers.Ninject;
using Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{   [Route("api/User/")]
    public class UserController : Controller
    {


        private ISubjectService subjectService;
        private ICommentService commentService;
        private IBlacklistService blacklistService;
        private ICommentReportService commentReport;
        private IUserReportService userReport;

        public UserController()
        {
            subjectService = InstanceFactory.GetInstance<ISubjectService>();
            commentService = InstanceFactory.GetInstance<ICommentService>();
            blacklistService = InstanceFactory.GetInstance<IBlacklistService>();
            commentReport = InstanceFactory.GetInstance<ICommentReportService>();
            userReport = InstanceFactory.GetInstance<IUserReportService>();
        }
        public IActionResult Index()
        {
            return Ok("Sefa");
        }
        //Top 10 giriş yapılmamış
        [HttpGet("Top10Title")]
        public IActionResult Top10Title()
        {           
            var Top10Title = subjectService.Top10();   
            return Ok(Top10Title);
        }

        //maintop10 giriş yapılmamış
        [HttpGet("Top10Main")]
        public IActionResult Top10Main()
        {
            var Top10Main = commentService.MainComment();
            return Ok(Top10Main);
        }
        //Engelle Giriş Yapan=USerId diğer kişide Reportlanan kişie
        [HttpPost("BlackList")]
        public IActionResult BlackList([FromBody]  Blacklist blacklist)
        {
            if (blacklist != null)
            {
                blacklist.Id = Guid.NewGuid();

                blacklist.IsActive = true;
                blacklistService.add(blacklist);
                return Ok(true);
            }
            else
            {
                return Ok(false);
            }
        }

        //konu listesi
        [HttpGet("GetSubjectList")]
        public IActionResult GetSubjectList()
        {
            var getlist = subjectService.GetList();
            return Ok(getlist);
        }

        [HttpPost("AddSubject")]
        public IActionResult AddSubject([FromBody]  string title)
        {
            Subject subject = new Subject();
            subject.Id = Guid.NewGuid();
            subject.IsActive = true;
            subject.CreatedDate = DateTime.Now;
            subject.SubjectTitle= title;
            subjectService.add(subject);
            return Ok(true);
        }

        //Yorum yap
        //SubjectId ,UserId ve Comment gönderilecek
        [HttpPost("AddSubject")]
        public IActionResult AddSubject([FromBody] Comment comment)
        {
            comment.Id = Guid.NewGuid();
            comment.IsActive = true;
            commentService.add(comment);
            return Ok(true);
        }
        //Yorum Şikayet CommentId,UserId ve text yollanacak
        [HttpPost("ReportComment")]
        public IActionResult ReportComment([FromBody] CommentReport comment)
        {
            comment.Id = Guid.NewGuid();
            comment.IsActive = true;
            commentReport.add(comment);
            return Ok(true);
        }
        //User Şikayet girişyapan kişini Idsi ve Şikayet edilen kişinin idsi ile text yollanacak
        [HttpPost("UserReport")]
        public IActionResult UserReport([FromBody] UserReport comment)
        {
            comment.Id = Guid.NewGuid();
            comment.IsActive = true;
            userReport.add(comment);
            return Ok(true);
        }
        //Giriş Yapan kişi için engellenen kişilerin yorumlarının gösterilmemesi
        [Authorize(Roles = "Admin")]
        [HttpGet("GetComment")]
        public IActionResult GetComment()
        {
            
            return Ok(true);
        }
    }
}
