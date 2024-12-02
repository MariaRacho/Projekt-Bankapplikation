using Projekt_Bankkonsolapplikation.Classes.BankAccountClasses;
using Projekt_Bankkonsolapplikation.Classes.BankAccountClasses.SubClasses;

namespace Projekt_Bankkonsolapplikation.Classes.UserClass
{
    public class User
    {
        public string Name { get; set; }

        public PersonKonto PersonKonto { get; set; }

        public SparKonto SparKonto { get; set; }

        public InvesteringsKonto InvesteringsKonto { get; set; }

        public User(string name)
        {
            Name = name;
            PersonKonto = new PersonKonto(Name, 1, 25000);
            SparKonto = new SparKonto(Name, 2, 25000);
            InvesteringsKonto = new InvesteringsKonto(Name, 3, 25000);
        }

        public void TransferMoney(int amountToTransfer)
        {
            Console.WriteLine("Account from which to send money?");
            BankAccount bankAccountFrom = ChooseAnAccount();
            bankAccountFrom.Draw(amountToTransfer);

            Console.WriteLine("Account to which to send money?");
            BankAccount bankAccountTo = ChooseAnAccount();
            bankAccountTo.Deposit(amountToTransfer);

        }

        public BankAccount ChooseAnAccount()
        {
            Console.WriteLine("Please choose an acoount");
            Console.WriteLine("1 - Personlig, 2 - Spar, 3 - Investering");
            string accountChoosen = Console.ReadLine()!;

            switch (accountChoosen)
            {
                case "1":
                    return PersonKonto;

                case "2":
                    return SparKonto;

                case "3":
                    return InvesteringsKonto;

                default:
                    Console.WriteLine("Not a valid account number");
                    return null;
            }
        }
    } 
}
