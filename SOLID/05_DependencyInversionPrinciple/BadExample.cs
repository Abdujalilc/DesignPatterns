namespace DIP.BadExample
{
    class Program
    {
        static void Main()
        {
            LightSwitch lightSwitch = new LightSwitch();
            lightSwitch.TurnOn();
        }
    }

    public class LightSwitch
    {
        private readonly Bulb _bulb = new Bulb(); // ❌ Direct dependency on a concrete class

        public void TurnOn()
        {
            _bulb.LightUp(); // ❌ Cannot easily switch to a different light source
        }
    }

    public class Bulb
    {
        public void LightUp() => Console.WriteLine("Bulb is on");
    }
}

/*
 * Why is this bad?
 * ❌ Violates DIP → LightSwitch depends on a concrete class (Bulb), making changes harder.
 */
