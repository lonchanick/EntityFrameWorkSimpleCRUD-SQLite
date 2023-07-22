namespace PlayingSpectre;

public class Coffee
{
	public Coffee()
	{
	}
	public Coffee(string? name, decimal price, bool isCoffeeOfTheMonth)
	{
		Name = name;
		Price = price;
		IsCoffeeOfTheMonth = isCoffeeOfTheMonth;
	}

	public int Id { get; set; }
	public string? Name { get; set; } /*= string.Empty;*/
	public decimal Price { get; set; }
	public bool IsCoffeeOfTheMonth { get; set; }

	public override string ToString()
	{
		return Id.ToString()+" "+Name;
	}

}