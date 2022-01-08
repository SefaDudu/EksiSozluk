using Project.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Entities.Dtos
{
    public class UserForRegisterDto : IDto
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDay { get; set; }
    }
}
