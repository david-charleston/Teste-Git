using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExConstrutor1
{
    public class Produto
    {
        // Por padrão vamos colocar um _ seguido de letra minúscula quando um atributo é privado
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto()
        {
        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        // Referênciando outro construtor em um construtor
        public Produto(string nome, double preco) : this()
        {
            _nome = nome;
            Preco = preco;
        }

        public string Nome
        {
            get { return _nome; }
            set {
                // O value representa o parâmetro que seria passado em um método set comum
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public int AdicionarProduto(int qtd)
        {
            return Quantidade += qtd;
        }

        public int RemoverProduto(int qtd)
        {
            return Quantidade -= qtd;
        }

        public override string ToString()
        {
            return _nome
                + ", R$"
                + Preco.ToString("F2")
                + ", "
                + Quantidade
                + " unidades, Total = "
                + string.Format("{0:c2}", ValorTotalEmEstoque());
        }
    }
}
