using Microsoft.EntityFrameworkCore;
using PlayingSpectre.Models;

namespace PlayingSpectre.Controllers;

public class OrderController
{
	internal static int Add(List<OrderProd> orders)
	{
		using var db = new CoffeeDBcontext();
		//db.Add(orders);
		db.OrderProds.AddRange(orders); //¿?
		var status = db.SaveChanges();

		return status;
	}

	internal static OrderProd GetOrderById(int id)
	{
		using var db = new CoffeeDBcontext();
		var orderProd = db.OrderProds.FirstOrDefault(orderP => orderP.Id == id);
		
		return orderProd;
	}

	internal static List<Order> GetOrders()
	{
		using var db = new CoffeeDBcontext();
		return db.Orders.ToList();
	}

	//internal static List<Order> GetOrdersJoinedData()
	//{
	//	using var db = new CoffeeDBcontext();
	//	var orders = db.Orders
	//		.Include(o => o.OrderProduc)
	//}
}
