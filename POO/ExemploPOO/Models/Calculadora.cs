using ExemploPOO.Interfaces;

namespace ExemploPOO.Models
{
    public class Calculadora : iCalculadora     //ctrl + . para inserir outras opções
    {
        public int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }
        public int Somar(int num1, int num2, int num3)  //exemplo de polimorfismo em tempo de compilação
        {
            return num1 + num2 + num3;
        }

        public int Subtrair(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}