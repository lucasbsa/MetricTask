using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    public class ColumnController : Controller
    {
        [HttpPost("addColumn")]
        public IActionResult addTask()
        {
            return Ok();
        }
        [HttpPost("RemoveColumn")]
        public IActionResult RemoveTask()
        {
            return Ok();
        }

        [HttpPut("UpdateColumn")]
        public IActionResult UpdateUser()
        {
            return Ok();
        }
        [HttpDelete("DeleteColumn")]
        public IActionResult DeleteTask()
        {
            return Ok();
        }

        [HttpPost("RemoveTaskColumn")]
        public IActionResult RemoveUser()
        {
            return Ok();
        }
        [HttpPost("AddTaskColumn")]
        public IActionResult AddUser()
        {
            return Ok();
        }
    }
}
