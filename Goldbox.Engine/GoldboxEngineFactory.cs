using Goldbox.Engine.DependencyResolution;

namespace Goldbox.Engine
{
    public class GoldboxEngineFactory
    {
        public static IDisplay GetDisplay()
        {
            var display = IoC.Get<IGameDisplayControllerFactory>().GameDisplayControllers[DisplayMode.Ega];
            return display;
        }
    }
}
