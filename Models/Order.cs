namespace PlayingSpectre.Models;

public class Order
{
	public int Id { get; set; }
	public DateTime CreatedDate { get; set; }
	public decimal TotalAmount { get; set; }
	public OrderProd OrderProd { get; set; }
}
