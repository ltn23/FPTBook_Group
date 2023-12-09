using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FPTBook_Group.ModelsCRUD.Book
{
	public class AddBookViewModel
	{
		[Key]
		public int BookId { get; set; }
		[Required]
		public string Name { get; set; }
		[Required]
		public int Quantity { get; set; }
		[Required]
		public decimal Price { get; set; }
		[Required]
		public string Description { get; set; }
		[Required]
		public DateTime UpdateDate { get; set; }
		[Required]
		public string Author { get; set; }
		[Required]
		public string Image { get; set; }
		[Required]
		public int CategoryId { get; set; }
		[Required]
		public int PublishCompanyId { get; set; }
		[ForeignKey("CategoryId")]
		public Models.Category Category { get; set; }
	}
}
