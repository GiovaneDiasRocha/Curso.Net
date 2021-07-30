namespace Aula133ExercicioProposto.Entities
{
    public class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public override string PriceTag()
        {
            return Name + " $ " + TotalPrice() + $" (Customs Fee: $ {CustomsFee})";
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }
    }
}