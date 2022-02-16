// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
namespace Instrucoes
{
    class Program
    {
        static void Declaracoes()   //declarações de variáveis
        {
            int a;              //declara sem valor inicial
            int b = 2, c = 3;   //declara com valor inicial
            const int d = 4;    //declara um valor constante
            a = 1;      
            Console.WriteLine(a + b + c + d);   //escreve na tela a soma das 4 variáveis
            //Declaração de arrays:
            int[] meuVetor = new int[10];   //vetor
            int[] outroVetor = new int[] {1,2,3};   //array criado e já inicializado
            int[] novoVetor = {1,2,3};      //outra forma de criar e inicializar um array
            int[,] minhaMatriz = new int[10,5];     //matriz de duas dimensões
            int[,,] minhaMatrizTridimensional = new int[10,5,7];     //matriz de três dimensões
        }
        //uso do if:
        static void InstrucaoIf(string[] argumentos)    //declara um método estático com um parâmetro do tipo string
        {
            if(argumentos.Length == 0)
            {
                Console.WriteLine("Nenhum argumento");
            }
            else if(argumentos.Length == 1)
            {
                Console.WriteLine("Um argumento");
            }
            else        //abaixo um exemplo de interpolação de strings (concatenação de uma string com o conteúdo de uma variável)
                Console.WriteLine($"{argumentos.Length} argumentos");   //exibe na tela a msg com a qtde de argumentos
        }
        //uso do switch:
        static void InstrucaoSwitch(string[] argumentos)    //declara um método estático com um parâmetro do tipo string
        {
            int numeroDeArgumentos = argumentos.Length;
            switch(numeroDeArgumentos)
            {
                case 0:
                    Console.WriteLine("Nenhum argumento");
                    break;
                case 1:
                    Console.WriteLine("Um argumento");
                    break;
                default:
                    Console.WriteLine($"{argumentos.Length} argumentos");   //exibe na tela a msg com a qtde de argumentos
                    break;
            }
        }
        //uso do while:
        static void InstrucaoWhile(string[] argumentos) 
        {
            int i = 0;
            while(i < argumentos.Length)
            {
                Console.WriteLine(argumentos[i]);
                i++;
            }
        }
        //uso do Do (o código é executado ao menos uma vez):
        static void InstrucaoDo(string[] argumentos) 
        {
            string texto;
            do
            {
                texto = Console.ReadLine();     //aguarda digitação do usuário
                Console.WriteLine(texto);
            }
            while(!string.IsNullOrEmpty(texto));    
        }

        //uso do For:
        static void InstrucaoFor(string[] argumentos)
        {
            for(int i = 0;i < argumentos.Length;i++)
            {
                Console.WriteLine(argumentos[i]);
            }
        }

        //uso do ForEach:
        static void InstrucaoForEach(string[] argumentos)
        {
            foreach(string s in argumentos)   //cada item de argumentos é armazenado em s
            {
                Console.WriteLine(s);
            }
        }
        //Uso do break:
        static void InstrucaoBreak(string[] argumentos)
        {
            while(true)
            {
                string s = Console.ReadLine();
                if(string.IsNullOrEmpty(s))
                    break;
                Console.WriteLine(s);
            }

        }
        
        //Uso do Continue:
        static void InstrucaoContinue(string[] argumentos)
        {
            for(int i = 0;i < argumentos.Length;i++)
            {
                if(argumentos[i].StartsWith("/"))   //se o valor do argumento começar com / ele pula esse argumento
                    continue;       //ele não vai para a próxima linha
                Console.WriteLine(argumentos[i]);
            }           
        }
        
        //Uso do Return:
        static void InstrucaoReturn(string[] argumentos)
        {
            int Somar(int a, int b)       //um exemplo de método aninhado (um método dentro de outro)
            {
                return a + b;
            }
            Console.WriteLine(Somar(1,2));
            Console.WriteLine(Somar(11,12));
            Console.WriteLine(Somar(110,112));
            return;     //mesmo que o método não retorna nada, neste ponto, o método é encerrado
        }

        //Uso do Try/Catch/Finally/Throw:
        static void InstrucoesTryCatchFinallyThrow(string[] argumentos)
        {
            double Dividir(double x, double y)
            {
                if(y == 0)
                    throw new DivideByZeroException();  //throw(lançar) uma exceção de divisão por zero
                return x/y;
            }
            try
            {
                if(argumentos.Length != 2)
                {
                    throw new InvalidOperationException("Informe 2 números");   //lança uma msg de exceção
                }
                double x = double.Parse(argumentos[0]);     //converte uma string para double
                double y = double.Parse(argumentos[1]);
                Console.WriteLine(Dividir(x,y));
            }
            catch(InvalidOperationException e)      //caso a exceção seja do tipo InvalidOperation...
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e)      //se não caiu no tipo de exceção acima, ele entra nessa:
            {
                Console.WriteLine($"Erro genérico: {e.Message}");
            }
            finally     //é executado entrando ou não no catch
            {
                Console.WriteLine("Até breve!");
            }
        }
        
        /*Uso do Using. Em operações não gerenciáveis, os objetos que não são mais utilizados pelo código
        não são coletados pelo Garbage Collection, ele só coleta objetos gerenciáveis. No exemplo abaixo, 
        a operação IO não é gerenciavel, assim, lança-se essa forma de utilizá-lo, o Using:*/
        static void InstrucaoUsing(string[] argumentos)
        {
            using(System.IO.TextWriter w = System.IO.File.CreateText("teste.txt"))
            {
                w.WriteLine("Line 1");
                w.WriteLine("Line 2");
                w.WriteLine("Line 3");
            }
            //após escrever as três linhas acima, e finalizar o using, automaticamente o w será eliminado
            //da memória 
        }

        //Agora, vamos comparar o mesmo código escrito em uma classe e em uma struct:
        public static void Main()
        {
            Ponto[] pontos = new Ponto[100];    //construtor
            for(int i = 0; i < 100; i++)
                pontos[i] = new Ponto(i, i);
        }

        public struct Ponto
        {
            public int x, y;
            public Ponto(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
    }
}