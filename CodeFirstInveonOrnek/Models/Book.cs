﻿using System.ComponentModel.DataAnnotations;

namespace CodeFirstInveonOrnek.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public int PageCount { get; set; }
    }
}
