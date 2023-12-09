﻿using System.ComponentModel.DataAnnotations;

namespace FPTBook_Group.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public bool IsApproved { get; set; }

    }
}
