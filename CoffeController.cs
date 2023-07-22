using Spectre.Console;

namespace PlayingSpectre;

internal class CoffeController
{
	internal static void Add()
	{
		var dbRepository = new CoffeeRepository();

		var coffee = UserInterface.AddInterface();

		dbRepository.Add(coffee);
		var status = dbRepository.SaveChanges();

		SuccefullOrUnsuccefullMessage(status, "Coffee successfully saved!", coffee);

	}

	internal static void Delete()
	{
		var contextDb = new CoffeeRepository();
		var coffee = UserInterface.DeleteInterface();
		contextDb.Remove(coffee);
		var status = contextDb.SaveChanges();
		SuccefullOrUnsuccefullMessage(status, "Coffee successfully deleted!", coffee);

	}

	internal static List<Coffee> GetAllCoffees()
	{
		List<Coffee> coffees;
		var dbContext = new CoffeeRepository();
		coffees = dbContext.Coffees.ToList();

		return coffees; 
	}

	internal static void Update()
	{
		var coffee = UserInterface.UpdateInterface();
		var dbContext = new CoffeeRepository();
		dbContext.Update(coffee);
		var status = dbContext.SaveChanges();
		SuccefullOrUnsuccefullMessage(status, "Coffee successfully Updated!", coffee);

	}

	public static void SuccefullOrUnsuccefullMessage(int status, string message, Coffee coffee)
	{
		if (status > 0)
		{
			Console.Clear();
			UserInterface.ShowSingleCoffeeDetails(coffee, message);
		}
		else
		{
			Console.WriteLine("Something went wrong! ");
		}
	}

}
