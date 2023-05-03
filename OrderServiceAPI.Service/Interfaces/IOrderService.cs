using OrderServiceAPI.Domain.Entity;
using OrderServiceAPI.Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderServiceAPI.Service.Interfaces
{
	public interface IOrderService
	{		
		Task<Order> Create(OrderViewModel model);
		Task Delete(Guid id);	
		Task<Order> Update(Guid id, OrderViewModelUpdate model);
		Task<Order> Get(Guid id);
	}
}
