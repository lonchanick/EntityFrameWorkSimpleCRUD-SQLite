using PlayingSpectre;
using Spectre.Console;

AnsiConsole.Status()
	.Start("Loading...", ctx =>
	{
		ctx.SpinnerStyle(Style.Parse("green"));
		Thread.Sleep(800);
	});


while(true)
{
	AnsiConsole.Write(new FigletText("Coffe Menu!").LeftJustified().Color(Color.Blue));
	var options = new SelectionPrompt<MenuOptions>();
	options.AddChoices
		(
			MenuOptions.ADD,
			MenuOptions.VIEW,
			MenuOptions.VIEWALL,
			MenuOptions.DELETE,
			MenuOptions.UPDATE,
			MenuOptions.QUIT
		);
	var r = AnsiConsole.Prompt(options);

	switch (r)
	{
		case MenuOptions.ADD:
			CoffeController.Add();
			Console.Clear();
			break;
		case MenuOptions.VIEW:
			var aux2 = UserInterface.CoffeeListMenu();
			UserInterface.ShowSingleCoffeeDetails(aux2);
			Console.Clear();
			break;
		case MenuOptions.VIEWALL:
			var aux = CoffeController.GetAllCoffees();
			UserInterface.ShowAllCoffees(aux);
			Console.Clear();
			break;
		case MenuOptions.DELETE:
			CoffeController.Delete();
			Console.Clear();
			break;
		case MenuOptions.UPDATE:
			CoffeController.Update();
			Console.Clear();
			break;
		case MenuOptions.QUIT:
			return;
	}
}


public enum MenuOptions
{
	ADD,
	VIEW,
	VIEWALL,
	DELETE,
	QUIT,
	UPDATE
}

