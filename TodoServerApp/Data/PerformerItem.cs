using System.ComponentModel.DataAnnotations; // для использования Required, проверки на null и валидации

namespace TodoServerApp.Data
{
	// класс для описания структуры данных исполнителя с тремя обязательными полями 
	public class PerformerItem
	{
		public int Id { get; set; }
		[Required]
		public string? Surname { get; set; }
		[Required]
		public string? Name { get; set; }
		[Required]
		public string? Pantronymic { get; set; }
	}
}
