internal class Program
{
    private static void Main(string[]args)
    {
       
        double valor
        double resultado

        // pede para o usuário digitar o valor a ser calculado
        Console.WriteLine("qual o valor? ");
        valor = double.Parse(Console.ReadLine());

        // se o valor digitado for menor ou igual a 999, o imposto é de 2%
        if (valor <= 999)
        {
            Console.WriteLine("o imposto é 2%: ");

            // calcula o imposto a ser pago
            resultado = valor * 2 / 100;
            resultado = valor + resultado;

            Console.WriteLine(resultado);
        }

        // se o valor digitado for maior ou igual a 7000, o imposto é de 3%
        else if (valor >= 7000)
        {
            Console.WriteLine("o imposto é 3%: ");

            // calcula o imposto a ser pago
            resultado = valor * 3 / 100;
            resultado = valor + resultado;

            Console.WriteLine(resultado);
        }

        // se o valor digitado for maior ou igual a 3000 e menor ou igual a 6999, o imposto é de 2.8%
        else if (valor >= 3000 && valor <= 6999)
        {
            Console.WriteLine("o imposto deve ser de 2.8%: ");

            // calcula o imposto a ser pago
            resultado = valor * 2.8 / 100;
            resultado = valor + resultado;

            Console.WriteLine(resultado);
        }

        // se o valor digitado for maior ou igual a 1000 e menor ou igual a 2999, o imposto é de 2.5%
        else if (valor >= 1000 && valor <= 2999)
        {
            Console.WriteLine("o imposto deve ser de 2.5%: ");

            // calcula o imposto a ser pago
            resultado = valor * 2.5 / 100;
            resultado = valor + resultado;

            Console.WriteLine(resultado);
        }
    }
}
