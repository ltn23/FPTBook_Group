﻿using System.ComponentModel.DataAnnotations;

namespace FPTBook_Group.ModelsCRUD.Category
{
    public class UpdateCategoryView
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
