using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AzureCloudConfigurationSample.Models.Entities
{
	[Table("Orders")]
	public class Order
	{
		public int OrderId { get; set; }

		[Required]
		public int CustomerId { get; set; }
		public virtual Customer Customer { get; set; }

		[Display(Name = "Created")]
		public DateTime CreatedDate { get; set; }
	}
}