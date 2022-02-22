using ExemploPOO.Models;
namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            //uso de herança:
            Aluno a1 = new Aluno(); //Aluno herda todos os atributos e métodos da classe Pessoa
            a1.Nome = "Bob";
            a1.Idade = 20;
            a1.Apresentar();

            Professor p1 = new Professor(); //Aluno herda todos os atributos e métodos da classe Pessoa
            p1.Nome = "Bob";
            p1.Idade = 20;
            p1.Apresentar();


            //Uso de métodos e atributos:
            // //Valores válidos
            // Retangulo r = new Retangulo();
            // r.DefinirMedidas(30,30);    //uso do encapsulamento para acessar atributos privados da classe
            // System.Console.WriteLine($"Área: {r.ObterArea()}");

            // //Valores inválidos
            // Retangulo r2 = new Retangulo();
            // r2.DefinirMedidas(0,0);    //uso do encapsulamento para acessar atributos privados da classe
            // System.Console.WriteLine($"Área: {r2.ObterArea()}");

            //Uso de um classe:
            // Pessoa p1 = new Pessoa();
            // p1.Nome = "Bob";
            // p1.Idade = 20;
            // p1.Apresentar();
        }
    }
}