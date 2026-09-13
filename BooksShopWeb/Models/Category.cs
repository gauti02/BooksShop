using System.ComponentModel.DataAnnotations;

namespace BooksShopWeb.Models
{
    public class Category
    {
        //[Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Name { get; set; } = string.Empty;
        [Range(1, 100, ErrorMessage = "Range must be between 1 and 100")]
        public int DisplayOrder { get; set; }
    }
}
