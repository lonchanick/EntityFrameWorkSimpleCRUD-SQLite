using Microsoft.EntityFrameworkCore;
using PlayingSpectre.Models;

namespace PlayingSpectre;

internal class CoffeeRepository : DbContext
{
	public DbSet<Coffee> Coffees { get; set; }
	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	=>
		optionsBuilder.UseSqlite($"Data Source =  CoffeStore.db");
}
