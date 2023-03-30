using ex05;
Action apresentarConsole = () =>
{
    Console.WriteLine("Funções e Métodos");
};

apresentarConsole();

Func<int> sorteio = () =>
{
    Random random = new Random();
    return random.Next(1, 101);
};

Console.WriteLine(sorteio());

double a = 10;
double b = 30;

BinaryNumericOperation operacao = Calculadora.soma;

Console.WriteLine(operacao(a, b));

int[] numeros = new int[] { 4, 5, 7, 8 };

var operacao2 = numeros.Where(x => x % 2 == 0);

foreach (int x in operacao2) {
    Console.WriteLine(x);
}

double x1 = 3;

Console.WriteLine(x1.Soma(7));
Console.WriteLine(9.2.Soma(7));


public static class calculadoraExtensao
{
    public static double Soma(this double n1, double n2)
    {
        return n1 + n2;
    }
}
