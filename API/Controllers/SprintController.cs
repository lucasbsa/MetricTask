using Business;
using Microsoft.AspNetCore.Mvc;
using Models.ModelSprint;
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
        public IActionResult addSprint([FromBody] Sprint sprint)
        {
            try
            {
                SprintBSS.addSprint(sprint);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpDelete("RemoveSprint")]
        public IActionResult RemoveSprint([FromQuery] int IdSprint)
        {
            try
            {
                SprintBSS.RemoveSprint(IdSprint);
                return Ok("Sprint removed");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPut("UpdateSprint")]
        public IActionResult UpdateSprint([FromBody] Sprint sprint)
        {
            try
            {
                SprintBSS.UpdateSprint(sprint);
                return Ok("sprint updated");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        

        [HttpPost("RemoveUserSprint")]
        public IActionResult RemoveUserSprint([FromQuery] int IdSprint, [FromQuery] int IdUser)
        {

            try
            {
                SprintBSS.RemoveUserSprint(IdSprint,IdUser);
                return Ok("User removed");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
       
    }
}
