using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OrderServiceAPI.Domain.Enum
{
	public enum Status
	{
		[Display(Name = "Новый заказ")]
		New =1,
		[Display(Name = "Ожидает оплату")]
		AwaitingPayment =2,
		[Display(Name = "Оплачен")]
		Paid =3,
		[Display(Name = "передан в доставку")]
		SentForDelivery=4,
		[Display(Name = "Доставлен")]
		Delivered =5,
		[Display(Name = "Завершен")] 
		Completed=6,
	

	}
}
