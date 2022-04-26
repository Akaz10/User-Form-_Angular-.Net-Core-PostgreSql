using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Data.Entity;

namespace User.Data.Entities
{
    public class Userx : BaseEntity
    {
        public string name { get; set; }

        public string surname { get; set; }

        public string mail { get; set; }

        public DateTime bDay { get; set; }

        public string gender { get; set; }
    }
}
