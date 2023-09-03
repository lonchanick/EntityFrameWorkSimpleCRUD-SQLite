using Microsoft.EntityFrameworkCore;
using PlayingSpectre.Models;

namespace PlayingSpectre.Controllers;

public class OrderController
{
    internal static int Add(List<OrderProd> orders)
    {
        using var db = new CoffeeDBcontext();
        db.OrderProds.AddRange(orders);
        var status = db.SaveChanges();

        return status;
    }

    internal static Order GetOrderById(int id)
    {
        using var db = new CoffeeDBcontext();
        var order = db.Orders.FirstOrDefault(ord => ord.Id == id);

        return order;
    }

    internal static List<Order> GetOrders()
    {
        using var db = new CoffeeDBcontext();
        return db.Orders.ToList();
    }

    internal static int RemoveOrder(Order order)
    {
        using var contextDb = new CoffeeDBcontext();
        contextDb.Remove(order);
        return contextDb.SaveChanges();

    }

    internal static List<Order> GetOrdersDetailed()
    {
        using var db = new CoffeeDBcontext();

        var orderDetailed = db.Orders
            .Include(o => o.OrderProd)
            .ThenInclude(coffee => coffee.Coffee)
            .ThenInclude(cat => cat.Category)
            .ToList();

        return orderDetailed;
    }
    internal static IQueryable GetOrdersDetailById(int id)
    {
        using var db = new CoffeeDBcontext();

        //quedaste en el video #16
        //esto no funciona utiliza los DTO (data transfer object) para recuperar los orderprod y los prod
        /*var results =
            from order in db.Orders
            join orderProd in db.OrderProds on order.Id equals orderProd.OrderId
            where order.Id == id
            select new { Orderx = order, OrderProdx=orderProd};*/
            

            /*.ThenInclude(o => o.OrderProd)
            .ThenInclude(coffee => coffee.Coffee)
            .ThenInclude(cat => cat.Category)
            .ToList();*/

        return results;
    }

}
