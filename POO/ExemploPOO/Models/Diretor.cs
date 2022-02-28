namespace ExemploPOO.Models
{
    //public class Diretor : Professor     //observe que esta herança não é permitida, pois Professor é uma classe selada
     public class Diretor : Professor     
     {
        public override void Apresentar()        //indica que o método pode ser sobrescrito
        {
            Console.WriteLine($"Olá, sou um diretor.");
        }    
     }
}