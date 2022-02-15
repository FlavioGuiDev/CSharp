using Classes.Heranca;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Ponto p1 = new Ponto(10,20);
            
            Ponto3D p2 = new Ponto3D(10,20,30);

            Ponto3D.Calcular();     //veja que como o método Calcular() é static, ele deve ser chamado referenciando-se à 
            //classe a qual pertence, pois um método estático pertence à classe, e não à instância.

        }
    }
}