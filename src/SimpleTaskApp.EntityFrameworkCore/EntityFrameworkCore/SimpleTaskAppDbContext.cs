using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using SimpleTaskApp.Authorization.Roles;
using SimpleTaskApp.Authorization.Users;
using SimpleTaskApp.MultiTenancy;
using SimpleTaskApp.TodoList;

namespace SimpleTaskApp.EntityFrameworkCore
{
    public class SimpleTaskAppDbContext : AbpZeroDbContext<Tenant, Role, User, SimpleTaskAppDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Todos> TodoList { get; set; }
        
        public SimpleTaskAppDbContext(DbContextOptions<SimpleTaskAppDbContext> options)
            : base(options)
        {
        }
    }
}
