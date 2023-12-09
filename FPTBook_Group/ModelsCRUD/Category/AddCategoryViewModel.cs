using System.ComponentModel.DataAnnotations;

namespace FPTBook_Group.ModelsCRUD.Category
{
    public class AddCategoryViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
