Light light = new Light();
RemoteControl remote = new RemoteControl();
remote.SetCommand(new LightOnCommand(light)); remote.PressButton(); // Light is ON
remote.SetCommand(new LightOffCommand(light)); remote.PressButton(); // Light is OFF

class RemoteControl // Invoker
{
    private ICommand _command;
    public void SetCommand(ICommand command) => _command = command;
    public void PressButton() => _command.Execute();
}
interface ICommand { void Execute(); } // Command interface
class LightOnCommand : ICommand // Concrete Command
{
    private Light _light;
    public LightOnCommand(Light light) => _light = light;
    public void Execute() => _light.On();
}
class LightOffCommand : ICommand // Concrete Command
{
    private Light _light;
    public LightOffCommand(Light light) => _light = light;
    public void Execute() => _light.Off();
}
class Light // Receiver
{
    public void On() => Console.WriteLine("Light is ON");
    public void Off() => Console.WriteLine("Light is OFF");
}