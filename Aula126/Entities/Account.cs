namespace Aula126.Entities
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

         public void WithDraw (double almost) {
             Balance -= almost;
         }

         public void Deposit (double almost) {
             Balance += almost;
         }
    }
}