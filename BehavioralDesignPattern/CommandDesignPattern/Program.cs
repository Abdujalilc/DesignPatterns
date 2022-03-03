using CommandDesignPattern;

//create new instance
Document document = new Document();
//create new instances
ICommand openCommand = new OpenCommand(document);
ICommand saveCommand = new SaveCommand(document);
ICommand closeCommand = new CloseCommand(document);
//get objects by Interface and call methods
MenuOptions menu = new MenuOptions(openCommand, saveCommand, closeCommand);
menu.clickOpen();
menu.clickSave();
menu.clickClose();

Console.ReadKey();