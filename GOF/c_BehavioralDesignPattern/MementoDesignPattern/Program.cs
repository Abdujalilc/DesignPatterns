Caretaker caretaker = new Caretaker();
Editor editor = new Editor();

editor.Write("Version 1");
caretaker.Save(editor.CreateMemento()); // Save state

editor.Write("Version 2");
editor.Restore(caretaker.GetMemento()); // Undo to Version 1
Console.WriteLine(editor.GetText()); // Output: Version 1

// Memento stores state
class Memento { public string State { get; } public Memento(string state) => State = state; }

// Originator creates/restores state
class Editor
{
    private string _text = "";
    public void Write(string text) => _text = text;
    public Memento CreateMemento() => new Memento(_text);
    public void Restore(Memento memento) => _text = memento.State;
    public string GetText() => _text;
}

// Caretaker manages history
class Caretaker
{
    private Memento _memento;
    public void Save(Memento memento) => _memento = memento;
    public Memento GetMemento() => _memento;
}