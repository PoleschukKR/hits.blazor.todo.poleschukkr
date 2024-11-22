using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata;

namespace TodoServerApp.Data
{
	public class TaskItem
	{
		public int Id { get; set; }
		[Required]
		public string? Title { get; set; }
		[Required]
		public string? Description { get; set; }
		public DateTime? CreatedDate { get; set; }
		public DateTime? FinishDate { get; set; }
		[AllowNull]
		public int? IdPerformer { get; set; }
		[AllowNull]
		[ForeignKey(nameof(IdPerformer))]
		public PerformerItem PerformerItem { get; set; }




	}
}
