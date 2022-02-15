namespace Classes.Heranca
{
    public class Ponto3D : Ponto    //a classe Ponto3D é herdada da classe Ponto. Uma classe só pode ser herdada de apenas uma outra classe.
    {
        public int z;

        public Ponto3D(int x, int y, int z) : base(x,y)    //veja que os valores de x e y são herdados da classe mãe 
        {
            this.z = z;
            CalcularDistancia();
        }

        public static void Calcular()       //método pertencente à classe e não à instância, para evocá-lo, deve-se referenciar a classe antes
        {
            //Faz alguma ação
        }

        public override void CalcularDistancia3()
        {
            //Faz alguma coisa. Perceba que ele herda o método da classe mãe, porém, pode colocar outras ações no código e depois chamar as ações da classe mãe:
            base.CalcularDistancia3();
        }
    }
}