using System;

namespace Aula133ExercicioProposto.Entities
{
    public class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }
        public override string PriceTag()
        {
            return base.PriceTag() + $" (Manufacture Date: {ManufactureDate.ToString("dd/MM/yyyy")})";
        }
    }
}