using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JimazonLite.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [Range(1, 10000, ErrorMessage = "The price must be between $1 and $10,000")]
        public float Price { get; set; }
        [Required]
        [Range(1, 1000, ErrorMessage = "The quantity must be between 1 and 1000")]
        public int Quantity { get; set; }
        public string? ModelNumber { get; set; }
        public string? ImageUrl { get; set; }
        public DateTime DateAdded { get; set; }
        public int? CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category? Category { get; set; }

    }
}
