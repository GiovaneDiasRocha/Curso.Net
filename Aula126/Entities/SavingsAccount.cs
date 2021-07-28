namespace Aula126.Entities
{
    public class SavingsAccount : Account
    {
        public double InterestRate { get; set; }
        
        public SavingsAccount () {}
        public SavingsAccount (int number, string holder, double balance, double interestRate) 
        //Aproveitando o construtor da super classe
        : base (number, holder, balance) 
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance() {
            Balance += Balance * InterestRate;
        }
    }
}