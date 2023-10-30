using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPS_Logical_and_Review_Code.Class
{
	class Product
	{
		public Product(string sku, decimal price)
		{
			SKU = sku;
			Price = price;
		}
		public string SKU { get; set; }
		public decimal Price { get; set; }
	}
}
