namespace Projekt_Bankkonsolapplikation.Classes.BankAccountClasses
{
    public class BankAccount
    {
        public string AccountUserName { get; set; }
        public int AccountNumber { get; set; }
        public double Balance { get; set; }

        //Konstruktor
        public BankAccount(string accountUserName, int accountNumber, double balance)
        {
            AccountUserName = accountUserName;
            AccountNumber = accountNumber;
            Balance = balance;
        }

        public void Deposit(int amountToDeposit)
        {
            Balance += amountToDeposit;
            Console.WriteLine($"Your balance is {Balance}");
        }

        public void Draw(int amountToDraw)
        {
            Balance -= amountToDraw;
            Console.WriteLine($"Your balance is {Balance}");
        }

        public void CheckBalance()
        {
            Console.WriteLine($"Your balance is {Balance}");
        }
    }
}
