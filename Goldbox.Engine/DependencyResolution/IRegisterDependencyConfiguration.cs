namespace Goldbox.Engine.DependencyResolution
{
    public interface IRegisterDependencyConfiguration
    {
        IRegisterDependencyItem<TInterface> Register<TInterface>();
        void RegisterModule<TDependencyModule>() where TDependencyModule : IDependencyModule, new();
    }
}
