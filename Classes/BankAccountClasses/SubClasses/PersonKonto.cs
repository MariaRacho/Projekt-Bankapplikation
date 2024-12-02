namespace Projekt_Bankkonsolapplikation.Classes.BankAccountClasses.SubClasses
{
    public class PersonKonto : BankAccount
    {
        public PersonKonto(string accountUserName, int accountNumber, double balance) : base(accountUserName, accountNumber, balance)
        {
        }
    }
}
