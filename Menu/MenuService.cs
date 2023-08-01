using PlayingSpectre.Controllers;
using PlayingSpectre.Services;
using Spectre.Console;

namespace PlayingSpectre.Menu;

public class Main
{
    internal static void Menu()
    {
        //animated fake loading 
        AnsiConsole.Status()
            .Start("Loading...", ctx =>
            {
                ctx.SpinnerStyle(Style.Parse("green"));
                Thread.Sleep(800);
            });


        while (true)
        {
            AnsiConsole.Write(new FigletText("Coffe Menu!").LeftJustified().Color(Color.Blue));
            var options = new SelectionPrompt<MenuOptions>();
            options.AddChoices
                (
                    MenuOptions.ADD_Category,
                    MenuOptions.VIEWALL_Categories,
                    //MenuOptions.VIEW_Category,
                    MenuOptions.DELETE_Category,
                    //MenuOptions.UPDATE_Category,
					MenuOptions.ADD_Coffee,
                    MenuOptions.VIEW_Coffee,
                    MenuOptions.VIEWALL_Coffee,
                    MenuOptions.DELETE_Coffee,
                    MenuOptions.UPDATE_Coffee,
                    MenuOptions.QUIT
                );
            var r = AnsiConsole.Prompt(options);

            switch (r)
            {
				case MenuOptions.ADD_Category:
					CategoryServices.AddCategory();
					Console.Clear();
					break;

				case MenuOptions.VIEWALL_Categories:
					CategoryServices.ShowCategories();
					Console.Clear();
					break;

				case MenuOptions.DELETE_Category:
					CategoryServices.DeleteCategory();
					Console.Clear();
					break;

				case MenuOptions.ADD_Coffee:
					CoffeeServices.AddCoffee();
					Console.Clear();
					break;

				case MenuOptions.VIEW_Coffee:
					CoffeeServices.ViewCoffee();
					Console.Clear();
                    break;

                case MenuOptions.VIEWALL_Coffee:
					CoffeeServices.ViewAllCoffees();
					Console.Clear();
                    break;

                case MenuOptions.DELETE_Coffee:
					CoffeeServices.RemoveCoffee();
					Console.Clear();
                    break;

                case MenuOptions.UPDATE_Coffee:
                    CoffeeServices.UpdateCoffee();
                    Console.Clear();
                    break;

                case MenuOptions.QUIT:
                    return;
            }
        }

    }

}
