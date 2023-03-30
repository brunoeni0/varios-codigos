using static ex03.StructClasse;
class Enum {
    public enum Genero { Filme, Serie, Documentario };
    public class Filme {
        public string Nome;
        public Genero TipoVideo;
    }
    public static void Main() {
        int cod = (int)Genero.Serie;
        Console.WriteLine(cod);

        PontoS ponto = new PontoS { X = 5, Y = 3 };
        PontoS ponto2 = ponto; // Copiar através do valor;
        ponto.X = 3;

        Console.WriteLine("Ponto: {0}", ponto.X);
        Console.WriteLine("Ponto 2: {0}", ponto2.X);

        Pontoc ponto3 = new Pontoc { X = 6, Y = 9 };
        Pontoc ponto4 = ponto3;
        ponto3.X = 3;

        Console.WriteLine("Ponto 3 = {0}, Ponto 4 = {1}", ponto3.X, ponto4.X);

        int x = 5;
        AlterarRef(x);
        Console.WriteLine(x);

        int y = 8;
        AlterarOut(y);
        Console.WriteLine(y);

        AlterarRef2(ref x);
        Console.WriteLine(x);

        AlterarOut(y);
        Console.WriteLine(y);

        static double Multiplicar(double x = 3.4, double y = 3)
        {
            return x * y;
        }

        Console.WriteLine(Multiplicar());
    }
    public static void AlterarRef(int numero) {
        numero = numero + 500;
    }
    public static void AlterarOut(int numero) {
        numero = numero + 50;
    }
    public static void AlterarRef2(ref int numero) {
        numero = numero + 500;
    }
    public static void AlterarOut2(int numero) {
        numero = 0;
        numero = numero + 50;
    }
}
