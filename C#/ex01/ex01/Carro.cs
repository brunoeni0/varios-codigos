using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01 {
    public class Carro {
        public string Nome;
        public string Marca;
        public double Potencia;
        public Carro(string nome, string marca, double potencia) {
            this.Nome = nome;
            this.Marca = marca;
            this.Potencia = potencia;
        }
    }
}