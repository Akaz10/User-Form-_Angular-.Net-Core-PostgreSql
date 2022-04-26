using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Userr.API.Request
{
    public class UserRequestModel
    {
        public string name { get; set; }

        public string surname { get; set; }

        public string mail { get; set; }

        public DateTime bDay { get; set; }

        public string gender { get; set; }
    }
}
