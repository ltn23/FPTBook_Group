﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FPTBook_Group.Models
{
    public class Book
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
        public Category Category { get; set; }
		public PublishCompany PublishCompany { get; internal set; }

	

     
	}
}
