using System.Collections.Generic;
using System.Text;

namespace Aula133ExercicioProposto.Entities
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public List<Product> ListProduct { get; set; } = new List<Product>();

        public Product() { }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            return Name + " $ " + Price.ToString();
        }

        public void AddProductInList(Product product)
        {
            ListProduct.Add(product);
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (Product item in ListProduct)
            {
                stringBuilder.AppendLine(item.PriceTag());
            }

            return stringBuilder.ToString();
        }
    }
}