Context context = new Context(new StateA());
context.Request(); // State A handling
context.SetState(new StateB());
context.Request(); // State B handling

// State interface
interface IState { void Handle(); }

// Concrete States
class StateA : IState { public void Handle() => Console.WriteLine("State A handling"); }
class StateB : IState { public void Handle() => Console.WriteLine("State B handling"); }

// Context switches between states
class Context
{
    private IState _state;
    public Context(IState state) => _state = state;
    public void SetState(IState state) => _state = state;
    public void Request() => _state.Handle();
}
