using Microsoft.EntityFrameworkCore;
using PlayingSpectre.Models;
using PlayingSpectre.UserInterfaces;
using Spectre.Console;

namespace PlayingSpectre.Controllers;

internal class CoffeController
{
    internal static int Add(Coffee coffee)
    {
        using var dbRepository = new CoffeeDBcontext();
        dbRepository.Add(coffee);
        var status = dbRepository.SaveChanges();

        return status;

    }

    internal static int Remove(Coffee coffee)
    {
        using var contextDb = new CoffeeDBcontext();
        contextDb.Remove(coffee);
        return contextDb.SaveChanges();

    }

    internal static List<Coffee> GetAllCoffees()
    {
        using var dbContext = new CoffeeDBcontext();
        var coffees = dbContext.Coffees
            .Include(c => c.Category)
            .ToList();
        return coffees;
    }

    internal static int Update(Coffee coffee)
    {
        //var coffee = UserInterface.UpdateInterface();
        using var dbContext = new CoffeeDBcontext();
        dbContext.Update(coffee);
        return dbContext.SaveChanges();

    }

    public static void SuccefullOrUnsuccefullMessage(int status, string message, Coffee coffee)
    {
        if (status > 0)
        {
            Console.Clear();
            CoffeeInterface.ShowSingleCoffeeDetails(coffee, message);
        }
        else
        {
            Console.WriteLine("Something went wrong! ");
        }
    }

}
