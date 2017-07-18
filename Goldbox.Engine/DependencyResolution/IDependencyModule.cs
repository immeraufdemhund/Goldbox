namespace Goldbox.Engine.DependencyResolution
{
    public interface IDependencyModule
    {
        void Configure(IRegisterDependencyConfiguration configuration);
    }
}
