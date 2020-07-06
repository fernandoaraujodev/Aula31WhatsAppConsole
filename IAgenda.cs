using System.Collections.Generic;

namespace Aula31ProjetoWhatsappCSV
{
    public interface IAgenda
    {
        void Cadastrar(Contato ct);

        void Remover(string contato);

        List<Contato> Listar();

    }
}