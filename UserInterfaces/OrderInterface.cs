using PlayingSpectre.Models;
using Spectre.Console;

namespace PlayingSpectre.UserInterfaces;

public class OrderInterface
{
	internal static void PrintOrderTable(List<Order> orders)
	{
		var table = new Table();
		table.AddColumn("Id");
		table.AddColumn("Created Date");
		table.AddColumn("Quantity");

		foreach (var order in orders)
		{
			table.AddRow
				(order.Id.ToString(),
				order.CreatedDate.ToString(),
				order.TotalAmount.ToString());
		}

		AnsiConsole.Write(table);
		Console.Write("Press any Key to continue");
		Console.ReadLine();

	}
}
