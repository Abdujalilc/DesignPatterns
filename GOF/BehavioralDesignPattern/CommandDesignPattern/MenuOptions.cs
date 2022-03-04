namespace CommandDesignPattern
{
    public class MenuOptions
    {
        private readonly ICommand openCommand;
        private readonly ICommand saveCommand;
        private readonly ICommand closeCommand;
        public MenuOptions(ICommand open, ICommand save, ICommand close)
        {
            openCommand = open;
            saveCommand = save;
            closeCommand = close;
        }
        public void clickOpen()
        {
            openCommand.Execute();
        }
        public void clickSave()
        {
            saveCommand.Execute();
        }
        public void clickClose()
        {
            closeCommand.Execute();
        }
    }
}