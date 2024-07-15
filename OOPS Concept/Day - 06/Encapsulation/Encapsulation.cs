namespace EncapsulationProblem
{
    public class BankAccount
    {
        private decimal balance;

        public BankAccount(decimal initialBalance)
        {
            balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient funds!!");
            }
        }

        public decimal GetBalance() 
        {
            return balance; 
        }
    }

    class EncapsulationProgram
    {
        public static void Solution()
        {
            BankAccount myAccount = new BankAccount(20000);
            Console.Write("Enter the amount to deposit :");
            _ = int.TryParse(Console.ReadLine(), out int nDeposit);
            myAccount.Deposit(nDeposit);
            Console.WriteLine("Balance: "+ myAccount.GetBalance());
            Console.Write("Enter the amount to withdraw :");
            _ = int.TryParse(Console.ReadLine(), out int nWithDraw);
            myAccount.Withdraw(nWithDraw);
            Console.WriteLine("Balance: "+ myAccount.GetBalance());
        }
    }
}
