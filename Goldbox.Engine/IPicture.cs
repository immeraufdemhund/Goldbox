namespace Goldbox.Engine
{
    public interface IPicture
    {
        int X { get; }
        int Y { get; }
        int Height { get; }
        int Width { get; }
        byte[] Data { get; }
    }
}