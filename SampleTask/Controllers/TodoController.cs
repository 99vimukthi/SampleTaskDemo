using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleTask.Models;
using SampleTask.Services;

namespace SampleTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private TodoService _todoService;

        public TodoController()
        {
            _todoService = new TodoService();
        }
        [HttpGet("{id?}")]
        public IActionResult GetTodods(int? id)
        {
            var mytodos = _todoService.AllTodos();
            if (id is null) return Ok(mytodos);
            mytodos = mytodos.Where(t=>t.Id==id).ToList();
            return Ok(mytodos);
        }

        //Get Todos

        
    }
}
