using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject.Modules;
using EnrollmentClassLibrary.Models;
using QuickEnrollment.Controllers;

namespace QuickEnrollment.Infrastructure
{
    public class NinjectTransactionModule:Ninject.Modules.NinjectModule
    {
        public override void Load()
        {
            Bind<ITransaction>().To<EnrollmentTransaction>().WhenInjectedExactlyInto<HomeController>();
//            Bind<ITransaction>().To<EnrollmentTransaction>();
        }
    }
}