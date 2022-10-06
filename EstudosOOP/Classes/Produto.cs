﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;

namespace EstudosOOP
{
    internal class Produto
    {
        private string Nome { get; set; }
        private double Preco { get; set; }
        private int Quantidade { get; set; }

        public Produto(string Nome, double Preco, int Quantidade)
        {
            this.Nome = Nome;
            this.Preco = Preco;
            this.Quantidade = Quantidade;
        }

        public Produto()
        {
        }

        public double ValorTotalEmEstoque()
        {
            double valorTotal = Preco * Quantidade;
            return valorTotal;
        }

        public override string ToString()
        {
            return $"{Nome}, R${Preco.ToString("F2", CultureInfo.InvariantCulture)}," +
                $" {Quantidade} unidades," + $" Total: R${ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
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
