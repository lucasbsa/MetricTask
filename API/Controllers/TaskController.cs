using Business;
using Microsoft.AspNetCore.Mvc;
using Models.ModelTask;
using System;
using System.Collections.Generic;
using System.Linq;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class TaskController : Controller
    {
        [HttpPost("addTask")]
        public IActionResult addTask([FromBody] Task task)
        {
            try
            {
                TaskBSS.addTask(task);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpDelete("DeleteTask")]
        public IActionResult DeleteTask([FromQuery] int IdTask)
        {

            try
            {
                TaskBSS.DeleteTask(IdTask);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPut("UpdateTask")]
        public IActionResult UpdateTask([FromBody] Task task)
        {
            try
            {
                TaskBSS.UpdateTask(task);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
 
        [HttpDelete("DeleteUserTask")]
        public IActionResult DeleteUserTask([FromQuery] int IdTask, [FromQuery] int IdUser)
        {
            try
            {
                TaskBSS.DeleteUserTask(IdTask, IdUser);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpPost("AddUserTask")]
        public IActionResult AddUserTask([FromQuery] int IdTask, [FromQuery] int IdUser)
        {
            try
            {
                TaskBSS.AddUserTask(IdTask, IdUser);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
    }
}
