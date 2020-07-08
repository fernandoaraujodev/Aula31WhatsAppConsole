using System.Collections.Generic;

namespace Aula31ProjetoWhatsappCSV
{
    public interface IAgenda
    {
        void Cadastrar(Contato ct);

        void Remover(Contato ct);

        List<Contato> Listar();

    }
}