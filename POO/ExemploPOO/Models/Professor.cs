namespace ExemploPOO.Models
{
//    public sealed class Professor : Pessoa      //exemplo de classe selada, não pode ter filhas, a classe diretor tenta herdar mas não consegue
    public class Professor : Pessoa      //exemplo de classe selada, não pode ter filhas
    {
        public double salario { get; set; }
        
        //public sealed override void Apresentar()        //indica que o método é selado, ou seja, não pode ser implementado por uma classe filha
        public override void Apresentar()        //indica que o método pode ser sobrescrito
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e sou um professor que ganha {salario} reais.");
        }
    }
}