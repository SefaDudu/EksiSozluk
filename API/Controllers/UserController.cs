using Microsoft.AspNetCore.Mvc;
using Project.Business.Abstract;
using Project.Business.BusinessAspects.Autofac;
using Project.Business.DependencyResolvers.Ninject;

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

        public UserController()
        {
            subjectService = InstanceFactory.GetInstance<ISubjectService>();
            commentService = InstanceFactory.GetInstance<ICommentService>();
        }
        public IActionResult Index()
        {
            return Ok("Sefa");
        }
        //Top 10 
        [HttpGet("Top10Title")]
        public IActionResult Top10Title()
        {           
            var Top10Title = subjectService.Top10();   
            return Ok(Top10Title);
        }

        //maintop10
        [HttpGet("Top10Main")]
        public IActionResult Top10Main()
        {
            var Top10Main = commentService.MainComment();
            return Ok(Top10Main);
        }


    }
}
