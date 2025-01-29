namespace DIP.GoodExample
{
    class Program
    {
        static void Main()
        {
            ILightSource bulb = new Bulb();
            LightSwitch lightSwitch = new LightSwitch(bulb);
            lightSwitch.TurnOn();
        }
    }
    public interface ILightSource
    {
        void LightUp(); // Abstraction → LightSwitch depends on an interface, not a concrete class
    }
    public class Bulb : ILightSource
    {
        public void LightUp() => Console.WriteLine("Bulb is on");
    }
    public class LightSwitch
    {
        private readonly ILightSource _lightSource;

        public LightSwitch(ILightSource lightSource) // ✅ Dependency is injected via constructor
        {
            _lightSource = lightSource;
        }

        public void TurnOn()
        {
            _lightSource.LightUp(); // ✅ Works with any ILightSource implementation
        }
    }
}
/*
 * Why is this good?
 * ✅ Follows DIP → LightSwitch depends on an abstraction (ILightSource), making it flexible and extensible.
 */
