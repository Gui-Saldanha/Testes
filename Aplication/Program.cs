public class Program
{
    static void Main(string[] agrs)
    {
        Initial();
    }

    public static void Initial()
    {
        string test = string.Empty;

        Console.WriteLine("----------------- Seja bem vindo! -----------------");
        Console.WriteLine("                  Escolha um dos testes abaixo para fazer:");
        Console.WriteLine("                  Teste 1 - FIZZ BUZZ");
        Console.WriteLine("                  Teste 2 - NÚMEROS ROMANOS");
        Console.Write("\n                  Escolho o teste: ");

        test = Console.ReadLine();

        ChooseTest(test);
    }

    public static void ChooseOption()
    {
        string option = string.Empty;

        Console.WriteLine("\n\n----------------- Escolha uma das opções seguintes para continuar ou sair -----------------");
        Console.WriteLine("                  Opção 1 - Voltar");
        Console.WriteLine("                  Opção 2 - Sair");
        Console.Write("\n                  Escolho a opção: ");

        option = Console.ReadLine();

        Console.WriteLine("\n\n\n\n");

        if (option.Equals("1"))
            Initial();
        else if (option.Equals("2"))
            Environment.Exit(-1);
    }

    public static void ChooseTest(string test)
    {
        if (test.Equals("1"))
            FizzBuzz();
        else if (test.Equals("2"))
            NumbersRomans();
    }

    public static void FizzBuzz()
    {
        Function.Function function = new Function.Function();

        int total = 0;

        Console.WriteLine("\n\n----------------- Bem vindo ao teste FIZZ BUZZ -----------------");
        Console.Write("\n                  Digite um número: ");

        total = int.Parse(Console.ReadLine());

        for (var n = 1; n <= total; n++)
        {
            Console.WriteLine("\n----------------- Verificação para N = " + n + " -----------------");

            foreach (var row in function.FizzBuzz(n))
            {
                Console.WriteLine("                  " + row);
            }
        }

        ChooseOption();
    }

    public static void NumbersRomans()
    {
        Function.Function function = new Function.Function();

        string numberRoman = string.Empty;

        Console.WriteLine("\n\n----------------- Bem vindo ao teste NÚMEROS ROMANOS -----------------");
        Console.Write("\n                  Digite um número romano: ");
        numberRoman = Console.ReadLine();

        string result = function.NumbersRomansToInt(numberRoman).ToString();

        Console.WriteLine("\n----------------- Resultado do número romano " + numberRoman + " em inteiro " + result);

        ChooseOption();
    }
}