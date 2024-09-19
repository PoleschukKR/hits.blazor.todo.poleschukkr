using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TodoServerApp.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public virtual DbSet<TaskItem> TaskItems { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
			builder.Entity<TaskItem>().HasData([
				new() { Id = 1, Title="Задача 1", Description="Описание задачи 1", CreatedDate=DateTime.Now},
				new() { Id = 2, Title="Задача 2", Description="Описание задачи 2", CreatedDate=DateTime.Now},
				new() { Id = 3, Title="Задача 3", Description="Описание задачи 3", CreatedDate=DateTime.Now},
				new() { Id = 4, Title="Задача 4", Description="Описание задачи 4", CreatedDate=DateTime.Now},
			]);
		}
	}
}
