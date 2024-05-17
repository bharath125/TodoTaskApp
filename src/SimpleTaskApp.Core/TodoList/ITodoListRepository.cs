using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTaskApp.TodoList
{
    public interface ITodoListRepository:IRepository<Todos,int>
    {
    }
}
