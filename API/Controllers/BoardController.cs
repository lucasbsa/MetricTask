using Business;
using Microsoft.AspNetCore.Mvc;
using Models.ModelBoard;
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
        public IActionResult addBoard([FromBody] Board board)
        {
            try
            {
                BoardBSS.AddBoard(board);
                return Ok("Board created.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }

        }
   

        [HttpPut("UpdateBoard")]
        public IActionResult UpdateBoard([FromBody] Board board)
        {
            try
            {
                BoardBSS.UpdateBoard(board);
                return Ok("Board updated.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPost("RemoveUserBoard")]
        public IActionResult RemoveUserBoard([FromQuery] int IdBoard, [FromQuery] int IdUser)
        {
            try
            {
                BoardBSS.RemoveUserBoard(IdBoard, IdUser);
                return Ok("Board created.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpPost("AddUserBoard")]
        public IActionResult AddUserBoard([FromQuery] int IdBoard, [FromQuery] int IdUser)
        {
            try
            {
                BoardBSS.AddUserBoard(IdBoard, IdUser);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpPost("AddSprintBoard")]
        public IActionResult AddSprintBoard([FromQuery] int IdSprint, [FromQuery] int IdBoard)
        {
            try 
            {
                BoardBSS.AddSprintBoard(IdSprint, IdBoard);
                return Ok();
            } 
            catch (Exception ex) 
            {
                return StatusCode(500, ex);
            }            
        }
    }
}
