using System.ComponentModel.DataAnnotations;
using System;

namespace WebBanHang.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required, StringLength(50)]
        public String Name { get; set; }
        [Range(1, 100)]
        public int DisplayOrder { get; set; }
    }
}
