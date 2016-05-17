using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AzureCloudConfigurationSample.Models.Entities
{
	[Table("Products")]
	public class Product
	{
		public int ProductId { get; set; }

		[Required]
		[StringLength(5)]
		[Display(Name = "Product Code")]
		public string ProductCode { get; set; }

		[Required]
		[StringLength(150)]
		public string Description { get; set; }

		[Display(Name = "Created")]
		public DateTime CreatedDate { get; set; }

		[Display(Name = "Last Modified")]
		public DateTime LastModifiedDate { get; set; }
	}
}