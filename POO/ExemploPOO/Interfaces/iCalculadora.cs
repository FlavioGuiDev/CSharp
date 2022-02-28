namespace ExemploPOO.Interfaces
{
    public interface iCalculadora
    {
         int Somar(int num1, int num2);     //observe que não existe um modificador de acesso no início do método (private, public, protected) pois por padrão eles são públicos nas interfaces
         int Subtrair(int num1, int num2);
         int Multiplicar(int num1, int num2);
         int Dividir(int num1, int num2)    //é possível implementar um método na própria interface, passando a ser opcional sua implementação nas classes que a utilizam
         {
             return num1 / num2;
         }
    }
}