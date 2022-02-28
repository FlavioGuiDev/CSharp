namespace ExemploPOO.Models
{
    public class Pessoa
    {
        public string Nome{get;set;}
        public int Idade{get;set;}
        public virtual void Apresentar()        //indica que o método pode ser sobrescrito
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
        }    
    }
}