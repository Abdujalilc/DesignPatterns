namespace CommandDesignPattern
{
    public class OpenCommand : ICommand
    {
        private readonly Document document;
        public OpenCommand(Document doc)
        {
            document = doc;
        }
        public void Execute()
        {
            document.Open();
        }
    }
}