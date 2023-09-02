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
	/*internal static int Add(Order orders)
    {
        using var db = new CoffeeDBcontext();
        //db.Add(orders);
        db.OrderProds.AddRange(orders); //¿?
        var status = db.SaveChanges();

        return status;
    }*/


	internal static Order GetOrderById(int id)
	{
		using var db = new CoffeeDBcontext();
		//var orderProd = db.OrderProds.FirstOrDefault(orderP => orderP.Id == id);
        var order = db.Orders.FirstOrDefault(ord => ord.Id == id);
		
		return order;
	}

	internal static List<Order> GetOrders()
	{
		using var db = new CoffeeDBcontext();
		return db.Orders.ToList();
	}

}
