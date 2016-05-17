using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AzureCloudConfigurationSample.Models.Entities
{
	[Table("OrderProducts")]
	public class OrderProduct
	{
		public int OrderProductId { get; set; }

		public int OrderId { get; set; }
		public virtual Order Order { get; set; }

		public int ProductId { get; set; }
		public virtual Product Product { get; set; }

		[Display(Name = "Created")]
		public DateTime CreatedDate { get; set; }
	}
}