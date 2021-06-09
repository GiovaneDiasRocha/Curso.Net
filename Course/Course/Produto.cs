using System.Globalization;
namespace Course
{
    public class Produto
    {
        public string nomeDoProduto;
        public double precoDoProduto;
        public int quantidadeDoProduto;

        public double valorTotalEmEstoque()
        {
            return quantidadeDoProduto * precoDoProduto;
        }

        public void adicionarProdutos(int quant)
        {
            quantidadeDoProduto += quant;
        }

        public void removerProdutos(int quant)
        {
            quantidadeDoProduto -= quant;
        }

        public override string ToString()
        {
            return $"Dados do produto: {nomeDoProduto}, R${precoDoProduto.ToString("F2", CultureInfo.InvariantCulture)}, {quantidadeDoProduto} unidades, Total: R${valorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}.";
        }
    }
}