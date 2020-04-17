using Business;
using Microsoft.AspNetCore.Mvc;
using Models.MoldelUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        [HttpPost("addUser")]
        public IActionResult addUser([FromBody] User user) {

            try
            {
                int ResultAdd = UserBSS.AddUser(user);
                if(ResultAdd == 1)
                    return Ok("User add");
                else
                    return Ok("User active");

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpGet("GetUser")]
        public IActionResult GetUser([FromQuery] int IdUser)
        {
            try 
            {
                return Ok(UserBSS.GetUser(IdUser));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }


        [HttpPut("UpdateUser")]
        public IActionResult UpdateUser([FromBody] User user)
        {
            try
            {
                UserBSS.UpdateUser(user);
                return Ok("User updated");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpDelete("DeleteUser")]
        public IActionResult DeleteUser([FromQuery] int IdUser)
        {
            try
            {
                UserBSS.RemoveUser(IdUser);
                return Ok("User removed");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }



    }
}
 