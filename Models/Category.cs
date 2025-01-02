using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ShagoWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }


        [Required]
        [MaxLength(30)]
        public String Name { get; set; }


        [Range(1,10)]
        public int DisplayOrder { get; set; }
    }
}
