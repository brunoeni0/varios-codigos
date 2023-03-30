namespace OlaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("Olá, Mundo!");

            int x = 4;
            double y = 3.3;
            const double frequencia = 60;

            double area = x * y;

            Console.WriteLine("A área do quadrado é " + area);

            int x = 4;
            double x = y; // Conversão Implícita
            Console.WriteLine(y);

            double nota = 8.6;
            int notaconvertida = (int)nota;
            Console.WriteLine(notaconvertida);

            Console.Write("Digite qual é número de sua casa: ");
            string numeroCasa = Console.ReadLine();
            int numero = int.Parse(numeroCasa);
            Console.WriteLine("Numero de sua é casa: {0}", numero);

            numero = Convert.ToInt32(numeroCasa);

            Console.WriteLine(numero);

            double z = 20.232;
            Console.WriteLine(z.ToString("F1"));
            Console.WriteLine(z.ToString("C"));
            Console.WriteLine(z.ToString("P"));

            Console.Write("Qual é seu nome? ");
            String nome = Console.ReadLine();
            Console.Write("Quantos anos você tem? ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Seu nome é {0} e sua idade é de {1} anos", nome, idade);

            var i = 25;
            var salario = 1285.76;

            Console.WriteLine("Idade {0}, Salário {1}", i, salario);
        }
    }
}
