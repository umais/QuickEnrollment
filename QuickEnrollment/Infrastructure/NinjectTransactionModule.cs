using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject.Modules;
using EnrollmentClassLibrary;
using QuickEnrollment.Controllers;
namespace QuickEnrollment.Infrastructure
{
    public class NinjectTransactionModule:Ninject.Modules.NinjectModule
    {
        public override void Load()
        {
            Bind<ITransaction>().To<BaseTransaction>().WhenInjectedExactlyInto<HomeController>();
//            Bind<ITransaction>().To<EnrollmentTransaction>();
        }
    }
}