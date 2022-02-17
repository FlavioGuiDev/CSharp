using System;
namespace Revisao
{
    class Program
    {
        static void Main(string [] args)
        {
            Aluno[] alunos = new Aluno[5];  //o array terá 5 posições
            var indiceAluno = 0; 
            string opcaoUsuario = obterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":   //adicionar aluno
                        Console.WriteLine("Informe o nome do aluno.");
                        //a seguir, uma referência por tipo, qdo se usa o var, o Csharp a tipifica com o valor que será preenchido
                        var aluno = new Aluno();  //instancia o objeto aluno
                        aluno.Nome = Console.ReadLine();    
                        Console.WriteLine("Informe a nota do aluno.");                        
                        //var nota = decimal.Parse(Console.ReadLine());      //decimal.parse converte a string para decimal
                        if(decimal.TryParse(Console.ReadLine(),out decimal nota))   //a variavel nota já está sendo declarada
                        {
                            aluno.Nota = nota;
                        }
                        else
                        {
                            throw new ArgumentException("Valor da nota deve ser decimal.");
                        }

                        alunos[indiceAluno] = aluno;
                        indiceAluno++;
                        break;
                    case "2":   //listar alunos
                        foreach(var a in alunos)
                        {
                            if(!string.IsNullOrEmpty(a.Nome))      //se o nome do aluno não for nulo nem vazio...
                                Console.WriteLine($"ALUNO : {a.Nome} - NOTA: {a.Nota}");
                        }
                       break;
                    case "3":   //calcular média geral
                        decimal notaTotal = 0;
                        var nrAlunos = 0;
                        for(int i = 0; i < alunos.Length;i++)
                        {
                            if(!string.IsNullOrEmpty(alunos[i].Nome))
                            {
                                notaTotal = notaTotal + alunos[i].Nota;
                                nrAlunos++;
                            }     
                        }

                        var mediaGeral = notaTotal / nrAlunos;
                        Conceito conceitoGeral;
                        if (mediaGeral < 2)
                        {
                            conceitoGeral = Conceito.E;
                        }
                        else if(mediaGeral < 4)
                        {
                            conceitoGeral = Conceito.D;
                        }
                        else if(mediaGeral < 6)
                        {
                            conceitoGeral = Conceito.C;
                        }
                        else if(mediaGeral < 8)
                        {
                            conceitoGeral = Conceito.B;
                        }
                        else if(mediaGeral < 10)
                        {
                            conceitoGeral = Conceito.A;
                        }
                        else
                        {
                            Console.WriteLine("Não foi possível calcular o conceito");
                            return;
                        } 
                        var x = conceitoGeral;
                        Console.WriteLine($"MÉDIA GERAL: {mediaGeral} - CONCEITO {conceitoGeral}");                        
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = obterOpcaoUsuario();
            }
        }

        private static string obterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada");
            Console.WriteLine("1 - Insira um novo aluno.");
            Console.WriteLine("2 - Listar aluno.");
            Console.WriteLine("3 - Calcular média geral.");
            Console.WriteLine("X - Sair.");
            Console.WriteLine();
            //agora, para utilizar o readLine no Terminal integrado do Visual Code, altere o
            //arquivo launch.json na propriedade Configurations/console coloque integratedTerminal, 
            //caso contrário, haverá uma exceção na execução do código, no momento de imprimir os alunos
            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}