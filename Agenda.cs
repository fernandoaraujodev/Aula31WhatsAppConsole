using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Aula31ProjetoWhatsappCSV
{
    public class Agenda : IAgenda
    {
        public const string PATH = "Database/Contato.csv";

        public Agenda()
        {

            //Criando diretório pasta Database
            string pasta = PATH.Split('/')[0]; //Criando array com o arquivo Database

            if(!Directory.Exists(pasta))//Se o diretório não existe, crie o diretório
            {
                Directory.CreateDirectory(pasta); 
            }

            //Criando arquivo dentro do diretório Database
            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }

        /// <summary>
        /// Preparando como os dados serão armazenados no arquivo Database/Contato.csv
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public string PrepararLinhaCSV(Contato c){

            //Nome = João de Deus; Telefone = (11) 95416-4357
            return $" Nome = {c.Nome}; Telefone = {c.Telefone}";
        }
        
        /// <summary>
        /// Inserir novos contatos na agenda
        /// </summary>
        /// <param name="ct">novo contato</param>
        public void Cadastrar(Contato ct)
        {
            var linha = new string [] {ct.PrepararLinhaCSV(ct)};
            File.AppendAllLines(PATH, linha);
        }


        //---- fim cadastro -----


        /// <summary>
        /// Remover contato da agenda indicando parametro
        /// </summary>
        /// <param name="contato">contato que será excluido</param>
        public void Remover(Contato ct)
        {
            List<string> Contatos = new List<string>();
            using(StreamReader contacts = new StreamReader(PATH))
            {
                string linha;
                while((linha = contacts.ReadLine()) != null)
                {
                    Contatos.Add(linha);
                }
            }

            // Remover o que o contato indicado contem
            Contatos.RemoveAll(c => c.Contains(ct.Nome));

            //Reescrever nosso CSV com nossa nova lista
            ReescreverCSV(Contatos);
        }

        /// <summary>
        /// Metodo de auxilio para remoção e reescrever contatos
        /// </summary>
        /// <param name="ctts"></param>
        private void ReescreverCSV(List<string> ctts)
        {
            using(StreamWriter saida = new StreamWriter(PATH))
            {
                foreach(string cts in ctts)
                {
                    saida.Write(cts + "\n");
                }
         
            }
        }


        //---- fim remoção de contatos ----

        public List<Contato> Listar()
        {   
            //Lista de retorno
            List<Contato> Contatos = new List<Contato>();

            // Nesse array de strings, leia e armazene no array, todo o conteúdo inserido em PATH
            string [] linhas = File.ReadAllLines(PATH); 

            foreach (string linha in linhas)
            {
                //Primeiro tratamento de dados, quebramos o bloco com ";"
                string [] dados = linha.Split(";");

                //   0             1      
                //Nome = {c.Nome}; Número = {c.Telefone}
                Contato contato = new Contato(SepararDados(dados[0]) , SepararDados(dados[1]));

                //Adicionamos à leitura o contato após o tratamento em splits
                Contatos.Add(contato);
            }
            Contatos = Contatos.OrderBy(c => c.Nome).ToList();
            return Contatos ;
        }

        /// <summary>
        /// Metodo de auxilio para quebrar o bloco novamente em uma nova Split
        /// </summary>
        /// <param name="coluna"></param>
        /// <returns></returns>
        private string SepararDados(string coluna){
            //   0        1 
            // Contato = João de Deus
            return coluna.Split("=")[1]; 
        }

        //---- fim listar contatos ----
    }
}