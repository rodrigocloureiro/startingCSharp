using System;

public class Program
{
    public static void ExibeMenu()
    {
        Console.WriteLine("***** <-- CALCULADORA --> *****");
        Console.WriteLine("( + ) SOMA");
        Console.WriteLine("( - ) SUBTRAÇÃO");
        Console.WriteLine("( * ) MULTIPLICAÇÃO");
        Console.WriteLine("( / ) DIVISÃO");
        Console.WriteLine("( X ) SAIR");
        Console.WriteLine("*******************************");
        Console.WriteLine("Digite os números:");
    }

    public static void Calculo(decimal num1, decimal num2, string operacao)
    {
        decimal resultado = 0.0m;

        switch (operacao)
        {
            case "+":
                resultado = num1 + num2;
                break;
            case "-":
                resultado = num1 - num2;
                break;
            case "*":
                resultado = num1 * num2;
                break;
            case "/":
                resultado = num1 / num2;
                break;
        }

        if (resultado % 1 == 0) Console.WriteLine($"{num1} {operacao} {num2} = {resultado}");
        else Console.WriteLine($"{num1} {operacao} {num2} = {resultado:F2}");
    }

    public static void Main(String[] args)
    {
        try
        {
            decimal num1, num2;
            string operacao;

            while (true)
            {
                ExibeMenu();

                decimal.TryParse(Console.ReadLine(), out num1);
                decimal.TryParse(Console.ReadLine(), out num2);

                Console.WriteLine("Escolha uma opção:");
                operacao = Console.ReadLine().ToUpper();
                if (operacao.Equals("X")) break;

                Calculo(num1, num2, operacao);

                Console.ReadKey();
                Console.Clear();
            }

            Console.Clear();
            Console.WriteLine("Obrigado por usar esta calculadora.");
            Console.ReadKey();
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Não é possível dividir por zero! Tente novamente. Saindo em 3..2..1...");
            Console.ReadKey();
        }
    }
}
