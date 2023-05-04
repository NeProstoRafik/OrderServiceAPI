using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderServiceAPI.Domain.Entity
{
	public class Product
	{
		public Guid Id { get; set; }= Guid.NewGuid() ;
		
		[Range(1, int.MaxValue, ErrorMessage = "не допустимое количество")]
		public int Count { get; set; }



	}
}
