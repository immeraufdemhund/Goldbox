using Microsoft.Practices.Unity;

namespace Goldbox.Engine.DependencyResolution
{
    internal interface ICommitToKernel
    {
        void Commit(IUnityContainer kernel);
    }
}
