using OrderServiceAPI.Domain.Entity;
using OrderServiceAPI.Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderServiceAPI.Domain.ViewModel
{
	public class OrderViewModel
	{
		[Required(ErrorMessage = "Не указан айди")]
		public Guid IdOrder { get; set; } = new Guid();
		//	public Status Status { get; set; }
		//	public DateTime DateCreated { get; set; }
		[Required(ErrorMessage = "Не указаны продукты")]
		public List<Product> Products { get; set; }
	}
}
