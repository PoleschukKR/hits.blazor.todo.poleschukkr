using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TodoServerApp.Data
{
	public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
	{
		public virtual DbSet<TaskItem> TaskItems { get; set; }
		public virtual DbSet<PerformerItem> PerformerItems { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
			builder.Entity<PerformerItem>().HasData([
						new () { Id = 1, Surname = "�������", Name = "������", Pantronymic =  "���������"},
						new () { Id = 2, Surname = "���������", Name = "������", Pantronymic =  "����������"},
						
					]);
			builder.Entity<TaskItem>().HasData([
				new() { Id = 1, Title="������ 1", Description="�������� ������ 1", CreatedDate=DateTime.Now, IdPerformer = 1,},
				new() { Id = 2, Title="������ 2", Description="�������� ������ 2", CreatedDate=DateTime.Now},
				new() { Id = 3, Title="������ 3", Description="�������� ������ 3", CreatedDate=DateTime.Now, IdPerformer = 2},
				new() { Id = 4, Title="������ 4", Description="�������� ������ 4", CreatedDate=DateTime.Now},
			]);
		}
	}
}
