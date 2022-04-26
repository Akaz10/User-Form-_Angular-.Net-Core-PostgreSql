using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User.Data.Entity
{
    public abstract class BaseEntity
    {
        public int id { get; set; }

        public bool IsActive { get; set; } = true;

        public DateTime? updatedTime { get; set; } = DateTime.Now;


    }
}
