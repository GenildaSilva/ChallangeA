using Ninject;
using Ninject.Syntax;
using System.Collections.Generic;
using System.Web.Mvc;
using System;
using ChallangeA.Interface;
using ChallangeA.Models;

namespace ChallangeA.App_Start
{
    public class IocConfig
    {
        public static void ConfigurarDependencias()
        {
            //Create the Container
            IKernel kernel = new StandardKernel();

            //Map the interface IList to the class List
            kernel.Bind<IProductList>().To<ProductList>();

            //Register the container in ASP.NET
            DependencyResolver.SetResolver(new NinjectDependencyResolver(kernel));
        }
    }

    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel _kernel;

        public NinjectDependencyResolver()
        {
            _kernel = new StandardKernel();

            RegisterServices(_kernel);
        }

        public NinjectDependencyResolver(IKernel kernel)
        {
            _kernel = kernel;
        }

        public object GetService(Type serviceType)
        {
            return _kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _kernel.GetAll(serviceType);
        }

        public static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<IProductList>().To<ProductList>();
        }
    }
}