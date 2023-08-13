using PlayingSpectre.Controllers;
using PlayingSpectre.Models;
using PlayingSpectre.UserInterfaces;
using Spectre.Console;

namespace PlayingSpectre.Services;

public class OrderService
{
	internal static void NewOrder()
	{
		List<OrderProd> orderProd = new();

		var coffeeList = CoffeeController.GetAllCoffees();
		var order = new Order { CreatedDate = DateTime.Now };

		bool choosingProducts = true;
		while(choosingProducts)
		{
			var coffee = CoffeeInterface.CoffeeListMenu(coffeeList);
			Console.WriteLine(coffee);
			var productQuantity = AnsiConsole.Ask<int>("Product Quantity?: ");
			
			order.TotalAmount += coffee.Price * productQuantity;

			orderProd.Add(
				new OrderProd
				{
					Order = order,
					CoffeeId = coffee.CoffeeId,
					ProductQuantity = productQuantity
				});

			choosingProducts = AnsiConsole.Confirm("Add more products? ");
		}

		if (OrderController.Add(orderProd) > 0)
			Console.WriteLine("Order Details");
		else
			Console.WriteLine("Error");
		Thread.Sleep(800);

	}

	//internal static void ViewOrders()
	//{
	//	var orders = OrderController.GetOrders();
	//	OrderInterface.PrintOrderTable(orders);
	//}
	internal static void ViewOrders()
	{
		var orders = OrderController.GetOrdersJoinedData();
		//foreach (var order in orders)
		//{
		//	order.OrderProd.
		//	foreach (var orderProd in order.OrderProd.)
		//	{

		//	}
		//}
		Console.WriteLine("");
	}

}
