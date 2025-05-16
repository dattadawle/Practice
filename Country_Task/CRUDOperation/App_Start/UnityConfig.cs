using CRUDOperation.Models;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace CRUDOperation
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));

            container.RegisterType<ProductDbContext>();
            container.RegisterType<ICategoryDAl, CategoryDal>();
            container.RegisterType<ICategoryBAL, CategoryBAL>();
        }
    }
}