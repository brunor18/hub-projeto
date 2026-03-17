// AVISO: ESSE PROJETO ESTA USANDO .NET 10, PROVAVELMENTE VERSOES MAIS ANTIGAS NÃO EXECUTARAM O CODIGO PROPIAMENTE

using System;
using struct_bruno.Models;
    


public class Program
{
    struct Projeto{
            public int ID ;
            public string nomeProjeto ;
            public string nomeAluno ;
            public string areaProjeto ;
            public int semestre;
            public bool statusProjeto; // true= concluido, false = em andamento
    };

    Projeto[] projetos = new Projeto[20];

    static void Main()
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
                Controllers.addProjeto(); 
            }
            if(option == 2)
            {
                // listarProjetos();
            }
            if(option == 3)
            {
                // break;
            }
            
        } 
    }
}