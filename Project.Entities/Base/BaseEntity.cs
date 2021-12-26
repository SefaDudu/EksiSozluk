using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Project.Entities.Base
{
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }
        public bool IsActive { get; set; }
    }
}
