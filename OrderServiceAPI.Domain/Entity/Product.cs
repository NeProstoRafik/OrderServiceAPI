﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderServiceAPI.Domain.Entity
{
	public class Product
	{
		public Guid Id { get; set; }=new Guid();
		public int Count{ get; set; } 
	}
}
