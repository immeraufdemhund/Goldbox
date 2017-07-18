using System;
using System.Collections.Generic;

namespace Goldbox.Engine.Devices
{
    internal class GameDisplayControllerFactory : IGameDisplayControllerFactory
    {
        public IDictionary<DisplayMode, IGameDisplayController> GameDisplayControllers => new Dictionary<DisplayMode, IGameDisplayController>
        {
            { DisplayMode.Ega, new EgaGameDisplayController() }
        };
    }

    internal class EgaGameDisplayController : IGameDisplayController
    {
        public event DisplayUpdatedHandler Updated;

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public void Draw(IPicture picture, int x = 0, int y = 0)
        {
            throw new NotImplementedException();
        }

        public void Resume()
        {
            throw new NotImplementedException();
        }

        public void Suspend()
        {
            throw new NotImplementedException();
        }

        public void Write(string text, int x = 0, int y = 0, DisplayColors foregroundColor = DisplayColors.Black)
        {
            throw new NotImplementedException();
        }
    }
}
