using ex02;
class MetodosEstaticos {
    public static int Somar(int x, int y) {
        return x + y;
    }
    public static int Multiplicar(int x, int y) {
        return x * y;
    }
    static public void Main(string[] args)
    {
        var result = MetodosEstaticos.Somar(3, 3);
        Console.WriteLine("A soma é igual a: {0}", result);

        Console.WriteLine(MetodosEstaticos.Multiplicar(3, 4));

        var calc = new MetodosEstaticos2();
        Console.WriteLine("A soma é igual a: {0}", calc.Somar(2, 5));

        Console.WriteLine(calc.Multiplicar(8, 6));

        static void Despedida(params string[] alunos) {
            foreach (var aluno in alunos) {
                Console.WriteLine("Tchau {0}, até a próxima aula", aluno);
            }
        }

        Despedida("João", "Thiago", "Antonio");

    }
}

