using Spectre.Console;

namespace PlayingSpectre;

internal class UserInterface
{
	internal static void PrintCoffeeList(List<Coffee> coffees)
	{
		var table = new Table();
		table.AddColumn("Id");
		table.AddColumn("Name");
		table.AddColumn("Price");
		table.AddColumn("Coffee of the Month S/N ?");

		foreach (var coffe in coffees)
		{
			table.AddRow
				(coffe.Id.ToString(),
				coffe.Name, coffe.Price.ToString(),
				coffe.IsCoffeeOfTheMonth.ToString());
		}

		AnsiConsole.Write(table);
	}
	public static Coffee CoffeeListMenu()
	{
		var coffees = CoffeController.GetAllCoffees();
		var option = AnsiConsole.Prompt(new SelectionPrompt<Coffee>()
			.Title("Choose any Coffee")
			.AddChoices(coffees));

		return option;
	}

	public static void ShowSingleCoffeeDetails(Coffee coffee, string optional="")
	{
		var panel = new Panel($@"Id: {coffee.Id}
Name: {coffee.Name}
Pricer: {coffee.Price}
Is Coffee of the month?: {coffee.IsCoffeeOfTheMonth}");

		if(optional=="")
		panel.Header = new PanelHeader("Coffee Details");
		else
		panel.Header = new PanelHeader(optional);

		panel.Padding = new Padding(1,1,1,1);
		AnsiConsole.Write(panel);
		Console.WriteLine("Press any key to continue ...");
		Console.ReadLine();
	}

	public static void ShowAllCoffees(List<Coffee> coffeeList)
	{
		UserInterface.PrintCoffeeList(coffeeList);

		Console.Write("Press any Key to continue");
		Console.ReadLine();
		Console.Clear();
	}

	public static Coffee UpdateInterface()
	{
		var coffeeToUpdate = CoffeeListMenu();

		coffeeToUpdate.Name = AnsiConsole.Confirm("Wanna Update name? ")
			? AnsiConsole.Ask<string>("Enter new name: ")
			: coffeeToUpdate.Name;

		coffeeToUpdate.Price = AnsiConsole.Confirm("Wanna Update Price? ")
			? AnsiConsole.Ask<decimal>("Enter new Price: ")
			: coffeeToUpdate.Price;


		coffeeToUpdate.IsCoffeeOfTheMonth = AnsiConsole.Confirm("Wanna Update isCoffeeOfTheMonth? ")
			? AnsiConsole.Ask<bool>("Enter True or False: ")
			: coffeeToUpdate.IsCoffeeOfTheMonth;

		return coffeeToUpdate;

	}

	public static Coffee AddInterface()
	{
		var name = AnsiConsole.Ask<string>("Name: ");
		var price = AnsiConsole.Ask<decimal>("Price: ");
		bool IsCoffeeOfTheMonth = AnsiConsole.Confirm("Is Coffe Of the Month?")
			? true
			: false;
		var aux = new Coffee(name, price, IsCoffeeOfTheMonth);

		return aux;
	}

	public static Coffee DeleteInterface()
	{
		return CoffeeListMenu();
	}

}
