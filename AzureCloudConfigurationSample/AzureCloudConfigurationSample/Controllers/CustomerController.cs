using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AzureCloudConfigurationSample.Models.Entities;

namespace AzureCloudConfigurationSample.Controllers
{
	public class CustomerController : Controller
	{
		private MariaDBContext db = new MariaDBContext();

		// GET: Customer
		public ActionResult Index()
		{
			var list = db.Customers.ToList();

			return View(list);
		}
	}
}