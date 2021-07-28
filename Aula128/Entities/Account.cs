namespace Aula128.Entities
{
    public class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
 
         public Account () {}
         
         public Account (int number, string holder, double balance) {
            Number = number;
            Holder = holder;
            Balance = balance;
         }

         public virtual void Withdraw (double almost) {
             Balance -= almost + 5;
         }

         public void Deposit (double almost) {
             Balance += almost;
         }
    }
}