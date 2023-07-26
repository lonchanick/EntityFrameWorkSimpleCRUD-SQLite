using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlayingSpectre.Models;

public class Category
{
    [Key]
    public int categoryId { get; set; }
    [Required]
    public string categoryName { get; set; }

    List<Coffee> Coffees { get; set; }

}
