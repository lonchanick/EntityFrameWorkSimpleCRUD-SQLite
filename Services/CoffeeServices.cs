
using PlayingSpectre.Controllers;
using PlayingSpectre.UserInterfaces;

namespace PlayingSpectre.Services;

internal class CoffeeServices
{
	internal static void AddCoffee()
	{
		var coffee = CoffeeInterface.AddCoffee();
		int status = CoffeController.Add(coffee);
		CoffeController.SuccefullOrUnsuccefullMessage(status, "Coffee successfully saved!", coffee);

	}

	internal static void RemoveCoffee()
	{
		var coffees = CoffeController.GetAllCoffees();
		var coffee = CoffeeInterface.CoffeeListMenu(coffees);
		var status = CoffeController.Remove(coffee);

		CoffeController.SuccefullOrUnsuccefullMessage(status, "Coffee successfully deleted!", coffee);

	}
	internal static void UpdateCoffee()
	{
		var coffees = CoffeController.GetAllCoffees();
		var coffee = CoffeeInterface.CoffeeListMenu(coffees);

		var upDatedCoffee = CoffeeInterface.UpdateInterface(coffee);
		var status = CoffeController.Update(coffee);
		CoffeController.SuccefullOrUnsuccefullMessage(status, "Coffee successfully Updated!", upDatedCoffee);

	}
	internal static void ViewAllCoffees()
	{
		var coffeList = CoffeController.GetAllCoffees();
		CoffeeInterface.PrintCoffeeList(coffeList);
	}
	internal static void ViewCoffee()
	{
		var coffees = CoffeController.GetAllCoffees();
		var coffee = CoffeeInterface.CoffeeListMenu(coffees);
		CoffeeInterface.ShowSingleCoffeeDetails(coffee);
	}
}
