using Abp.Application.Services;
using Abp.Domain.Repositories;
using Microsoft.AspNetCore.Http.HttpResults;
using SimpleTaskApp.TodoList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTaskApp.Models
{
    public class TodoListAppService : ApplicationService, ITodoListAppService
    {
        private readonly IRepository<Todos,int> _todoListRepository;

        public TodoListAppService(IRepository<Todos, int> todoListRepository)
        {
            _todoListRepository = todoListRepository;
        }

        public async Task<List<TodoListDto>> GetAll()
        {
            var lists=await _todoListRepository.GetAllListAsync();
            return ObjectMapper.Map<List<TodoListDto>>(lists);

        }


        public async Task<TodoListDto> Create(TodoListDto input)
        {
            var todo = ObjectMapper.Map<Todos>(input);
            await _todoListRepository.InsertAsync(todo);
            return ObjectMapper.Map<TodoListDto>(todo);
        }

        public async Task<TodoListDto> Update(TodoListDto input)
        {
            var todoItem = await _todoListRepository.GetAsync(input.Id);
            todoItem.Status = input.Status;
            todoItem.Description = input.Description;
            todoItem.Name = input.Name;
            //var updatedTodo = await _todoListRepository.UpdateAsync(todoItem);
            var updatedTodo =await _todoListRepository.GetAsync(input.Id);
           return ObjectMapper.Map<TodoListDto>(updatedTodo);

        }

        public async Task Delete(int Id)
        {
            await _todoListRepository.DeleteAsync(Id);
            
        }

        public async Task<TodoListDto> GetId(int id)
        {
            var todoItem = await _todoListRepository.GetAsync(id);
            return ObjectMapper.Map<TodoListDto>(todoItem);
        }

        
      
    }
}
