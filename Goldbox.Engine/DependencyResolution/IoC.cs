using System;
using Microsoft.Practices.Unity;
using System.Linq;

namespace Goldbox.Engine.DependencyResolution
{
    public class IoC
    {
        private static IUnityContainer Kernel;

        static IoC()
        {
            Kernel = new UnityContainer();
        }

        public static void Initialize()
        {
            Kernel.RegisterTypes(AllClasses.FromAssembliesInBasePath()
                .Where(type => typeof(IDependencyModule).IsAssignableFrom(type)),
                WithMappings.FromAllInterfaces,
                WithName.TypeName,
                WithLifetime.ExternallyControlled);

            foreach (var modules in Kernel.ResolveAll<IDependencyModule>())
                Configure(modules.Configure);
        }

        public static T Get<T>()
        {
            return Kernel.Resolve<T>();
        }

        public static T Get<T>(string name)
        {
            return Kernel.Resolve<T>(name);
        }

        public static void Configure(Action<IRegisterDependencyConfiguration> configureAction)
        {
            using (var configuration = new RegisterDependencyConfiguration(Kernel))
            {
                configureAction(configuration);
            }
        }

        public static void Reset()
        {
            Kernel?.Dispose();
            Kernel = new UnityContainer();
        }
    }
}
