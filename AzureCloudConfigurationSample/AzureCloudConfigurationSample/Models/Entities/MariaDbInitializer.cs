using System.Data.Entity;

namespace AzureCloudConfigurationSample.Models.Entities
{
	public class MariaDbInitializer : CreateDatabaseIfNotExists<MariaDBContext>
	{
		protected override void Seed(MariaDBContext context)
		{
			base.Seed(context);
		}
	}
}