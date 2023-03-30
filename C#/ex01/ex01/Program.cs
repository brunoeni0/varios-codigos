using ex01;

void Somar(float x1,float x2) {
    float s = x1 + x2;
    Console.WriteLine("A soma de " + x1 + " + " + x2 + " = " + s);;
}


float Multiplicar(float x, float y) {
    return x * y;
}


Somar(5, 4);
Console.WriteLine(Multiplicar(3, 2));

Aluno aluno1 = new Aluno();
aluno1.Nome = "João";
aluno1.Idade = 13;
aluno1.Serie = 6;

Console.WriteLine($"O aluno {aluno1.Nome} tem {aluno1.Idade} anos e pertence ao {aluno1.Serie} ano");
Console.WriteLine(aluno1.Retorno());
aluno1.RetornoConsole();

var carro = new Carro("Celta", "Chevrolet", 1.0);
Console.WriteLine($"{carro.Nome} {carro.Marca} {carro.Potencia}");

carro.Nome = "Hilux";
carro.Marca = "Toyota";
carro.Potencia = 3.1;
Console.WriteLine($"{carro.Nome} {carro.Marca} {carro.Potencia}");
