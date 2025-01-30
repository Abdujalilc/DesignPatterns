interface IMessage
{
    string GetContent();
}
class TextMessage(string content) : IMessage
{
    public string GetContent() => content;
}
abstract class MessageDecorator(IMessage msg) : IMessage
{
    protected IMessage _msg = msg; 
    public abstract string GetContent();
}
class EncryptedMessage(IMessage msg) : MessageDecorator(msg)
{
    public override string GetContent() => $"[Encrypted] {_msg.GetContent()}";
}
class HtmlMessage(IMessage msg) : MessageDecorator(msg)
{
    public override string GetContent() => $"<html>{_msg.GetContent()}</html>";
}
class Program
{
    static void Main()
    {
        IMessage msg = new HtmlMessage(new EncryptedMessage(new TextMessage("Hello, World!")));
        Console.WriteLine(msg.GetContent()); // <html>[Encrypted] Hello, World!</html>
    }
}
