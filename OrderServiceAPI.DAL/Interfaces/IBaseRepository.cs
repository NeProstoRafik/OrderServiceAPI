using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderServiceAPI.DAL.Interfaces
{
	public interface IOrderRepository<T>
	{
		Task Create(T entity); 
		Task<T> Get(Guid id); // возращает сущность						  
		Task Delete(T entity);
		Task<T> Update(T entity);
		Task<IEnumerable<T>> GetAll();
	}
}
