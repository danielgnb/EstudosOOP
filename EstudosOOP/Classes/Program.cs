using EstudosOOP;
using EstudosOOP.Static_Classes;
using System.Collections.Generic;
using System.Data;
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
         * Resumo: O modificador ref faz o parâmetro ser uma referência para a variável original,
         * mas exige que a variável seja iniciada.
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

        /*
        * BOXING: É o processo de conversão de um objeto tipo valor para um objeto tipo referência compatível.
        * 
        * UNBOXING: É o processo de conversão de um objeto tipo referência para um objeto tipo valor compatível.
        * 
        */

        /*
        int x = 20;
        Object obj = x; // --> BOXING
        int y = (int)obj; // --> UNBOXING
        */
        #endregion
        #region EXERCÍCIO - LAÇO FOR EACH

        /*
        *
        * Sintaxe opcional e simplificada para percorrer coleções.
        * 
        * Coleções: For, For Each, List, Arrays, Dictionary...
        *
        */

        /*
        Dictionary<int, string> dicionario = new Dictionary<int, string>();
        dicionario.Add(1, "Daniel");

        foreach (KeyValuePair<int,string> keyValue in dicionario)
        {
            Console.WriteLine($"Chave:{keyValue.Key} Valor:{keyValue.Value}");
        }

        string[] vetor = new string[] { "Daniel", "João", "Maria" };
        foreach (string item in vetor)
        {
            Console.WriteLine(item);
        }
        */
        #endregion
        #region EXERCÍCIO - LISTAS

        /*
         * Lista é uma estrutura de dados:
         * Homogênea (dados do mesmo tipo);
         * Ordenada (elementos acessados por meio de posições);
         * Inicia vazia, e seus elementos são alocados sob demanda;
         * Cada elemento ocupa um nó (ou nodo) da lista.
         * 
         * Classe: List
         * Namespace: System.Collections.Generic
        */

        /*
         * Métodos da Classe List<>
         * 
         * Inserir elemento na lista: Add, Insert
         * Tamanho da lista: Count
         * Encontrar primeiro ou último elementos da lista que satisfaça um predicado: list.Find, list.FindLast
         * Encontrar primeira ou última posição de elementos da lista que satisfaça um predicado: list.FindIndex, list.FindLastIndex
         * Filtrar a lista com base em um predicado: list.FindAll
         * Remover elementos da lista: Remove, RemoveAll, RemoveAt, RemoveRange
         * 
         * Predicado: O predicado é um tipo de função Lambda que retorna valores booleanos.
         * Funções Lambda: As funções Lambda são chamadas de funções anônimas.
         * Nada mais são do que funções que o usuário não precisa definir,
         * ou seja, não vai precisar escrever a função e depois utilizá-la dentro do código.
        */

        /*
        List<string> myList = new List<string>();

        myList.Add("Daniel");
        myList.Add("Danilo");
        myList.Insert(0, "João");
        Console.WriteLine("Count:" + myList.Count);
        string a = myList.Find(x => x[0] == 'D'); // --> Predicado // --> A função irá procurar a primeira ocorrência da letra D
        Console.WriteLine(a);
        */

        #endregion
        #region EXERCÍCIO - MATRIZES

        /*
         * Matriz é o nome dado arranjos bidimensionais.
         * 
         * Arranjo é uma estrutura de dados:
         * Homogênea (dados do mesmo tipo);
         * Ordenada (elementos acessados por meio de posições);
         * Alocada de uma vez só, em um bloco contíguo de memória.
         * 
        */

        /*
        double[,] myMatriz = new double[2,3];
        Console.WriteLine(myMatriz.Length); // --> Quantos elementos a matriz terá no total
        Console.WriteLine(myMatriz.Rank); // --> Quanto é a quantidade de linhas da primeira dimensão da matriz 
        Console.WriteLine(myMatriz.GetLength(0)); // --> A primeira dimensão da matriz (0) ela possui tamanho 2
        Console.WriteLine(myMatriz.GetLength(1)); // --> A segunda dimensão da matiz (1) ela possui tamanho 3
        */

        /*
        int n = int.Parse(Console.ReadLine());
        int[,] myMatriz = new int[n,n];

        for (int i = 0; i < n; i++) //Percorrendo as linhas
        {
            string[] values = Console.ReadLine().Split(' ');
            for (int j = 0; j < n; j++) //Percorrendo as colunas
            {
                myMatriz[i,j] = int.Parse(values[j]);
            }
        }

        Console.WriteLine("Diagonal principal: ");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(myMatriz[i,i] + " ");
        }

        int contador = 0;
        for (int i = 0; i < n; i++) 
        {            
            for (int j = 0; j < n; j++) //Percorrendo as colunas
            {
                if(myMatriz[i,j] < 0)
                {
                    contador++;
                }
            }
        }
        Console.Write($"Números negativo: {contador}");
        */

        #endregion
        #region EXERCÍCIO - SWITCH-CASE

        /*   
         * Estrutura opcional a vários if-else encadeados, quando a condição envolve o teste do valor de uma variável.
        */

        /*
        int x = int.Parse(Console.ReadLine());
        string dia;

        switch (x)
        {
            case 1:
                dia = "Segunda";
                break;
            case 2:
                dia = "Terça";
                break;
            case 3:
                dia = "Quarta";
                break;
            case 4:
                dia = "Quinta";
                break;
            case 5:
                dia = "Sexta";
                break;
            case 6:
                dia = "Sábado";
                break;
            case 7:
                dia = "Domingo";
                break;
            default:
                dia = "Dia não identificado";
                break;
        }
        Console.WriteLine($"Dia: {dia}");
        */
        #endregion
    }
}
