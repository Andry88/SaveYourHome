﻿using Ninject;
using SaveMyHome.Abstract;
using SaveMyHome.Helpers;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace SaveMyHome.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;
        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }
        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }
        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            kernel.Bind<INotifyProcessor>().To<EmailNotifyProcessor>()
                .WithConstructorArgument("settings", new EmailSettings());
        } 
    }
}