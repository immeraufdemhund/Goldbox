using System;
using Microsoft.Practices.Unity;

namespace Goldbox.Engine.DependencyResolution
{
    internal class RegisterDependencyItem<TInterface> : IRegisterDependencyItem<TInterface>, ICommitToKernel
    {
        private Action<IUnityContainer> _registerAction;

        public void With<TClass>() where TClass : TInterface
        {
            _registerAction = ioc => ioc.RegisterType<TInterface, TClass>();
        }

        public void With<TClass>(string name) where TClass : TInterface
        {
            _registerAction = ioc => ioc.RegisterType<TInterface, TClass>(name);
        }

        public void With(TInterface singletonInstance)
        {
            _registerAction = ioc => ioc.RegisterInstance(singletonInstance);
        }

        public void Commit(IUnityContainer kernel)
        {
            _registerAction(kernel);
        }
    }
}
