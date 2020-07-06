using System.IO;

namespace Aula31ProjetoWhatsappCSV
{
    public class Agenda : IAgenda
    {
                
        public const string PATH = "Database/Contato.csv";

        public Agenda()
        {

            string pasta = PATH.Split('/')[0]; //Criando array com o arquivo Database

            if(!Directory.Exists(pasta))//Se o diretório não existe, crie o diretório
            {
                Directory.CreateDirectory(pasta);
            }
        

    }

        public void Cadastrar()
        {
            throw new System.NotImplementedException();
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