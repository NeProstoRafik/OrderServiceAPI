using Microsoft.EntityFrameworkCore;
using OrderServiceAPI.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderServiceAPI.DAL
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{
			//  Database.EnsureDeleted();
			//Database.EnsureCreated();
		}

		public DbSet<Order> DbOrder{ get; set; }
	}
}
