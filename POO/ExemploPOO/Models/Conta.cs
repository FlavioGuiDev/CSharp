namespace ExemploPOO.Models
{
    public abstract class Conta     //exemplo de classe abstrata, não pode ser instanciada
    {
        protected double saldo;
        public abstract void Creditar(double valor);    //método abstrato, não pode ser implementado na classe abstrata, deverá obrigatoriamente ser implementado pelas classes herdeiras
        public void ExibirSaldo()   //método não abstrato, permite implementação na classe
        {
            System.Console.WriteLine("Seu saldo é: " + saldo);  
        }

    }
}