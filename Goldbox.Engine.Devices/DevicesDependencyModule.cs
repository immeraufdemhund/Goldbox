using System;
using Goldbox.Engine.DependencyResolution;

namespace Goldbox.Engine.Devices
{
    public class DevicesDependencyModule : IDependencyModule
    {
        public void Configure(IRegisterDependencyConfiguration configuration)
        {
            configuration.Register<IGameDisplayControllerFactory>().With(new GameDisplayControllerFactory());
        }
    }
}
