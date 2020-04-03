using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SprintController : Controller
    {
        [HttpPost("addSprint")]
        public IActionResult addTask()
        {
            return Ok();
        }
        [HttpPost("RemoveSprint")]
        public IActionResult RemoveTask()
        {

            return Ok();
        }

        [HttpPut("UpdateSprint")]
        public IActionResult UpdateUser()
        {
            return Ok();
        }
        [HttpDelete("DeleteSprint")]
        public IActionResult DeleteTask()
        {
            return Ok();
        }

        [HttpPost("RemoveUserSprint")]
        public IActionResult RemoveUser()
        {

            return Ok();
        }
        [HttpPost("AddSprint")]
        public IActionResult AddUser()
        {

            return Ok();
        }

    }
}
