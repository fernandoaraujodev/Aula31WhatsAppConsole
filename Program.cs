using System;
using System.Collections.Generic;

namespace Aula31ProjetoWhatsappCSV
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciando objeto agenda
            Agenda ag = new Agenda();

            //instanciando objeto contato
            Contato ct = new Contato("Marcio Bispo","(11) 97159-2768");

            //Adicionando contato instanciado na agenda
            ct.Cadastrar(ct);

            // Excluindo o contato adicionada anteriormente
            //ag.Remover("Lucas Evangelista");

            List<Contato> Lista = ag.Listar();

            // Imprimindo a lista de contatos
            System.Console.WriteLine("Lista de Contatos");

            // Fazendo varredura 
            foreach(Contato contatos in Lista){
                Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine($"{contatos.Nome} - {contatos.Telefone}");
                Console.ResetColor();
            }

            //Mensagem msg = new Mensagem();
            //msg.Enviar(ct);

        }
    }
}    
