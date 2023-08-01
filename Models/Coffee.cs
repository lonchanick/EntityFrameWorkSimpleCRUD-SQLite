using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlayingSpectre.Models;


[Index(nameof(Name), IsUnique = true)]

public class Coffee
{
    [Key]
    public int CoffeeId { get; set; }
    [Required]
    public string? Name { get; set; } /*= string.Empty;*/
    [Required]
    public decimal Price { get; set; }
    public bool IsCoffeeOfTheMonth { get; set; }
    
    [ForeignKey(nameof(CategoryId))]
    public int CategoryId { get; set; }

	public Category Category { get; set; }


	public override string ToString()
    {
        return CoffeeId.ToString() + " " + Name;
    }

	public Coffee(string? name, decimal price, bool isCoffeeOfTheMonth)
	{
		Name = name;
		Price = price;
		IsCoffeeOfTheMonth = isCoffeeOfTheMonth;
        //Category = category;
	}

	public Coffee()
	{
	}
}