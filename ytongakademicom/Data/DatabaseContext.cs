using Microsoft.EntityFrameworkCore;
using ytongakademicom.Models;

namespace ytongakademicom.Data
{
	public class DatabaseContext : DbContext
	{
		public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
		{

		}
		public DbSet<Models.Basvuru> basvurus { get; set; }
		
		public DbSet<BasvuruDtoList> basvuruDtoLists { get; set; }
	
	}
}
