namespace Goldbox.Engine
{
    public delegate void DisplayUpdatedHandler(byte[] videoRam, int videoRamSize);
    public interface IDisplay
    {
        event DisplayUpdatedHandler Updated;
    }
    public interface IGameDisplayController : IDisplay
    {
        void Suspend();
        void Resume();

        void Write(string text, int x = 0, int y = 0, DisplayColors foregroundColor = DisplayColors.Black);
        void Draw(IPicture picture, int x = 0, int y = 0);
        void Clear();
    }
}