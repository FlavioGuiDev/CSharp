namespace ExemploPOO.Helper
{
    public class FileHelper
    {
        public void ListarDiretorios(string caminho)        
        {
            //trazendo todos os diretorios e subdiretorios a partir de 'caminho'; 
            var retornoCaminho = Directory.GetDirectories(caminho,"*",SearchOption.AllDirectories);
            foreach(var retorno in retornoCaminho)
            {
                System.Console.WriteLine(retorno);
            }
        }
        public void ListarArquivosDiretorios(string caminho)
        {
            //listando todos os arquivos de todas as pastas, de modo recursivo;o asterisco indica que se deseja trazer td
            var retornoArquivos = Directory.GetFiles(caminho,"*",SearchOption.AllDirectories);
            foreach(var retorno in retornoArquivos)
            {
                System.Console.WriteLine(retorno);
            }
            // //listando somente os arquivos *.txt de todas as pastas, de modo recursivo
            var retornoArquivos1 = Directory.GetFiles(caminho,"*2.txt",SearchOption.AllDirectories);
            foreach(var retorno in retornoArquivos1)
            {
                System.Console.WriteLine(retorno);
            }
        }
        public void CriarDiretorio(string caminho)
        {
            var retorno = Directory.CreateDirectory(caminho);     //retorna as informações do diretório recém-criado
            System.Console.WriteLine(retorno.FullName);     //imprime o nome completo do diretório
        }
        public void ApagarDiretorio(string caminho, bool apagarArquivos)
        {
            Directory.Delete(caminho,apagarArquivos); //apaga os arquivos de modo recursivo, o método delete não manda para a lixeira, ele apaga de vez    
        }

        public void CriarArquivoTexto(string caminho, string conteudo)  //para arquivos pequenos
        {
            if(!File.Exists(caminho))       //se o arquivo não existir...
                File.WriteAllText(caminho,conteudo);    //o arquivo é criado
        }
        //Usando stream para criar arquivos. Qdo um arquivo é gde, é uma opção interessante para não estourar a memória,
        //pois a stream escreve no arquivo por partes. Ex: qdo se precisa escrever 1 milhão de linhas.
        public void CriarArquivoTextoStream(string caminho, List<string> conteudo)  //uso de lista com uma coleção de strings
        {
            //qdo se cria uma stream, ela é colocada na memória e preparada para ser escrita
            //qdo terminar o arquivo, a stream não pode ficar aberta, devendo ser liberada para uso por outro processo
            //isso será garantido pelo using:
            using(var stream = File.CreateText(caminho))   //createText retorna uma stream para exclusivamente escrever arquivo
            {
                foreach (var linha in conteudo)
                {
                    stream.WriteLine(linha);    //o conteúdo é escrito na stream e esta escreve 'em partes' no arquivo
                }
            }
        }
        public void AdicionarTexto(string caminho, string conteudo)
        {
            File.AppendAllText(caminho, conteudo);

        }
        public void AdicionarTextoStream(string caminho, List<string> conteudo)  //uso de lista com uma coleção de strings
        {
            //qdo se cria uma stream, ela é colocada na memória e preparada para ser escrita
            //qdo terminar o arquivo, a stream não pode ficar aberta, devendo ser liberada para uso por outro processo
            //isso será garantido pelo using:
            using(var stream = File.AppendText(caminho))   //createText retorna uma stream para exclusivamente escrever arquivo
            {
                foreach (var linha in conteudo)
                {
                    stream.WriteLine(linha);    //o conteúdo é escrito na stream e esta escreve 'em partes' no arquivo
                }
            }
        }
        public void LerArquivo(string caminho)
        {
            var conteudo = File.ReadAllLines(caminho);
            foreach (var linha in conteudo)
            {
                System.Console.WriteLine(linha);
            }
        }
        public void LerArquivoStream(string caminho)
        {
            string linha = string.Empty;
            using(var stream = File.OpenText(caminho))
            {
                while((linha = stream.ReadLine()) != null)
                {
                    System.Console.WriteLine(linha);
                }
            }
        }

        //mover localização do arquivo:
        public void MoverArquivo(string caminho, string novoCaminho)
        {
            File.Move(caminho, novoCaminho);
        }

        public void CopiarArquivo(string caminho, string novoCaminho, bool sobrescrever)    //o 3º parâmetro é opcional, se for omitido, o padrão é não permitir a criação de um arquivo com o mesmo nome
        {
            File.Copy(caminho, novoCaminho, sobrescrever);
        }
        public void DeletarArquivo(string caminho)
        {
            File.Delete(caminho);
        }
    }
}