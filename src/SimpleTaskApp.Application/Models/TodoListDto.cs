using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTaskApp.Models
{
    public class TodoListDto:EntityDto<int>

    {
        public string Name { get; set; }
        public string Description { get; set; }

        public bool Status { get; set; }
    }
}
