using System.Globalization;
namespace Course
{
    public class Produto
    {
        private string _nomeDoProduto;
        public double PrecoDoProduto {get; private set;}
        public int QuantidadeDoProduto { get; private set; }
        
        

        public Produto()
        {
            QuantidadeDoProduto = 0;
        }

        public Produto(string nome, double preco) : this()
        {
            _nomeDoProduto = nome;
            PrecoDoProduto = preco;
        }

        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            QuantidadeDoProduto = quantidade;
        }

        public string Nome
        {
            get { return _nomeDoProduto; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nomeDoProduto = value;
                }
            }
        }

        public double Preco
        {
            get { return PrecoDoProduto; }
        }

        public int Quantidade
        {
            get { return QuantidadeDoProduto; }
        }

        public double valorTotalEmEstoque()
        {
            return QuantidadeDoProduto * PrecoDoProduto;
        }

        public void adicionarProdutos(int quant)
        {
            QuantidadeDoProduto += quant;
        }

        public void removerProdutos(int quant)
        {
            QuantidadeDoProduto -= quant;
        }

        public override string ToString()
        {
            return $"Dados do produto: {_nomeDoProduto}, R${PrecoDoProduto.ToString("F2", CultureInfo.InvariantCulture)}, {QuantidadeDoProduto} unidades, Total: R${valorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}.";
        }
    }
}