namespace ExemploPOO.Models
{
    public class Aluno : Pessoa         //herda os atributos e métodos da classe pessoa;
    {
        public int Nota { get; set; }
        public override void Apresentar()        //indica que o método foi sobrescrito com base na classe Pessoa
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e sou aluno nota {Nota}.");
        }
    }
        

}