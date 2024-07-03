using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace SampleTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        [HttpGet]
        public IActionResult Tasks()
        {
            var task= new string[] { "Task 1", "Task 2", "Task 3","Task 4" };
            return Ok(task);
        }

        [HttpPost]
        public IActionResult NewTask()
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateTask()
        {
            return Ok();
        }


        [HttpDelete]
        public IActionResult DeleteTask()
        {
            var somethingwentwrong = true;
            if (somethingwentwrong)
                return BadRequest();
            return Ok();
        }
    }
}
