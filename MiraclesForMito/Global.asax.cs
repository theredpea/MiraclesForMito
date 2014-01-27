﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using MiraclesForMito.Models;

namespace MiraclesForMito
{
	// Note: For instructions on enabling IIS6 or IIS7 classic mode, 
	// visit http://go.microsoft.com/?LinkId=9394801

	public class MvcApplication : System.Web.HttpApplication
	{
		protected void Application_Start()
		{
			// Empy the database if someone makes a change
			Database.SetInitializer<SiteDB>(new DropCreateDatabaseIfModelChanges<SiteDB>());
			//Database.SetInitializer<SiteDB>(new DropCreateDatabaseAlways<SiteDB>());
			//Database.SetInitializer<SiteDB>(null);

			AreaRegistration.RegisterAllAreas();

			WebApiConfig.Register(GlobalConfiguration.Configuration);
			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			BundleConfig.RegisterBundles(BundleTable.Bundles);
		}
	}
}