namespace Aula31ProjetoWhatsappCSV
{
    public class Contato : Agenda
    {
        public string Nome {get;set;}
        public string Telefone {get;set;}

        //Gerando método construtor para o objeto Contato
        public Contato(string _nome, string _telefone){
            this.Nome = _nome;
            this.Telefone = _telefone;
        }
    }
}