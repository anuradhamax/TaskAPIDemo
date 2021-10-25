using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskAPI.Models;
using TaskAPI.Services;

namespace TaskAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDosController : ControllerBase
    {
        private ToDoService _toDoService;
        public ToDosController()
        {
            _toDoService = new ToDoService();
        }
        [HttpGet("{id?}")]
        public IActionResult getTodos(int? id)
        {
            var myToDos = _toDoService.allToDos();

            if (id is null) return Ok(myToDos);

            myToDos = myToDos.Where(t => t.Id == id).ToList();

            return Ok(myToDos);
        } 

        
    }
}
