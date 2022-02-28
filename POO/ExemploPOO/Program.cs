using ExemploPOO.Helper;
using ExemploPOO.Interfaces;
using ExemploPOO.Models;
namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            //trabalhando com arquivos:
            var caminho = "C:\\Git\\CSharp\\TrabalhandoComArquivos";    //observe o uso de duas barras entre as pastas
            // Uso da classe Path e método Combine para combinar o caminho com a pasta e subpasta especificadas:
            // var caminhoPathCombine = Path.Combine(caminho,"PastaTeste1","SubPastaTeste1");
            var caminhoPathCombine = Path.Combine(caminho,"PastaTeste1");
            var caminhoArquivo =  Path.Combine(caminho,"arquivoTeste-stream.txt");
            var caminhoArquivoTeste =  Path.Combine(caminho,"arquivoTeste.txt");
            var caminhoArquivoTesteCopia =  Path.Combine(caminho,"arquivoTeste-bkp.txt");
            var novocaminhoArquivo =  Path.Combine(caminho,"PastaTeste2", "arquivoTeste-stream.txt");
            var listaString =  new List<string>{"Linha 1", "Linha 2", "Linha 3"};   //usada pela stream
            var listaStringContinuacao =  new List<string>{"Linha 4", "Linha 5", "Linha 6"};   //usada pela stream
            
            
            FileHelper helper = new FileHelper();
            //helper.ListarDiretorios(caminho);
            // helper.ListarArquivosDiretorios(caminho);

            //a seguir, criamos uma pasta e uma subpasta
            // System.Console.WriteLine("Criando diretório: "+ caminhoPathCombine);
            // helper.CriarDiretorio(caminhoPathCombine);
            // helper.ApagarDiretorio(caminhoPathCombine,true);    //o true indica que é um delete recursivo
  
            //trabalhando com arquivo
            // helper.CriarArquivoTexto(caminhoArquivo,"Olá, teste de escrita em arquivo");

            //trabalhando com stream:
            // helper.CriarArquivoTextoStream(caminhoArquivo, listaString);
            // helper.AdicionarTextoStream(caminhoArquivo,listaStringContinuacao);//adiciona novas linhas ao arquivo

            //ler um arquivo stream:
            // helper.LerArquivoStream(caminhoArquivo);

            //mover localização de um arquivo:
            // helper.MoverArquivo(caminhoArquivo, novocaminhoArquivo, false);

            //fazer uma cópia de um arquivo sem sobrescrever:
            // helper.CopiarArquivo(caminhoArquivoTeste,caminhoArquivoTesteCopia,false);
            
            //deletar um arquivo
            helper.DeletarArquivo(caminhoArquivoTesteCopia);
            
            //iCalculadora calc = new iCalculadora(); //observe que há um erro: não é possível instanciar uma interface
            // iCalculadora calc = new Calculadora();  //uma interface recebe um objeto calculadora, o qual implementa os métodos da interface
            // System.Console.WriteLine(calc.Somar(10,20));    //observe que a interface calc está sendo implementada pela classe Calculadora

            // Computador comp = new Computador();
            // System.Console.WriteLine(comp.ToString());  //como saída, haverá apenas o nome da classe,
            // // pois não há nenhum método implementado na classe Computador, porém, ela é uma classe 
            //derivada da classe Object, como todas as classes existentes      

            //Conta conta = new Conta();   observe que não é possível criar uma instância de uma classe abstrata 

            // Corrente c = new Corrente();
            // c.Creditar(100);
            // c.ExibirSaldo();

            //uso do polimorfismo em tempo de compilação:
            //   Calculadora calc = new Calculadora();
            //  System.Console.WriteLine("Resultado da primeira soma: " + calc.Somar(10,10));
            //  System.Console.WriteLine("Resultado da segunda soma: " + calc.Somar(10, 10, 10));
            //uso de herança:
            // Aluno a1 = new Aluno(); //Aluno herda todos os atributos e métodos da classe Pessoa
            // a1.Nome = "Bob";
            // a1.Idade = 20;
            // a1.Nota = 10;
            // a1.Apresentar();

            // Professor p1 = new Professor(); //Aluno herda todos os atributos e métodos da classe Pessoa
            // p1.Nome = "Albert";
            // p1.Idade = 20;
            // p1.salario = 10000;
            // p1.Apresentar();


            //Uso de métodos e atributos:
            //Valores válidos
            //  Retangulo r = new Retangulo();
            //  r.DefinirMedidas(30,30);    //uso do encapsulamento para acessar atributos privados da classe
            //  System.Console.WriteLine($"Área: {r.ObterArea()}");

            // //Valores inválidos
            //  Retangulo r2 = new Retangulo();
            //  r2.DefinirMedidas(0,0);    //uso do encapsulamento para acessar atributos privados da classe
            //  System.Console.WriteLine($"Área: {r2.ObterArea()}");

            //Uso de um classe:
            // Pessoa p1 = new Pessoa();
            // p1.Nome = "Bob";
            // p1.Idade = 20;
            // p1.Apresentar();
        }
    }
}