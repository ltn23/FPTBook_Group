using System.ComponentModel.DataAnnotations;

namespace FPTBook_Group.ModelsCRUD.PublishCompany
{
	public class UpdateCompanyView
	{
		[Key]
		public int PublishingCompanyId { get; set; }
		[Required]
		public string Name { get; set; }
		[Required]
		public string Adress { get; set; }
	}
}
