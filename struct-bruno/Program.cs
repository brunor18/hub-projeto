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
            Console.WriteLine("3. Sair");
            int option = Convert.ToInt32(Console.ReadLine());

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
                break;
            }
            
        } 
    }
}