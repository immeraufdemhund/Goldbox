namespace Goldbox.Engine.DependencyResolution
{
    public interface IRegisterDependencyItem<in TInterface>
    {
        void With<TClass>() where TClass : TInterface;
        void With<TClass>(string name) where TClass : TInterface;
        void With(TInterface singletonInstance);
    }
}
