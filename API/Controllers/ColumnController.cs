using Business;
using Microsoft.AspNetCore.Mvc;
using Models.Collumn;
using Models.ModelCollumn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    public class ColumnController : Controller
    {
        [HttpPost("addColumn")]
        public IActionResult addColumn([FromBody] Collumn collumn)
        {
            try
            {
                CollumnBSS.addCollumn(collumn);
                return Ok();

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpDelete("DeleteColumn")]
        public IActionResult DeleteColumn([FromQuery] int IdCollumn)
        {
            try
            {
                CollumnBSS.DeleteColumn(IdCollumn);
                return Ok("Board created.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPut("UpdateColumn")]
        public IActionResult UpdateColumn([FromBody] Collumn collumn)
        {
            try
            {
                CollumnBSS.UpdateColumn(collumn);
                return Ok("Board created.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpDelete("DeleteTaskColumn")]
        public IActionResult DeleteTaskColumn([FromQuery] int IdCollumn, [FromQuery]int IdTask)
        {
            try
            {
                CollumnBSS.DeleteTaskColumn(IdCollumn, IdTask);
                return Ok("Board created.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPost("AddTaskColumn")]
        public IActionResult AddTaskColumn([FromBody] TaskCollumn taskCollumn)
        {
            try
            {
                CollumnBSS.AddTaskColumn( taskCollumn.IdCollumn, taskCollumn.Task);
                return Ok("Board created.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
    }
}
