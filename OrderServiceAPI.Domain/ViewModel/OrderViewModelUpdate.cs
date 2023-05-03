using OrderServiceAPI.Domain.Entity;

namespace OrderServiceAPI.Domain.ViewModel
{
	public class OrderViewModelUpdate
	{
		public Guid IdOrder { get; set; } = new Guid();
		public Enum.Status Status { get; set; }
		public List<Product> Products { get; set; }
	}
}
