using EstudosOOP;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        #region EXERCÍCIO 1              

        /*
        Produto produto = new();        

        Console.Write("Digite o nome do produto: ");
        produto.Nome = Console.ReadLine();
        Console.Write("Digite o preço do produto: ");
        produto.Preco = Convert.ToDouble(Console.ReadLine().Trim(), CultureInfo.InvariantCulture);
        Console.Write("Digite a quantidade do produto em estoque: ");
        produto.Quantidade = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Dados do produto: {produto}");

        Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
        produto.AdicionarProdutos(Convert.ToInt32(Console.ReadLine()));
        Console.WriteLine($"Dados atualizados: {produto}");

        Console.Write("Digite o número de produtos a ser removidos ao estoque: ");
        produto.RemoverProdutos(Convert.ToInt32(Console.ReadLine()));
        Console.WriteLine($"Dados atualizados: {produto}");          
        */

        #endregion
        #region EXERCÍCIO 2  

        /*
        Console.WriteLine("Qual é a cotação do dólar?");
        double cotacao = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Quantos dólares você vai comprar? ");
        double dolaresComprados = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine();
        Console.WriteLine($"Valor a ser pago em reais: {ConversorDeMoeda.ConverterParaReal(dolaresComprados, cotacao).ToString("F2", CultureInfo.InvariantCulture)}");
        */

        #endregion
        #region EXERCÍCIO 3

        /*
        Console.Write("Número da conta: ");
        int numConta = Convert.ToInt32(Console.ReadLine());
        Console.Write("Titular da conta: ");
        string titularConta = Console.ReadLine();

        ContaBancaria contaBancaria = new(numConta,titularConta);        

        Console.Write("Haverá depósito inicial? (s/n): ");
        string operacao = "";
        operacao = Console.ReadLine();
        if (operacao == "s" || operacao == "S")
        {
            Console.Write("Valor do depósito inicial: ");
            contaBancaria.ValorDepositoInicial = Convert.ToDouble(Console.ReadLine());
            contaBancaria.AtualizarDadosConta(contaBancaria.ValorDepositoInicial);
        }
        else
        {
            
        }

        Console.WriteLine();

        Console.WriteLine("Dados da conta:");
        Console.WriteLine(contaBancaria);

        Console.WriteLine();
        Console.WriteLine("Valor para depósito: ");
        contaBancaria.AtualizarDadosConta(Convert.ToDouble(Console.ReadLine()));
        Console.WriteLine("Dados da conta atualizados:");
        Console.WriteLine(contaBancaria);

        Console.WriteLine();
        Console.WriteLine("Valor para saque: ");
        contaBancaria.Saque(Convert.ToDouble(Console.ReadLine()));
        Console.WriteLine("Dados da conta atualizados:");
        Console.WriteLine(contaBancaria);
        */

        #endregion
        #region EXERCÍCIO 4        

        /*
        int n = int.Parse(Console.ReadLine());
        double media;
        double[] arrayList = new double[n];
        double soma = 0.0;

        for (int i = 0; i < n; i++)
        {
            arrayList[i] = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        }

        for (int i = 0; i < arrayList.Length; i++)
        {            
            soma += arrayList[i];
        }
        media = soma / n;
        Console.WriteLine($"AVERAGE HEIGHT = {media.ToString("F2",CultureInfo.InvariantCulture)}");
        */
        #endregion
        #region EXERCÍCIO 5

        /*
        Produto produto = new Produto();
        double soma = 0.0;

        Console.Write("Quantos produtos você deseja?:");
        int nProdutos = int.Parse(Console.ReadLine());
        Produto[] vetorProduto = new Produto[nProdutos];

        for (int i = 0; i < nProdutos; i++)
        {
            string name = Console.ReadLine();
            double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            vetorProduto[i] = new Produto { Nome = name, Preco = price };
        }

        for (int i = 0; i < vetorProduto.Length; i++)
        {
            soma += vetorProduto[i].Preco;
        }

        double avg = soma/ nProdutos;
        Console.WriteLine($"AVERAGE PRICE = {avg.ToString("F2",CultureInfo.InvariantCulture)}");
        */

        #endregion
    }
}
