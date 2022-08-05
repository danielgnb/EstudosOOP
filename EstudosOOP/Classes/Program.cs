using EstudosOOP;
using EstudosOOP.Static_Classes;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        #region EXERCÍCIO - INSTANCIANDO CLASSES              

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
        #region EXERCÍCIO - CLASSES ESTÁTICAS  

        /*
        Console.WriteLine("Qual é a cotação do dólar?");
        double cotacao = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Quantos dólares você vai comprar? ");
        double dolaresComprados = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine();
        Console.WriteLine($"Valor a ser pago em reais: {ConversorDeMoeda.ConverterParaReal(dolaresComprados, cotacao).ToString("F2", CultureInfo.InvariantCulture)}");
        */

        #endregion
        #region EXERCÍCIO - ENTENDENDO OS CONSTRUTORES 

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
        #region EXERCÍCIO - VETORES        

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
        #region EXERCÍCIO VETORES E CLASSES

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
        #region EXERCÍCIO - PARAMS

        /*
         * Usando a palavra-chave params, você pode especificar um params que aceita um número variável de argumentos. 
         * O tipo de parâmetro deve ser uma matriz unidimensional.
         * 
         * O que é uma matriz unidimensional ou vetor?
         * É um conjunto de variáveis do mesmo tipo acessíveis com um único nome. 
         * Armazenadas de forma contínua e ocupando as posições de forma fixas.
         * Pode-se dizer que vetor é uma matriz unidimensional.
         */

        /*         
        //int resultSoma = Calculadora.Soma(new int[] { 2, 2 }); --> Forma verbosa sem utilizar o argumento "params", mas também funcional
        int resultSoma = Calculadora.Soma(2, 2); // --> Utilizando o argumento "params" no método Soma()
        Console.WriteLine(resultSoma);
        */

        #endregion
        #region EXERCÍCIO - MODIFICADORES DE PARÂMETROS REF e OUT

        /*
         * Modificador REF: O ref é para passar o argumento por referência, ou seja, em vez de passar o seu valor,
         * passa-se um apontador que indica onde está o valor. Desta forma quando o parâmetro tiver alterado seu valor,
         * estará alterando o valor do argumento já que eles estão na mesma posição de memória.
         * 
         * Resumo: 
         *
         * Modificador OUT: O out indica que o argumento a ser passado receberá um valor dentro do método. Ou seja, é uma referência também,
         * mas não é passado nenhum valor para o parâmetro, é apenas uma forma de dar saída para um valor.
         * Isto normalmente é necessário porque o return só pode ter um valor.
         * 
         * Resumo: O modificador out é similar ao ref (faz o parâmetro ser uma referência para a variável original),
         * mas não exige que a variável original seja iniciada.
        */

        /*
        int a = 10;
        Calculadora.Triplicar(ref a);
        Console.WriteLine(a);

        int b = 10;
        int triplo;
        Calculadora.Triplicar(b, out triplo);
        Console.WriteLine(triplo);
        */

        #endregion
        #region EXERCÍCIO - BOXING E UNBOXING



        #endregion
    }
}
