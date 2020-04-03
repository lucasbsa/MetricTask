using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class TaskController : Controller
    {
        [HttpPost("addTask")]
        public IActionResult addTask()
        {
            return Ok();
        }
        [HttpPost("RemoveTask")]
        public IActionResult RemoveTask()
        {

            return Ok();
        }

        [HttpPut("UpdateTask")]
        public IActionResult UpdateUser()
        {
            return Ok();
        }
        [HttpDelete("DeleteTask")]
        public IActionResult DeleteTask()
        {
            return Ok();
        }

        [HttpPost("RemoveUserTask")]
        public IActionResult RemoveUser()
        {

            return Ok();
        }
        [HttpPost("AddUserTask")]
        public IActionResult AddUser()
        {

            return Ok();
        }
    }
}
