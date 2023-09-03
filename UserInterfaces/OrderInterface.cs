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
		table.AddColumn("Total Order");

		foreach (var order in orders)
		{
			table.AddRow
				(order.Id.ToString(),
				order.CreatedDate.ToString("dd-MM-yyyy"),
				order.TotalAmount.ToString());
		}

		AnsiConsole.Write(table);
		Console.Write("Press any Key to continue");
		Console.Read();

	}

    internal static Order OrderMenuPickable(List<Order> orders)
    {
        var order = AnsiConsole.Prompt(new SelectionPrompt<Order>()
            .Title("Choose any Order")
            .AddChoices(orders));
        return order;
    }

    public static void ShowSingleOrderDetail(Order order)
    {
		var panel = new Panel(
$@"Id: {order.Id}
Init Date: {order.CreatedDate}
Total Amount: {order.TotalAmount}");

        panel.Header = new PanelHeader("Order Details");

        panel.Padding = new Padding(1, 1, 1, 1);

        AnsiConsole.Write(panel);
        Console.WriteLine("Press any key to continue ...");
        Console.Read();
    }
}
