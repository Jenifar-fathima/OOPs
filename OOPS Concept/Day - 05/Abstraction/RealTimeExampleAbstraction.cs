namespace RealTimeExampleAbstractionProblem
{
    class RealTimeExampleAbstraction
    {
        public static void Solution()
        {
            SavingBank savingBank = new SavingBank();
            CurrentBank currentBank = new CurrentBank();

            savingBank.InterestOption();
            currentBank.InterestOption();
        }
    }
    abstract class BankOption
    {
        public abstract void InterestOption();
    }
    class SavingBank : BankOption
    {
        public override void InterestOption()
        {
            Console.WriteLine("This is saving account ");
        }
    }
    class CurrentBank : BankOption
    {
        public override void InterestOption()
        {
            Console.WriteLine("This is current account");
        }
    }
}
