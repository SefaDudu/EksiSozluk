using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.Entities.Base
{
  public  class BaseEntity
    {
        public Guid Id { get; set; }
        public bool IsActive { get; set; }
    }
}
