using Microsoft.AspNetCore.Mvc;
using OrderServiceAPI.Domain.Entity;
using OrderServiceAPI.Domain.ViewModel;
using OrderServiceAPI.Service.Interfaces;

namespace OrderServiceAPI.Controllers
{
	public class OrderController : Controller
	{
		private readonly IOrderService _orderService;

		public OrderController(IOrderService orderService)
		{
			_orderService = orderService;
		}

		
		[HttpPost("Create")]
		public async Task<Order> Create(OrderViewModel model)
		{
			var result =await _orderService.Create(model);
			return result;
			
		}

		[HttpPut("{id}/update")]
		public IActionResult UpdateOrder(Guid id)
		{
			var res = _orderService.Get(id);
			return Ok();
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> Delete(Guid id)
		{
			await _orderService.Delete(id);
			
				return Ok();
			
		}
		[HttpGet("{id}")]
		public async Task< ActionResult<Order>> GetById(Guid id)
		{
			var res=await _orderService.Get(id);
			if (res is not null)
			{
				return res;
			}
			else
			{
				return NotFound();
			}
			
		}
	}
}
