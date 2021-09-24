using Microsoft.EntityFrameworkCore;
using MovieEntities.Data;

namespace MovieEntities
{

	public class MoviesContext : DbContext
	{

    public DbSet<Genre> Genres { get; set; } 
    public DbSet<Movie> Movies {  get; set; }
    public DbSet<Person> People { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer(
          "Data Source= (localdb)\\MSSQLLocalDB; Initial Catalog=Movies");
    }

  }

}