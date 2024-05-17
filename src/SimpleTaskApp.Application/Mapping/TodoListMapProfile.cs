using AutoMapper;
using SimpleTaskApp.Models;
using SimpleTaskApp.TodoList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTaskApp.Mapping
{
    public class TodoListMapProfile:Profile
    {
        public TodoListMapProfile()
        {
            CreateMap<Todos, TodoListDto>();
            CreateMap<TodoListDto,Todos>();

        }
    }
}
