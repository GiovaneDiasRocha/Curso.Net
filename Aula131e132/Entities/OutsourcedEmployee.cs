namespace Aula131e132.Entities
{
    public class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }
        public override double Payment()
        {
            return base.Payment() + (AdditionalCharge * 1.1);
        }
    }
}