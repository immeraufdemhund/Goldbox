using System;
using Microsoft.Practices.Unity;
using System.Collections.Generic;

namespace Goldbox.Engine.DependencyResolution
{
    internal class RegisterDependencyConfiguration : IRegisterDependencyConfiguration, IDisposable
    {
        private readonly IUnityContainer _kernel;
        private readonly ICollection<ICommitToKernel> _commiters;

        public RegisterDependencyConfiguration(IUnityContainer kernel)
        {
            _kernel = kernel;
            _commiters = new List<ICommitToKernel>();
        }

        public IRegisterDependencyItem<TInterface> Register<TInterface>()
        {
            var commiter = new RegisterDependencyItem<TInterface>();
            _commiters.Add(commiter);
            return commiter;
        }

        public void RegisterModule<TDependencyModule>() where TDependencyModule : IDependencyModule, new()
        {
            var fullyQualifiedName = typeof(TDependencyModule).FullName;
            if (_kernel.IsRegistered<TDependencyModule>(fullyQualifiedName))
                throw new InvalidOperationException($"The dependency module '{fullyQualifiedName}' has already been registered");

            var depenencyModule = new TDependencyModule();
            _kernel.RegisterInstance(fullyQualifiedName, depenencyModule);
            depenencyModule.Configure(this);
        }

        public void Dispose()
        {
            foreach (var canCommitToKernel in _commiters)
            {
                canCommitToKernel.Commit(_kernel);
            }
        }
    }
}
