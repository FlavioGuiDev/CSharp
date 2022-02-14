//Métodos da Pilha:
namespace EstruturaDoPrograma
{
    class Program
    {
        static void Main()
        {
            var s = new Pilha();
            s.Empilha(1);
            s.Empilha(2);
            s.Empilha(3);
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
        }
    }
}
