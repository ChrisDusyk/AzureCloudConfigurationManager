namespace AzureCloudConfigurationSample.Models.Entities
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Data.Entity.Spatial;

	[Table("Customers")]
	public partial class Customer
	{
		public int CustomerId { get; set; }

		[Required]
		[StringLength(200)]
		[Display(Name = "Customer Name")]
		public string CustomerName { get; set; }

		[Display(Name = "Created")]
		public DateTime CreatedDate { get; set; }
	}
}
