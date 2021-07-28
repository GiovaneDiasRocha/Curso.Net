namespace Aula128.Entities
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

        public override void Withdraw(double almost)
        {
            //Balance -= almost;
            base.Withdraw(almost); //dessa maneira aproveita-se a funcionalidade do método que está sendo sobescrito na superclasse, utilizando o "base".
            Balance -= 2;
        }
    }
}