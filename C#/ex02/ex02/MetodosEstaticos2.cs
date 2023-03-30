using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex02 {
    public class MetodosEstaticos2 {
        public int Somar(int x, int y) {
            return x + y;
        }
        public int Multiplicar(int x, int y) {
            return y * x;
        }
    }
    public class Carro {
        private string Marca;
        private string Nome;
        private double Potencia;
        public Carro(string marca, string nome, double potencia) {
            this.Marca = marca;
            this.Nome = nome;
            this.Potencia = potencia;
        }
        public string GetMarca() {
            return this.Marca;
        }
        public void SetMarca(string marca) {
            this.Marca = marca;
        }
        public string GetNome() {
            return this.Nome;
        }
        public void SetNome(string nome) {
            this.Nome = nome;
        }
        public double GetPotencia() {
            return this.Potencia;
        }
        public void SetPotencia(double potencia) {
            this.Potencia = potencia;
        }
    }
}

