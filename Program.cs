using Projekt_Bankkonsolapplikation.Classes.BankAccountClasses;
using Projekt_Bankkonsolapplikation.Classes.UserClass;

namespace Projekt_Bankkonsolapplikation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User maria = new User("Maria");

            bool programIsRunning = true;
            while (programIsRunning)
            {
                PrintOutFirstMeny();
                Console.WriteLine("Please choose an option");
                string optionChoosed = Console.ReadLine();

                switch (optionChoosed)
                {
                    case "1":
                        BankAccount accounrChoosenToDepositMoneyTo = maria.ChooseAnAccount();
                        Console.WriteLine("How much money do you want to deposit");
                        int amountToDeposit = Convert.ToInt32(Console.ReadLine());
                        accounrChoosenToDepositMoneyTo.Deposit(amountToDeposit);
                        break;

                    case "2":
                        BankAccount accounrChoosenToDrawMoneyFrom = maria.ChooseAnAccount();
                        Console.WriteLine("How much money do you want to draw");
                        int amountToDraw = Convert.ToInt32(Console.ReadLine());
                        accounrChoosenToDrawMoneyFrom.Deposit(amountToDraw);

                        break;
                    case "3":
                        Console.WriteLine("How much money do you want to transfer");
                        int amountToTransfer = Convert.ToInt32(Console.ReadLine());
                        maria.TransferMoney(amountToTransfer);
                        break;
                    case "4":
                        BankAccount choosenAccount = maria.ChooseAnAccount();
                        Console.WriteLine("Your account status");
                        choosenAccount.CheckBalance();
                        break;
                    case "5":
                        programIsRunning = false;
                        break;

                    default:
                        Console.WriteLine("Somethings is wrong");
                        break;
                }
            }
        }

        private static void PrintOutAccountMeny()
        {
            Console.WriteLine("You can now :");
            Console.WriteLine("1 - Check saldo");
            Console.WriteLine("2 - Deposit");
            Console.WriteLine("3 - Draw");
            Console.WriteLine("Choose an option");
        }

        private static void PrintOutFirstMeny()
        {
            Console.WriteLine("Welcome to my bank");
            Console.WriteLine("1 - Insert money");
            Console.WriteLine("2 - Take out money");
            Console.WriteLine("3 - Transfer money");
            Console.WriteLine("4 - Check balance");
            Console.WriteLine("5 - Exit");
        }
    }
}
