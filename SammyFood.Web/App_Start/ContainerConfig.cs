﻿using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using SammyFood.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace SammyFood.Web.App_Start
{
    public class ContainerConfig
    {
        internal static void RegisterContainer(HttpConfiguration httpConfiguration)
        {
            // throw new NotImplementedException();
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterApiControllers(typeof(MvcApplication).Assembly);

            //  builder.RegisterType<InMemoryRestaurantData>().As<IRestaurantData>().SingleInstance();

            builder.RegisterType<SqlRestaurantData>().As<IRestaurantData>().InstancePerRequest();

            builder.RegisterType<SammyFoodDbContext>().InstancePerRequest();

            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            httpConfiguration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}