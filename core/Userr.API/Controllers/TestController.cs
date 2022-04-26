using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using User.Data;
using User.Data.Entities;
using Userr.API.Request;

namespace Userr.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class TestController : Controller
    {
        private readonly UserDbContext _userDbContext;

        public TestController(UserDbContext userDbContext)
        {
            _userDbContext = userDbContext;
        }
        [HttpPost("SaveUser")]
        public IActionResult SaveUser([FromBody]UserRequestModel request)
        {
            var model = new Userx
            {
                name = request.name,
                surname = request.surname,
                mail = request.mail,
                bDay = request.bDay,
                gender = request.gender
            };
            _userDbContext.Add(model);
            _userDbContext.SaveChanges();
            return Ok(model);
        }
    }
}
