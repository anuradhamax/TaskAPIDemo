using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskAPI.Models;

namespace TaskAPI.Services
{
    public class ToDoService
    {
        public List<ToDo> allToDos()
        {
            var ToDos = new List<ToDo>();

            var todo1 = new ToDo
            {
                Id = 1,
                Title = "get books for school",
                Description = "get some text books for school",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = ToDoStatus.New
            };



            var todo2 = new ToDo
            {
                Id = 2,
                Title = "get foods for school",
                Description = "get some foods for school",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = ToDoStatus.New
            };

            var todo3 = new ToDo
            {
                Id = 3,
                Title = "get drinks for school",
                Description = "get some drink bottles for school",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = ToDoStatus.Completed
            };

            ToDos.Add(todo1);
            ToDos.Add(todo2);
            ToDos.Add(todo3);

            return ToDos;
        }
    }
}
