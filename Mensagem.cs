namespace Aula31ProjetoWhatsappCSV
{
    public class Mensagem 
    {
        public Contato Destinatario {get;set;}
        public string Texto {get;set;}
        
        /// <summary>
        /// Enviar mensagem
        /// </summary>
        /// <param name="destinatario"> selecionamos o contato destinátario</param>
        /// <returns></returns>
        public string Enviar(Contato _destinatario){
            this.Destinatario = _destinatario;
            
            // Mensagem que será enviada
            return $"A mensagem {Texto} foi enviada para o {_destinatario}";
        }
    }
}