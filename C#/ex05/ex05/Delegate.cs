using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex05
{
    delegate double BinaryNumericOperation(double n1, double n2);
    class Calculadora { 
        public static double Max(double X, double Y) { 
            if (X > Y) {
                return X;
            } else {
                return Y;
            }
        }
        public static double soma(double X, double Y) {
            return X + Y;
        }
    }
}
