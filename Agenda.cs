using System.Collections.Generic;
using System.IO;

namespace Aula31ProjetoWhatsappCSV
{
    public class Agenda : IAgenda
    {
                
        public const string PATH = "Database/Contato.csv";

        public Agenda()
        {

            //Criando arquivo Database
            string pasta = PATH.Split('/')[0]; //Criando array com o arquivo Database
            string csv = PATH.Split("/")[1];

            if(!Directory.Exists(pasta))//Se o diretório não existe, crie o diretório
            {
                Directory.CreateDirectory(pasta);
                File.Create(csv).Close();

                //Corrigir erro
                //Esta criando diretório e arquivo, mas o arquivo não é criado dentro do diretório 
            }
        }

        // Preparando como os dados serão armazenados no arquivo Database/Contato.csv
        public string PrepararLinhaCSV(Contato c){

            //Nome = João de Deus; Telefone = (11) 95416-4357
            return $" Nome = {c.Nome}; Telefone = {c.Telefone}";
        }

        public void Cadastrar(Contato ct)
        {
            var linha = new string [] {ct.PrepararLinhaCSV(ct)};
            File.AppendAllLines(PATH, linha);
        }

        public void Excluir()
        {
            throw new System.NotImplementedException();
        }

        public void Listar()
        {
            throw new System.NotImplementedException();
        }
    }
}