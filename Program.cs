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
            Contato ct1 = new Contato("Marcio Bispo","(11) 97159-2768");
            Contato ct2 = new Contato("João de Deus","(11) 95416-4357");
            Contato ct3 = new Contato("Lucas Evangelista","(11) 97896-2431");

            // Adicionando contato instanciado na agenda
            ct1.Cadastrar(ct1);
            ct1.Cadastrar(ct2);
            ct1.Cadastrar(ct3);

            // Excluindo o contato adicionada anteriormente
            ag.Remover(ct3);

            //List<Contato> Lista = ag.Listar();
            //Enxugando codigo passando a lista ja dentro do foreach como argumento

            // Imprimindo a lista de contatos
            //System.Console.WriteLine("Lista de Contatos");

            // Fazendo varredura 
            foreach(Contato contatos in ag.Listar()){
                Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine($"{contatos.Nome} - {contatos.Telefone}");
                Console.ResetColor();
            }

            // Instanciando objeto mensagem, seus atributos e métodos
            Mensagem msg = new Mensagem();
            msg.Texto = "Hello World!" ;
            msg.Destinatario = ct2;
            System.Console.WriteLine( msg.Enviar());

        }
    }
}    
