// AVISO: ESSE PROJETO ESTA USANDO .NET 10, PROVAVELMENTE VERSOES MAIS ANTIGAS NÃO EXECUTARAM O CODIGO PROPIAMENTE

using System;
using struct_bruno.Models;
namespace struct_bruno.obj;
    


public class Program
{
    public struct Projeto{
            public int ID ;
            public string nomeProjeto ;
            public string nomeAluno ;
            public string areaProjeto ;
            public int semestre;
            public bool statusProjeto; // true= concluido, false = em andamento
    };

    static Projeto[] projetos = new Projeto[20];

    static void Main(string[] args)
    {
        while (true) 
        {
            Console.WriteLine("--Hub de Projetos--");
            Console.WriteLine("1. Adicionar Projeto");
            Console.WriteLine("2. Listar projetos");
            Console.WriteLine("3. Alterar dados de um projeto");
            Console.WriteLine("4. Excluir projeto");
            Console.WriteLine("5. Sair");

            string entrada = Console.ReadLine();

            if (!int.TryParse(entrada, out int option)){
                Console.Clear();
                Console.WriteLine("\nDigite apenas números (1, 2 ou 3)");
                Console.WriteLine("Pressione qualquer tecla para tentar novamente...");
                Console.ReadKey();
                Console.Clear();
                continue;
            }


            if(option == 1)
            {
                Console.Clear();
                Controllers.addProjeto(projetos); 
            }
            else if(option == 2)
            {
                Console.Clear();
                Controllers.listarProjetos(projetos);
            }
            else if(option == 3)
            {
                Console.Clear();
                Controllers.editarProjeto(projetos);
            }
            else if(option == 4)
            {
                Console.Clear();
                Controllers.deletarProjeto(projetos);
            }
            else if(option == 5)
            {
                break;
            }
            
        } 
    }
}