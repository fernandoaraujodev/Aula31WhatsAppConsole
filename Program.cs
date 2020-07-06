using System;

namespace Aula31ProjetoWhatsappCSV
{
    class Program
    {
        static void Main(string[] args)
        {
            Agenda ag = new Agenda();

            Contato ct = new Contato("João de Deus","(11) 95416-4357");
            ct.Cadastrar(ct);
        }
    }
}
