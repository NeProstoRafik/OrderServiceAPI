using OrderServiceAPI.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderServiceAPI.Domain.Entity
{
	public class Order
	{
		//public int Id { get; set; }
		public Guid Id { get; set; } = new Guid();		
		public Status Status { get; set; }
		public DateTime DateCreated { get; set; }
		public List<Product> Products { get; set; }
	}
}
