using EstudosOOP;
using EstudosOOP.Classes;
using EstudosOOP.Entidades;
using EstudosOOP.Entidades.Enums;
using EstudosOOP.Entidades.Exceções;
using EstudosOOP.Servicos;
using EstudosOOP.Static_Classes;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using EstudosOOP.Extensoes;
using System.Linq;

class Program
{
    static async Task Main(string[] args)
    {
        #region INSTANCIANDO CLASSES              

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
        #region CLASSES ESTÁTICAS  

        /*
         * Classes estáticas são classes que não precisam ser instanciadas para serem usadas.
         * 
         * Exemplo: classe Math().
         * 
        Console.WriteLine("Qual é a cotação do dólar?");
        double cotacao = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Quantos dólares você vai comprar? ");
        double dolaresComprados = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine();
        Console.WriteLine($"Valor a ser pago em reais: {ConversorDeMoeda.ConverterParaReal(dolaresComprados, cotacao).ToString("F2", CultureInfo.InvariantCulture)}");
        */

        #endregion
        #region ENTENDENDO OS CONSTRUTORES 

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
        #region VETORES        

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
        #region PARAMS

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
        #region MODIFICADORES DE PARÂMETROS REF e OUT

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
        #region BOXING E UNBOXING

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
        #region LAÇO FOR EACH

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
        #region LISTAS

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
        #region MATRIZES

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
        #region SWITCH-CASE

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
        #region EXPRESSÃO CONDICIONAL TERNÁRIA

        /*
        * Estrutura opcional ao if-else quando se deseja decidir um valor com base em uma condição
        * 
        * Sintaxe: (condição) ? valor_se_verdadeiro : valor_se_falso
        * 
        * Exemplos: 
        * (2 > 4) ? 50 : 80 --> 80 
        * (10 != 3) ? "Maria" : "Alex" --> "Maria"
        */

        /*
        double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;
        Console.WriteLine(desconto);
        */
        #endregion
        #region DATETIME

        /*
        DateTime d1 = DateTime.Now;
        DateTime d2 = DateTime.Parse("01/04/2000");
        DateTime d3 = DateTime.ParseExact("2000-04-01", "yyyy-MM-dd", CultureInfo.InvariantCulture);      
        

        Console.WriteLine(d1);
        Console.WriteLine(d2);
        Console.WriteLine(d3);
        */

        #endregion
        #region ENUMERAÇÕES
        /*
         * 
         * 
         * 
         * 
         * 
         *
         */

        //Pedido pedido = new Pedido
        //{
        //    Id = 1080,
        //    Momento = DateTime.Now,
        //    Status = PedidoStatus.PagamentoPendente //Classe de tipo enumerado
        //};

        //Console.WriteLine(pedido);

        #endregion
        #region HERANÇA

        /*
         * É um tipo de associação que permite que uma classe herde dados e comportamentos de outra.
         * 
         * Sintaxe:
         * : (estende)
         * base (referência para a superclasse)
         * 
         * Exemplo: Classe Conta é herdada para a classe ContaEmpresarial
         * 
         * -> Obs: A classe Conta é a superclasse da classe ContaEmpresarial
         * -> (superclasse ou classe pai) = Conta / (subclasse ou classe filha) = ContaEmpresarial
        */

        //ContaEmpresarial conta = new(122, "Daniel",122.50, 200.00);
        //Console.WriteLine(conta);

        #endregion
        #region UPCASTING e DOWNCASTING

        /*
         * -> Upcasting: É um casting da subclasse para a superclasse.
         * Uso comum: polimorfismo.
         * 
         * -> Downcasting: É um casting da superclasse para a subclasse.
         * Palavra as
         * Palavra is
         * Uso comum: métodos que recebem parâmetro genéricos (ex: Equals).
         *
         */

        //Conta conta = new Conta(1001, "Daniel", 0.0);
        //ContaEmpresarial contaEmpresarial = new ContaEmpresarial(1002, "Gouveia", 0.0, 500.0);

        // UPCASTING
        //Conta conta1 = contaEmpresarial;        
        //Conta conta2 = new ContaEmpresarial(1003, "Neves", 0.0, 150.0);
        //Conta conta3 = new SalvamentoConta(1004, "Bento", 0.0, 0.01);
        // O compilador aceita esse casting porque a classe ContaEmpresarial É UM(a) subclasse da superclasse Conta.

        // DOWNCASTING
        //ContaEmpresarial contaEmpresarial1 = conta2; //Erro
        //ContaEmpresarial contaEmpresarial2 = (ContaEmpresarial)conta2; //Correto, utilizando o casting

        #endregion
        #region SOBREPOSIÇÃO OU SOBRESCRITA (VIRTUAL, OVERRIDE, BASE)

        /*
         * É a implementação de um método de uma superclasse na subclasse.
         * 
         * Para que um método comum (não abstrato) possa ser sobreposto, deve ser incluído nele o prefixo "virtual".
         * Ao sobrescrever um método, devemos incluir nele o prefixo override.
         * 
         */

        //Conta minhaConta = new Conta(156, "Daniel", 500.00);
        //Conta minhaContaS = new SalvamentoConta(157, "Daniel Ltda", 500.0, 150.0);

        //minhaConta.Saque(10.0);
        //minhaContaS.Saque(10.0); // O método Saque foi sobrescrito na subclasse SalvamentoConta

        //Console.WriteLine(minhaConta.Saldo); //485
        //Console.WriteLine(minhaContaS.Saldo); //490

        #endregion
        #region CLASSES E MÉTODOS SELADOS

        /*
         * Palavra chave: sealed
         * 
         * -> na Classe: Evita que a classe seja herdada
         * Obs: ainda é possível extender a funcionalidade de uma classe selada usando "extension methods".
         * 
         * -> no Método: Evita que um método sobreposto possa ser sobreposto novamente
         * Obs: só pode ser aplicado a métodos sobrepostos.
         * 
         * -> Qual necessidade de selar classes ou métodos?
         * - Segurança: Dependendo das regras de negócio, às vezes é desejável garantir que uma classe não seja herdada
         * ou que um método não seja sobreposto. Geralmente convém selar métodos sobrepostos, pois sobreposições múltiplas
         * podem ser uma porta de entrada para inconsistências.
         * 
         * - Performance: Atributos e tipo de uma classe selada são analisados de forma mais rápida em tempo de execução.
         * Exemplo clássico: string
        */

        //Exemplo com Classe:
        //namespace EstudosOOP.Entidades
        //{
        //internal sealed class SalvamentoConta : Conta
        //{

        #endregion
        #region POLIMORFISMO

        /*
         * -> Em POO, polimorfismo é um recurso que permite que variáveis de um mesmo tipo mais genérico possam apontar
         * para objetos de tipos específicos diferentes, tendo assim comportamentos diferentes conforme cada tipo específico.
         * 
         * -> Importante:
         * - A associação do tipo específico com o tipo genérico é feita em tempo de execução (upcasting).
         * 
         * - O compilador não sabe para qual tipo específico a chamada do método Saque está sendo feita
         * (ele só sabe que são duas variáveis tipo Conta):
         * 
         * Conta conta2 = new ContaEmpresarial(1003, "Neves", 0.0, 150.0);
         * Conta conta3 = new SalvamentoConta(1004, "Bento", 0.0, 0.01);
         * 
         */

        #endregion
        #region CLASSES ABSTRATAS

        /*
         * São classes que não podem ser instanciadas
         * 
         * É uma forma de garantir herença total: somente subclasses não abstratas podem ser instanciadas, mas nunca a superclasse abstrata.
         * 
         * -> Observação: Por que utilizar classes abstratas?
         * - Reuso
         * - Polimorfismo: A superclasse classe genérica nos permite tratar de forma fácil e uniforme todos os tipos de conta,
         * inclusive com polimorfismo se for o caso.
        */

        //Conta minhaConta = new Conta(156, "Daniel", 500.00); // Erro, superclasse é abstrata
        //Conta minhaContaS = new SalvamentoConta(157, "Daniel Ltda", 500.0, 150.0);

        //minhaConta.Saque(10.0);
        //minhaContaS.Saque(10.0); 

        //Console.WriteLine(minhaConta.Saldo); 
        //Console.WriteLine(minhaContaS.Saldo);

        #endregion
        #region MÉTODOS ABSTRATOS

        /*
         * São métodos que não possuem implementação.
         * 
         * Métodos precisam ser abstratos quando a classe é genérica demais para contar sua implementação.
         * 
         * Se uma classe possuir pelo menos um método abstrato, então esta classe também é abstrata.
         * 
         * -> Observação: No exemplo abaixo a superclasse Figura é abstrata e seu método Area() também,
         * suas subclasses (RetanguloFig e Circulo) devem sobreescrever o seu método Area() para poder utilizá-los.
        */

        //List<Figura> listFigura = new();

        //Console.Write("Entre com a quantidade de figuras: ");
        //int n = int.Parse(Console.ReadLine());

        //for (int i = 1; i <= n; i++)
        //{
        //    Console.WriteLine($"#{i} Figura:");
        //    Console.Write("Retângulo ou Círculo (r/c)? ");
        //    char resposta = Char.Parse(Console.ReadLine());
        //    Console.Write("Cor (Preto/Azul/Vermelho): ");
        //    Cor cor = Enum.Parse<Cor>(Console.ReadLine());
        //    if (resposta == 'r') {
        //        Console.Write("Largura: ");
        //        double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        //        Console.Write("Altura: ");
        //        double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        //        listFigura.Add(new RetanguloFig(largura, altura, cor));
        //    }
        //    else
        //    {
        //        Console.Write("Raio: ");
        //        double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        //        listFigura.Add(new Circulo(raio, cor));
        //    }            
        //}

        //Console.WriteLine();
        //Console.WriteLine("Área da Figura: ");
        //foreach (Figura figura in listFigura)
        //{            
        //    Console.WriteLine(figura.Area().ToString("F2", CultureInfo.InvariantCulture));
        //}
        #endregion
        #region EXCEÇÕES

        /*
         * Uma exceção é qualquer condição de erro ou comportamento inesperado encontrado por um programa em execução.
         * 
         * No .NET, uma exceção é um objeto herdado da classe System.Exception.
         * Quando lançada, uma exceção é propagada na pilha de chamadas de métodos em execução, até que seja capturada (tratada) ou
         * o programa seja encerrado. 
         * 
         * -> Por que existem exceções?
         * O modelo de tratamento de exceções permite que erros sejam tratados de forma consistente e flexível, usando boas práticas.
         * 
         * -> Vantagens
         * - Delega a lógica do erro para a classe/método responsável por conhecer as regras que podem ocasionar o erro.
         * - Trata de forma organizada (inclusive hierárquica) exceções de tipos diferentes.
         * - A exceção pode carregar dados quaisquer.
         * 
         * C:\Users\danie\OneDrive\Área de Trabalho\DANIEL\PROGRAMAÇÃO\C#\EstudosOOP\EstudosOOP\Apoio\Imagens\excecoes.jpg
         */

        #region TRY-CATCH

        /*
         * -> Bloco try
         * - Contém o código que representa a execução normal do trecho de código que pode acarretar em uma exceção.
         * 
         * -> Bloco catch
         * - Contém o código a ser executado caso uma exceção ocorra.
         * - Deve ser especificado o tipo da exceção a ser tratada (upcasting é permitido).
         * Obs: É possível utilizar quantos blocos catch necessários.
        */

        //try
        //{
        //    int n1 = int.Parse(Console.ReadLine()); // 10
        //    int n2 = int.Parse(Console.ReadLine()); // 0
        //    int resultado = n1 / n2; // Erro
        //}
        //catch (DivideByZeroException) // Exceção expecífica, tratamento é feito da forma que preferir.
        //{
        //    Console.WriteLine("A divisão por 0 não é permitida."); // Tratamento
        //}
        //catch (FormatException e) // Exceção expecífica, tratamento é feito da forma que preferir.
        //{
        //    Console.WriteLine("Formato de entrada incorreto! Utilize números inteiros para realizar a divisão"); // Tratamento
        //}
        //catch(Exception e) // Classe Genérica. Com ela qualquer exceção será tratada.
        //{
        //    Console.WriteLine($"Erro! {e.Message}");
        //}

        #endregion

        #region FINALLY

        /*
         * É um bloco que contém código a ser executado independentemente de ter ocorrido ou não uma execeção.
         * 
         * Exemplo clássico: fechar um arquivo ou conexão de banco de dados ao final do processamento.
         */

        //FileStream? fs = null; //O FileStream é uma funcionalidade do C# que abre arquivos e só pode ser fechado manualmente.
        //try
        //{
        //    fs = new FileStream(@"C:\Users\danie\OneDrive\Área de Trabalho\DANIEL\
        //        PROGRAMAÇÃO\C#\EstudosOOP\EstudosOOP\Apoio\Anotacoes\lorem-ipsum.txt",
        //        FileMode.Open);
        //    StreamReader sr = new StreamReader(fs);
        //    string? linha = sr.ReadLine();
        //    Console.WriteLine(linha);
        //}
        //catch (FileNotFoundException e)
        //{
        //    Console.WriteLine(e.Message);
        //}
        //catch (Exception)
        //{
        //    throw;
        //}
        //finally
        //{
        //    if (fs != null) { fs.Close(); } // Fechando o arquivo independente se ocorreu erro ou não.
        //}

        #endregion

        #region EXCEÇÕES PERSONALIZADAS

        /*
         * Fazer um programa para ler os dados de uma reserva de hotel (núemro do quarto, data de entrada e saída) e mostrar os dados da
         * reserva, inclusive sua duração em dias. Em seguida, ler novas datas de entrada e saída, atualizar a reserva, e mostrar novamente
         * a reserva com os dados atualizados. O programa não deve aceitar dados inválidos para a reserva, conforme as seguintes regras:
         * 
         * - Alterações de reserva só podem ocorrer para datas futuras
         * - A data de saída deve ser maior que a data de entrada.
         */

        /*
         * Os tratamentos de erros foram criados dentro da classe Reservas. E uma classe para as exceções também foi criada
         * herdando a classe ApplicationException, com ela podemos criar nossas exceções expecíficas.
         */

        //try
        //{
        //    Console.Write("Número do quarto: ");
        //    int numeroQ = int.Parse(Console.ReadLine());
        //    Console.Write("Check-in data (dia/mês/ano): ");
        //    DateTime checkIn = DateTime.Parse(Console.ReadLine());
        //    Console.Write("Check-out data (dia/mês/ano): ");
        //    DateTime checkOut = DateTime.Parse(Console.ReadLine());

        //    Reservas objReserva = new Reservas(numeroQ, checkIn, checkOut);
        //    Console.WriteLine($"Reserva: {objReserva}");

        //    Console.WriteLine();

        //    Console.WriteLine("Entre com a data para atualizar sua reserva:");
        //    Console.Write("Check-in data (dia/mês/ano): ");
        //    checkIn = DateTime.Parse(Console.ReadLine());
        //    Console.Write("Check-out data (dia/mês/ano): ");
        //    checkOut = DateTime.Parse(Console.ReadLine());
        //    objReserva.AtualizarDatas(checkIn, checkOut);
        //    Console.WriteLine($"Reserva: {objReserva}");
        //}
        //catch (DominioException e) //Exceção expecífica pela minha classe, utilizando ApplicationException
        //{
        //    Console.WriteLine($"Error: {e.Message}");
        //}
        //catch(FormatException e) //Exceção expecífica pela classe próprio do C#, a SystemException
        //{
        //    Console.WriteLine($"Erro no formato de entrada: {e.Message}");
        //}
        //catch (Exception) // Exceção geral
        //{
        //    throw;
        //}

        #endregion

        #endregion
        #region ARQUIVOS

        #region File, FileInfo
        /*
         * Realiza operações com arquivos (create, copy, delete, move, open, etc.) e ajuda na criação de objetos FileStream.
         * 
         * - File: static members (simples, mas realiza verificação de segurança para cada operação)
         * - FileInfo: instance members
         */

        //string fileTxt = @"C:\Users\danie\OneDrive\Área de Trabalho\DANIEL\PROGRAMAÇÃO\C#\EstudosOOP\EstudosOOP\Apoio\Anotacoes\lorem-ipsum.txt";
        //string arquivoDestino = @"C:\Users\danie\OneDrive\Área de Trabalho\DANIEL\PROGRAMAÇÃO\C#\EstudosOOP\EstudosOOP\Apoio\Anotacoes\lorem-ipsum2.txt";

        //try
        //{
        //    FileInfo fileInfo = new FileInfo(fileTxt);
        //    fileInfo.CopyTo(arquivoDestino);
        //    string[] linhasArquivo = File.ReadAllLines(fileTxt);
        //    foreach (string linhas in linhasArquivo)
        //    {
        //        Console.WriteLine(linhas);
        //    }
        //}
        //catch (IOException ex)
        //{
        //    Console.WriteLine("Um erro ocorreu!");
        //    Console.WriteLine(ex.Message);
        //}

        #endregion
        #region FileStream
        /*
         * Disponibiliza uma stream associada a um arquivo, permitindo operações de leitura e escrita. 
         * Suporte a dados binários.
         * 
         * -> Instanciação:
         * - Vários construtores
         * - File / FileInfo
         */

        #region StreamReader
        /*
         * É uma stream capaz de ler caracteres a partir de uma stream binária (ex: FileStream).
         * Suporte a dados no formato de texto.
         * 
         * -> Instanciação:
         * - Vários construtores
         * - File / FileInfo
         */
        #endregion

        // Exemplos de como se ler um arquivo com stream's.

        // Exemplo 1 (mais verboso):
        //string path = @"C:\Users\danie\OneDrive\Área de Trabalho\DANIEL\PROGRAMAÇÃO\C#\EstudosOOP\EstudosOOP\Apoio\Anotacoes\lorem-ipsum2.txt";
        //FileStream fileStream = null;
        //StreamReader streamReader = null;

        //try
        //{
        //    fileStream = new FileStream(path, FileMode.Open);
        //    streamReader = new StreamReader(fileStream);
        //    string linha = streamReader.ReadLine();
        //    Console.WriteLine(linha);
        //}
        //catch (IOException ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}
        //finally
        //{
        //    if (streamReader != null) streamReader.Close();
        //    if (fileStream != null) fileStream.Close();
        //}
        //

        // Exemplo 2 (menos verboso):

        //string path = @"C:\Users\danie\OneDrive\Área de Trabalho\DANIEL\PROGRAMAÇÃO\C#\EstudosOOP\EstudosOOP\Apoio\Anotacoes\lorem-ipsum2.txt";
        //StreamReader sr = new StreamReader(path);
        //try
        //{
        //    while (!sr.EndOfStream)
        //    {
        //        string linha = sr.ReadLine();
        //        Console.WriteLine(linha);
        //    }
        //}
        //catch (IOException ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}
        //finally
        //{
        //    if (sr != null) sr.Close();
        //}

        //

        #endregion

        #region Bloco USING
        /*
         * Sintaxe simplificada que garante que os objetos IDisposable serão fechados.
         * 
         * Objetos IDisposable NÃO são gerenciados pelo CLR. Eles precisam ser manualmente fechados.
         * Exemplos: Font, FileStream, StreamReader, StreamWriter.
         * 
         */

        //string path = @"C:\Users\danie\OneDrive\Área de Trabalho\DANIEL\PROGRAMAÇÃO\C#\EstudosOOP\EstudosOOP\Apoio\Anotacoes\lorem-ipsum2.txt";
        //try
        //{
        //    // Utilizando o using fará com que quando a aplicação terminar de utilizar a classe StreamReader,
        //    // ela será fechada, sem a necessidade de bloco finally.
        //    using (StreamReader sr = new StreamReader(path)) 
        //    {
        //        while (!sr.EndOfStream)
        //        {
        //            string line = sr.ReadLine();
        //            Console.WriteLine(line);
        //        }
        //    }
        //}
        //catch (IOException ex)
        //{
        //    Console.WriteLine(ex.Message);            
        //}
        #endregion

        #region StreamWriter

        /*
         * É uma stream capaz de escrever caracteres a partir de uma stream binária (ex: FileStream).
         * Suporte a dados no formato de texto.
         * 
         * -> Instanciação:
         * - Vários construtores
         * - FIle / FileInfo
         * -- CreateText(path)
         * -- AppendText(String)
         */

        //string arquivoOrigem = @"C:\Users\danie\OneDrive\Área de Trabalho\DANIEL\PROGRAMAÇÃO\C#\EstudosOOP\EstudosOOP\Apoio\Anotacoes\lorem-ipsum.txt";
        //string arqDestino = @"C:\Users\danie\OneDrive\Área de Trabalho\DANIEL\PROGRAMAÇÃO\C#\EstudosOOP\EstudosOOP\Apoio\Anotacoes\lorem-ipsum3.txt";

        //try
        //{
        //    string[] linhas = File.ReadAllLines(arquivoOrigem);
        //    using (StreamWriter sw = File.AppendText(arqDestino))
        //    {
        //        foreach (string linha in linhas)
        //        {
        //            sw.WriteLine(linha.ToUpper());
        //        }
        //    }
        //}
        //catch (IOException ex)
        //{
        //    Console.WriteLine(ex.Message);            
        //}

        #endregion
        #region Directory, DirectoryInfo

        /*
         * Operações com pastas (create, enumerate, get files, etc.).
         * 
         * -> Directory
         * - membros estáticos (simples, mas elas fazem uma checagem de segurança antes de efetuar cada operação)
         * 
         * -> DirectoryInfo
         * - instanciação de membros
         */


        //string path = @"C:\Users\danie\OneDrive\Área de Trabalho\DANIEL\PROGRAMAÇÃO\C#\EstudosOOP\EstudosOOP\Apoio";
        //try
        //{
        //    // Listar as pastas a partir de uma pasta informada:
        //    IEnumerable<string> pasta = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
        //    Console.WriteLine("PASTAS:");
        //    foreach (string pastaString in pasta)
        //    {
        //        Console.WriteLine(pastaString);
        //    }

        //    Console.WriteLine();

        //    // Listar arquivos a partir de uma pasta informada:
        //    IEnumerable<string> arquivos = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
        //    Console.WriteLine("ARQUIVOS:");
        //    foreach (string arquivo in arquivos)
        //    {
        //        Console.WriteLine(arquivo);
        //    }

        //    // Criar uma pasta
        //    Directory.CreateDirectory(path + @"\novapasta");

        //}
        //catch (IOException ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}

        #endregion
        #region Path

        /*
         * Realiza operações com strings que contém informações de arquivos ou pastas.
         */

        //string path = @"C:\Users\danie\OneDrive\Área de Trabalho\DANIEL\PROGRAMAÇÃO\C#\EstudosOOP\EstudosOOP\Apoio\Anotacoes\lorem-ipsum.txt";

        //Console.WriteLine($"GetDirectoryName: {Path.GetDirectoryName(path)}"); // Obtém apenas o nome da pasta, sem o arquivo.
        //Console.WriteLine($"DirectorySeparatorChar: {Path.DirectorySeparatorChar}"); // Obtém o caractere de separação.
        //Console.WriteLine($"PathSeparator: {Path.PathSeparator}"); // Obtém o caractere que separa entre path's diferentes.
        //Console.WriteLine($"GetFileName: {Path.GetFileName(path)}"); // Obtém o nome do arquivo passado.
        //Console.WriteLine($"GetFileNameWithoutExtension: {Path.GetFileNameWithoutExtension(path)}"); // Obtém o nome do arquivo passado sem sua extensão.
        //Console.WriteLine($"GetExtension: {Path.GetExtension(path)}"); // Obtém apenas a extensão do arquivo passado.
        //Console.WriteLine($"GetFullPath: {Path.GetFullPath(path)}"); // Obtém todo o caminho do arquivo.
        //Console.WriteLine($"GetTempPath: {Path.GetTempPath()}"); // Obtém a pasta temporária do sistema

        #endregion

        #endregion
        #region INTERFACES com DI (Injeção de Dependência)

        /*
         * Interface é um tipo que define um conjunto de operações que uma classe (ou struct) deve implementar.
         * 
         * A interface estabelece um contrato que a classe (ou struct) deve cumprir.
         * 
         * -> Pra quê interfaces?
         * - Para criar sistemas com baixo acoplamento e flexíveis. 
         */

        //Console.WriteLine("Entre com os dados do aluguel");
        //Console.Write("Modelo do carro: ");
        //string modeloCarro = Console.ReadLine();
        //Console.Write("Entrada (dd/MM/yyyy hh:mm): ");
        //DateTime dataEntrada = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
        //Console.Write("Saída (dd/MM/yyyy hh:mm): ");
        //DateTime dataSaida = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

        //Console.Write("Preço por hora: ");
        //double hora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        //Console.Write("Preço por dia: ");
        //double dia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        //ITaxaServico taxa;

        //AluguelCarros aluguelCarros = new(dataEntrada, dataSaida, new Veiculo(modeloCarro));
        //ServicoAluguel servicoAluguel = new ServicoAluguel(hora, dia, new ServicoTributarioBrasil());
        //// A classe concreta ServicoTributarioBrasil é um tipo de ITaxaServico por meio do contrato que foi feito.

        //servicoAluguel.ProcessarFatura(aluguelCarros);

        //Console.WriteLine("FATURA: ");
        //Console.WriteLine(aluguelCarros.Fatura);
        //Console.ReadKey();

        #endregion
        #region INJEÇÃO DE DEPENDÊNCIA e INVERSÃO DE CONTROLE

        /*
         * -> Inversão de Controle: Padrão de desenvolvimento que consiste em retirar da classe
         * a responsabilidade de instanciar suas dependências.
         * 
         * -> Injeção de dependência: É uma forma de realizar a inversão de controle: um componente externo instancia a dependência, que é então
         * injetada no objeto "pai". Pode ser implementada de várias formas: 
         * - Construtor
         * - Objeto de instanciação (builder/factory)
         * - Container/framework
         * 
         * No exemplo do tópico de INTERFACES foi feito uma injeção de dependência por meio de construtores.
         * A classe ServicoTributarioBrasil foi injetada na interface ITaxaServico pelo construtor da classe ServicoAluguel, 
         * fazendo com que não seja necessário mudar o código caso uma nova taxa de serviço for usada.
         * 
         */

        #endregion
        #region HERANÇA x INTERFACE

        #endregion
        #region GENERICS

        /*
         * Generics permitem que classes, interfaces e métodos possam ser parametrizados por tipo. Seus benefícios são:
         * - Reuso
         * - Type safety
         * - Perfomance
         * 
         * Uso comum: coleções
         * 
         * Exemplos: 
         * List<string> list = new List<string>();
         * list.Add("Maria");
         * string name = list[0];
         */

        //ServicoImpressao<int> servicoImpressao = new ServicoImpressao<int>();

        //Console.Write("Quantos valores você vai digitar? ");
        //int n = int.Parse(Console.ReadLine());

        //for (int i = 0; i < n; i++)
        //{
        //    int x = int.Parse(Console.ReadLine());
        //    servicoImpressao.AdicionarValor(x);
        //}

        //servicoImpressao.Imprimir();
        //Console.WriteLine($"Primeiro: {servicoImpressao.Primeiro()}");        

        #endregion
        #region GetHashCode E EQUALS

        /*
         * São operações da classe Object utilizadas para comparar se um objeto é igual ao outro.
         * - Equals: lento, resposta 100%
         * - GetHashCode: rápido, porém resposta positiva não é 100%
         * 
         * Os tipos pré-definidos já possuem implementação para essas operações. Classes e structs personalizados precisam sobrepô-las.          
         */

        /* -> Equals
         * Método que compara se o objeto é igual a outro, retornando true ou false.
         *
         * Exemplo:
         * string a = "Maria";
         * string a1 = "Maria";
         * string b = "Alex";
         * Console.WriteLine(a.Equals(b)); //false
         * Console.WriteLine(a.Equals(a1)); //true
         */

        /*
         * -> GetHashCode
         * Método que retorna um número inteiro representando um código gerado a partir das informações do objeto.
         * 
         * Exemplo:
         */
        //string c = "Maria";
        //string c1 = "Maria";
        //string d = "Alex";
        //Console.WriteLine(c.GetHashCode()); // ~ número inteiro ~
        //Console.WriteLine(d.GetHashCode()); // ~ número inteiro ~
        //Console.WriteLine(c1.GetHashCode()); // ~ número inteiro ~

        /*
         * -> Regra de ouro do GetHashCode
         * Se o código de dois objetos forem diferentes, então os dois objetos são diferentes
         * Se o código de dois objetos forem iguais, muito provavelmente os objetos são iguais (pode haver colisão)
         */

        //Cliente a = new Cliente { Nome = "Daniel", Email = "daniel.nevesb@hotmail.com" };
        //Cliente b = new Cliente { Nome = "Fulano", Email = "daniel.nevesb@hotmail.com" };

        //Console.WriteLine(a.Equals(b)); // True -> Porque os objetos são iguals no tipo de contéudo
        //Console.WriteLine(a == b); // False -> Porque os objetos são diferentes no tipo de referência
        //Console.WriteLine(a.GetHashCode());
        //Console.WriteLine(b.GetHashCode());

        #endregion
        #region Conjuntos HashSet<T> e SortedSet<T>

        /*
         * Representam um conjunto de elementos (similar ao da Álgebra)
         * - Não admitem repetições
         * - Elementos não possuem posições
         * - Acesso, inserçãoe e remoção de elementos são rápidos
         * - Oferece operações eficientes de conjunto: inserção, união, diferença.
         */

        /*
         * -> HashSet
         * - Armazenamento em tabela hash
         * - Extremamente rápido: inserção, remoção e busca O(1)
         * - A ordem dos elementos não é garantida
         * 
         * -> SortedSet
         * - Armazenamento em árvore
         * - Rápido: inserção, remoção e busca O(log(n))
         * - Os elementos são armazenados ordenadamente conforme implementação IComparer<T>
         */

        //SortedSet<int> a = new SortedSet<int>() {0,2,4,5,6,8,10 };
        //SortedSet<int> b = new SortedSet<int>() {5,6,7,8,9,10 };

        //// Método União
        //SortedSet<int> c = new SortedSet<int>(a);
        //c.UnionWith(b);
        //ImprimirColecao(c);

        //// Método Intersecção
        //SortedSet<int> d = new SortedSet<int>(a);
        //d.IntersectWith(b);
        //ImprimirColecao(d);

        //// Método Diferente
        //SortedSet<int> e = new SortedSet<int>(a);
        //e.ExceptWith(b);
        //ImprimirColecao(e);

        #endregion
        #region Dictionary<TKey, TValue> e SortedDictionary

        /*
         * O Dictionary é uma coleção de pares chave/valor
         * - Não admite repetições do objeto chave
         * - Os elementos são indexados pelo objeto chave (não possuem posição)
         * - Acesso, inserção e remoção de elementos são rápidos
         * 
         * Uso comum: cookies, local storage, qualquer modelo chave-valor
         */

        /*
         * Dictionary x SortedDictionary
         * 
         * -> Dictionary
         * - Armazenamento em tabela hash
         * - Extramamente rápido: inserção, remoção e busca O(1)
         * - A ordem dos elementos não é garantida
         * 
         * dictionary[key] -> acessa o elemento pela chave informada
         * 
         * -> SortedDictionary
         * - Armazenamento em árvore
         * - Rápido: inserção, remoção e busca O(log(n))
         * - Os elementos são armazenados ordenadamente conforme implementação do IComparer<T>
         */

        /*
         * -> Principais métodos da coleção
         * 
         * - Add(key, value) - adiciona o elemento (exceção em caso de repetição)
         * - Clear() - esvazia a coleção
         * - Count - quantidade de elementos
         * - ContainsKey(key) - verifica se a dada chave existe
         * - ContainsValue(value) - verifica se o dado valor existe
         * - RemoveKey(key) - remove um elemento pela chave
         */

        #endregion
        #region Extensions Methods

        /*
         * Os Extensions Methods são métodos que estendem a funcionalidade de um tipo,
         * sem precisar alterar o código fonte do mesmo e nem herdar.
         * 
         * Como fazer um?
         * -> Criar uma classes estática
         * -> Na classe, criar um método estático
         * -> O primeiro parâmetro do método deverá ter o prefixo this, seguido da tipagem e sua declaração.
         * Esta será uma referência para o próprio objeto.
         */

        //Exemplo 1:
        //DateTime dt = new DateTime(2023, 3, 20, 7, 30, 45);
        //Console.WriteLine(dt.ElapsedTime());        

        //Exemplo 2:
        //String s1 = "Hello, World!";
        //Console.WriteLine(s1.Cut(10));
        //Console.ReadKey();
        #endregion
        #region Delegates

        /*
         * Um delegate é um elemento da linguagem C# que permite que você faça referência a um método.
         * 
         * 
         * 
         */

        #endregion
        #region LINQ

        //Categoria c1 = new Categoria() { Id = 1, Nome = "Ferramentas", Tier = 2 };
        //Categoria c2 = new Categoria() { Id = 2, Nome = "Computadores", Tier = 1 };
        //Categoria c3 = new Categoria() { Id = 3, Nome = "Eletrônicos", Tier = 1 };

        //List<Produto> produtos = new List<Produto>() {
        //    new Produto(){Id=1,Nome="Computador",Preco = 1100.0, Categoria = c2 },
        //    new Produto(){Id=2,Nome="Martelo",Preco = 90.0, Categoria = c1 },
        //    new Produto(){Id=3,Nome="TV",Preco=1700.0,Categoria = c3},
        //    new Produto(){Id=4,Nome="Notebook",Preco=1300.0,Categoria = c2},
        //    new Produto(){Id=5,Nome="Serra",Preco=80.0,Categoria = c1},
        //    new Produto(){Id=6,Nome="Tablet",Preco=700.0,Categoria = c2},
        //    new Produto(){Id=7,Nome="Camera",Preco=700.0,Categoria = c3},
        //    new Produto(){Id=8,Nome="Impressora",Preco=350.0,Categoria = c3},
        //    new Produto(){Id=9,Nome="MacBook",Preco=1800.0,Categoria = c2},
        //    new Produto(){Id=10,Nome="Som",Preco=700.0,Categoria = c3},
        //    new Produto(){Id=11,Nome="Ferramenta de Nível",Preco=70.0,Categoria = c1},
        //};

        //Console.WriteLine("-----------------------------");
        //Console.WriteLine("TIER 1 E PREÇO MENOR QUE 900");
        //Console.WriteLine("-----------------------------");
        ////var R1 = produtos.Where(x => x.Categoria.Tier == 1 && x.Preco <= 900).Select(x => x);
        //var R1 = from p in produtos where p.Categoria.Tier == 1 && p.Preco <= 900 select p;
        //await ImprimirColecao(R1);

        //Console.WriteLine("-----------------------------");
        //Console.WriteLine("PRODUTOS DA CATEGORIA FERRAMENTAS");
        //Console.WriteLine("-----------------------------");
        ////var R2 = produtos.Where(x => x.Categoria.Id == 1).Select(x => x.Nome);
        //var R2 = from p in produtos where p.Categoria.Tier == 1 select p.Nome;
        //await ImprimirColecao(R2);

        //Console.WriteLine("-----------------------------");
        //Console.WriteLine("PRODUTOS COMEÇADOS COM A LETRA C E OBJETOS ANÔNIMOS");
        //Console.WriteLine("-----------------------------");
        ////var R3 = produtos
        ////.Where(x => x.Nome[0] == 'C') //Uma string é um array de char
        ////.Select(x => new {x.Nome, x.Preco, CategoriaNome = x.Categoria.Nome });
        //var R3 = from p in produtos where p.Nome[0] == 'C' select new { p.Nome, p.Preco, CategoriaNome = p.Categoria.Nome };
        //await ImprimirColecao(R3);

        //Console.WriteLine("-----------------------------");
        //Console.WriteLine("PRODUTOS ORDENADOS POR PREÇO E NOME COM OBJETOS ANÔNIMOS");
        //Console.WriteLine("-----------------------------");
        ////var R4 = produtos
        ////.Where(x => x.Categoria.Tier == 1)
        ////.OrderBy(x => x.Preco).ThenBy(x => x.Nome)
        ////.Select(x => new { x.Nome, x.Preco, CategoriaNome = x.Categoria.Nome });
        //var R4 = from p in produtos where p.Categoria.Tier == 1 orderby p.Nome orderby p.Preco select p;
        //await ImprimirColecao(R4);

        ////var R5 = produtos.FirstOrDefault(); //O método FirstOrDefault traz o primeiro item ou caso não exista retorna nulo
        //var R5 = (from p in produtos select p).FirstOrDefault();
        //Console.WriteLine($"Primeiro produto: {R5}");

        //var R6 = produtos.Where(x => x.Id == 3).SingleOrDefault(); 
        ////Esse método retorna a tipagem do objeto utilizado e não um Enumerable.
        ////Ele pode ser utilizado apenas se o resultado do Where for único, se retornar mais de um uma exceção será lançada
        //Console.WriteLine(R6);

        //// Ferramentas LINQ de agregação
        //Console.WriteLine("-----------------------------");
        //Console.WriteLine("FERRAMENTAS LINQ DE AGREGAÇÃO (Operações Matemáticas)");
        //Console.WriteLine("-----------------------------");
        //var R7 = produtos.Max(x => x.Preco);
        //Console.WriteLine($"Maior preço: {R7}");
        //var R8 = produtos.Min(x => x.Preco);
        //Console.WriteLine($"Menor preço: {R8}");
        //var R9 = produtos.Where(x => x.Categoria.Id == 1).Sum(p => p.Preco);
        //Console.WriteLine($"Soma dos preços dos produtos de categoria 1: {R9}");
        //var R10 = produtos.Where(x => x.Categoria.Id == 1).Average(p => p.Preco);
        //Console.WriteLine($"Média dos preços dos produtos de categoria 1: {R10}");
        ////O próximo exemplo mostrará como podemos tratar caso o retorno do Where seja vazio
        ////Obs: Categoria de ID 5 não existe
        //var R11 = produtos.Where(x => x.Categoria.Id == 5).Select(x => x.Preco).DefaultIfEmpty(0.0).Average();
        //var R12 = produtos.Where(x => x.Categoria.Id == 5).Select(x => x.Preco).DefaultIfEmpty(0.0).Sum();
        //Console.WriteLine($"Soma dos preços dos produtos de categoria 5: {R11}");
        //Console.WriteLine($"Média dos preços dos produtos de categoria 5: {R12}");

        //Console.WriteLine();
        //Console.WriteLine("-> AGGREGATE");
        ////Com o Aggregate podemos montar nossa operação matemática
        //var R13 = produtos.Where(p => p.Categoria.Id == 1).Select(x => x.Preco).Aggregate((x, y) => x + y);
        //Console.WriteLine($"Soma dos preços dos produtos de categoria 1 com Aggregate: {R13}");
        //var R14 = produtos.Where(p => p.Categoria.Id == 1).Select(x => x.Preco).Aggregate(0.0, (x, y) => x + y);
        //Console.WriteLine($"Soma dos preços dos produtos de categoria 5 com Aggregate: {R14}");

        //Console.WriteLine();
        //Console.WriteLine("-> GROUPBY");
        ////var R15 = produtos.GroupBy(p => p.Categoria);
        //var R15 = from p in produtos group p by p.Categoria;
        //foreach (var grupo in R15)
        //{
        //    Console.WriteLine($"Categoria: {grupo.Key.Nome}");
        //    foreach (Produto p in grupo)
        //    {
        //        Console.WriteLine(p);
        //    }
        //    Console.WriteLine();
        //}

        //Console.ReadKey();

        #endregion
    }
    static async Task ImprimirColecao<T>(IEnumerable<T> colecao)
    {
        try
        {
            foreach (T item in colecao)
            {
                Console.WriteLine(item + " ");
                await Task.Delay(1000);
            }
            Console.WriteLine();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}
