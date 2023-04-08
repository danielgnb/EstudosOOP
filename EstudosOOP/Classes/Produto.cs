using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;
using EstudosOOP.Classes;

namespace EstudosOOP
{
    internal class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public Categoria Categoria { get; set; }

        public Produto(string Nome, double Preco, int Quantidade)
        {
            this.Nome = Nome;
            this.Preco = Preco;
            this.Quantidade = Quantidade;
        }

        public Produto(string Nome, double Preco, int Quantidade, Categoria Categoria)
        {
            this.Nome = Nome;
            this.Preco = Preco;
            this.Quantidade = Quantidade;
            this.Categoria = Categoria;
        }

        public Produto() { }

        public double ValorTotalEmEstoque()
        {
            double valorTotal = Preco * Quantidade;
            return valorTotal;
        }

        public override string ToString()
        {
            return $"{Nome}, R${Preco.ToString("F2", CultureInfo.InvariantCulture)}," +
                $" {Quantidade} unidades," + $" Total: R${ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}" +
                $" Tier: {Categoria.Tier}";
        }

        public void AdicionarProdutos(int quantity)
        {
            Quantidade = Quantidade + quantity;
        }       

        public void RemoverProdutos(int quantity)
        {
            Quantidade = Quantidade - quantity;
        }
    }
}
