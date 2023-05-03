using OrderServiceAPI.DAL.Interfaces;
using OrderServiceAPI.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderServiceAPI.DAL.Repositories
{
	public interface IOrderRepository :IOrderRepository<Order>
	{
		Task Create(Order entity);
		Task<Order> Get(Guid id); // возращает сущность						  
		Task Delete(Order entity);
		Task<Order> Update(Order entity);
		Task<IEnumerable<Order>> GetAll();
	}
}
