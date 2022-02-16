namespace Classes.Heranca
{
    public class Ponto
    {
        public int x, y;
        
        private int distancia;  //variável só é acessada dentro da classe
        
        public Ponto(int x, int y)
        {
            this.x = x;  //este this se refere ao x declarado na linha 5, é o x da classe
            this.y = y;
        }

        protected void CalcularDistancia()  //os herdeiros desta classe têm acesso a este método
        {
            CalcularDistancia2();       //como CalcularDistancia2 é um método privado, ele é acessível neste ponto da classe
        }
        
        private void CalcularDistancia2()  //os herdeiros desta classe não têm acesso a este método
        {
            //Faz alguma ação
        }

        public virtual CalcularDistancia3()  //este método pode ser sobrescrito na classe filha (alterado)
        {
            int i = 0;
            //Faz alguma ação
        }
    }
}