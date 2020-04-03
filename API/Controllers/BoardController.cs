using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoardController : Controller
    {
        [HttpPost("addBoard")]
        public IActionResult addBoard()
        {
            return Ok();
        }
        [HttpPost("RemoveBoard")]
        public IActionResult RemoveBoard()
        {

            return Ok();
        }

        [HttpPut("UpdateBoard")]
        public IActionResult UpdateBoard()
        {
            return Ok();
        }
        [HttpDelete("DeleteBoard")]
        public IActionResult DeleteBoard()
        {
            return Ok();
        }

        [HttpPost("RemoveUserBoard")]
        public IActionResult RemoveUserBoard()
        {

            return Ok();
        }
        [HttpPost("AddUserBoard")]
        public IActionResult AddUserBoard()
        {

            return Ok();
        }
        [HttpPost("AddSprintBoard")]
        public IActionResult AddSprintBoard()
        {

            return Ok();
        }
    }
}
