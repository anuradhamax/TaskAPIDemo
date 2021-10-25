using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        [HttpGet]
        public IActionResult Tasks()
        {
            var tasks = new string[]{ "Task01", "Task02", "Task03", "Task04" };
            return Ok(tasks);
        }

        [HttpPost]
        public IActionResult newTask()
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult updateTask()
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult deleteTask()
        {
            var somethingwentwrong = true;
            if (somethingwentwrong)
                return BadRequest();
            return Ok();
        }
    }
}
