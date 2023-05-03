using Microsoft.EntityFrameworkCore;
using OrderServiceAPI.DAL.Interfaces;
using OrderServiceAPI.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderServiceAPI.DAL.Repositories
{
	public class OrderRepository :IOrderRepository
	{
		private readonly ApplicationDbContext _context;

		public OrderRepository(ApplicationDbContext context)
		{
			_context = context;
		}		
		
		public async Task Create(Order entity)
		{
			await _context.DbOrder.AddAsync(entity);
			await _context.SaveChangesAsync();
		}

		public async Task Delete(Order entity)
		{
			_context.DbOrder.Remove(entity);
			await _context.SaveChangesAsync();
		}

		public async Task<Order> Get(Guid id)
		{
			return await _context.DbOrder.FirstOrDefaultAsync(x => x.Id == id);
		}

		public async Task<IEnumerable<Order>> GetAll()
		{
			return await _context.DbOrder.ToListAsync();
		}

		public async Task<Order> Update(Order entity)
		{
			_context.DbOrder.Update(entity);
			await _context.SaveChangesAsync();
			return entity;
		}
	}
}
