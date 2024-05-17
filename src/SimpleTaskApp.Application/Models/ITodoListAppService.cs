using Abp.Application.Services;
using SimpleTaskApp.TodoList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTaskApp.Models
{
    public interface ITodoListAppService:IApplicationService
    {
        Task<List<TodoListDto>> GetAll();

        Task<TodoListDto> Create(TodoListDto input);

        Task<TodoListDto> Update(TodoListDto input);

        Task Delete(int id);

        Task<TodoListDto> GetId(int id);
    }
}
