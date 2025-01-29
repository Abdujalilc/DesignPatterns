namespace ChainOfResponsibilityDesignPattern
{
    public class ATM
    {
        private readonly TwoThousandHandler twoThousandHandler = new TwoThousandHandler();
        private readonly FiveHundredHandler fiveHundredHandler = new FiveHundredHandler();
        private readonly TwoHundredHandler twoHundredHandler = new TwoHundredHandler();
        private readonly HundredHandler hundredHandler = new HundredHandler();

        public ATM()
        {
            // Prepare the chain of Handlers
            twoThousandHandler.nextHandler(fiveHundredHandler);
            fiveHundredHandler.nextHandler(twoHundredHandler);
            twoHundredHandler.nextHandler(hundredHandler);
        }
        public void withdraw(long requestedAmount)
        {
            twoThousandHandler.dispatchRs(requestedAmount);
        }
    }
}