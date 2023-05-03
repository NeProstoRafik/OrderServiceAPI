using OrderServiceAPI.Domain.Entity;
using OrderServiceAPI.Domain.ViewModel;
using OrderServiceAPI.Service.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderServiceAPI.DAL.Interfaces;
using System.Runtime.ConstrainedExecution;

namespace OrderServiceAPI.Service.Emplementations
{
	public class OrderService : IOrderService
	{
		private readonly IOrderRepository<Order> _orderRepository;	

		private ILogger<OrderService> _logger;

		public OrderService(IOrderRepository<Order> baseRepository, ILogger<OrderService> logger)
		{
			_orderRepository = baseRepository;
			_logger = logger;
		}

		public async Task<Order> Create(OrderViewModel model)
		{
			try
			{
				var order = new Order()
				{
					Id = model.IdOrder,
					Status = Domain.Enum.Status.New,
					DateCreated =  DateTime.Now,
					Products=model.Products		
				};
			
				_logger.LogInformation($"заказ создался");
			await _orderRepository.Create(order);
				return order;
			}
			catch (Exception ex)
			{
				_logger.LogInformation($"не создалась");
			}
			return null;
		}

		public async Task Delete(Guid id)
		{
			try
			{
				var car = await _orderRepository.Get(id);
			
				await _orderRepository.Delete(car);
				_logger.LogInformation($"заказ удалился");

			}
			catch (Exception ex)
			{
				_logger.LogInformation($"заказ не удалился");
			}
		}

		public async Task<Order> Get(Guid id)
		{
			try
			{		
				_logger.LogInformation($"заказ получен по ИД");
				var order = await _orderRepository.Get(id);
				return order; 
			}
			catch (Exception ex)
			{
				_logger.LogInformation($"заказ не получен по ИД");
			}
			return null;
		}

		public async Task<Order> Update(Guid id, OrderViewModelUpdate model)
		{
			try
			{
				var order = await _orderRepository.Get(id);

				order.Id = model.IdOrder; 
				order.Status = model.Status;			
				order.Products= model.Products;
				_logger.LogInformation($"заказ обновлен");
				return	await _orderRepository.Update(order);
				
			}
			catch (Exception ex)
			{

				_logger.LogInformation($"заказ не обновлен");
				
			}
			return null;
		}
	}
}
