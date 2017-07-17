using System;

namespace Goldbox.Engine
{
    public class GoldboxEngineFactory
    {
        public static IDisplay GetDisplay()
        {
            var display = new EgaDisplay();
            return display;
        }
    }

    internal class EgaDisplay : IGameDisplayController
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
