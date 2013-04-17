using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ninject;
using Ninject.Parameters;
using Ninject.Syntax;
using System.Configuration;
using EnrollmentClassLibrary;
using QuickEnrollment.Controllers;
namespace QuickEnrollment.Infrastructure
{
    public class NinjectDependencyResolver:IDependencyResolver
    {
        private IKernel kernel;

        public IKernel Kernel
        {
            get { return kernel; }
            set { kernel = value; }
        }
        public NinjectDependencyResolver()
        {
            kernel = new StandardKernel(new NinjectTransactionModule());
           // AddBindings();
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
            //kernel.Bind<ITransaction>().To<MedicareTransaction>().WhenInjectedExactlyInto<HomeController>();
           // kernel.Bind<ITransaction>().To<OtherTransactions>();
        }
    }
}