using Business;
using Microsoft.AspNetCore.Mvc;
using Models.MoldelUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        [HttpPost("addUser")]
        public IActionResult addUser([FromBody] User user) {



            return Ok();
        }
        [HttpPost("RemoveUser")]
        public IActionResult RemoveUser()
        {

            return Ok();
        }

        [HttpPut("UpdateUser")]
        public IActionResult UpdateUser()
        {

            return Ok();
        }
        [HttpDelete("DeleteUser")]
        public IActionResult DeleteUser()
        {

            return Ok();
        }



    }
}
