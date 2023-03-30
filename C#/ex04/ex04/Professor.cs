using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex04 {
    public class Professor {
        protected readonly float salariomaximo;
        float salarioatual;
        public Professor(float salarioMaximo) {
            this.salariomaximo = salarioMaximo;
        }
        protected float ModificarSalario(float Modf) {
            float novoSalario = this.salarioatual + Modf;
            if (novoSalario < 0) {
                this.salarioatual = 0;
            }
            else if (novoSalario > salariomaximo) {
                this.salarioatual = this.salariomaximo;
            }
            else {
                this.salarioatual = novoSalario;
            }
            return this.salarioatual;
        }
        public float AumentarSalario() {
            return ModificarSalario(+500);
        }
        public float DiminuirSalario() {
            return ModificarSalario(-500);
        }
    }
    public class Prof : Professor {
        public Prof() : base(1400) { }
    }

    public class Mensagem {
        private String Texto;
        public void Exibir() {
            Console.WriteLine(this.Texto);
        }
        public String getTexto() {
            return this.Texto;
        } 
        public void setTexto(String txt) {
            this.Texto = txt;
        }
    }

    public abstract class Telefone {
        public abstract string Tipo();
    }
    public class Xiaomi : Telefone { 
        public override string Tipo() {
            return "Note 8 Pro";
        }
    }

    sealed class Escola {}
}

