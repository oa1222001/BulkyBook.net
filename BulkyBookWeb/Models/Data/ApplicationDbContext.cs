using Microsoft.EntityFrameworkCore;

namespace BulkyBookWeb.Models.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
		public virtual DbSet<Category> Categories { get; set; }


	}
}
