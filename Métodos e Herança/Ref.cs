namespace Classes.Metodos
{
    public class Ref
    {
        static void Inverter(ref int x, ref int y)  //passagem de parâmetros por referência
        {
            int temp = x;
            x = y;
            y = temp;
        }

        public static void Inverter()
        {
            int i = 1, j = 2;
            Inverter(ref i, ref j);     //como os parâmetros são por referência, o que acontecer com x e y vai interferir nos valores de i e j
            System.Console.WriteLine($"{i}{j}");
        }
    }
}