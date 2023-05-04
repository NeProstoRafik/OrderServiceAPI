using OrderServiceAPI.Domain.Entity;
using System.ComponentModel.DataAnnotations;

namespace OrderServiceAPI.Domain.ViewModel
{
	public class OrderViewModelUpdate
	{
		[Required(ErrorMessage = "Не указан айди")]
		public Guid IdOrder { get; set; } = new Guid();
		[Required(ErrorMessage = "Не указан статус")]
		public Enum.Status Status { get; set; }
		[Required(ErrorMessage = "Не указаны продукты")]
		public List<Product> Products { get; set; }
	}
}
