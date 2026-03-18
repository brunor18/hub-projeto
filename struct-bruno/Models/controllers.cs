namespace struct_bruno.Models;
using struct_bruno.obj;

public class Controllers(){
    public static void addProjeto(Program.Projeto[] projetos){
        for(int i = 0; i < projetos.Length; i++)
        {
          if(projetos[i].ID == 0)
            {
                Console.Write("Nome do projeto: ");
                projetos[i].nomeProjeto = Console.ReadLine();
                Console.Clear();

                Console.Write("Nome do aluno: ");
                projetos[i].nomeAluno = Console.ReadLine();
                Console.Clear();

                Console.Write("Área do projeto: ");
                projetos[i].areaProjeto = Console.ReadLine();
                Console.Clear();

                Console.Write("Semestre: ");
                projetos[i].semestre = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                projetos[i].ID = i + 1;

                Console.WriteLine($"DEBUG: Salvei no índice {i}. O ID agora é {projetos[i].ID}");
                Console.ReadKey();

                while (true)
                {
                    Console.Write("O projeto foi concluído?(S/N): ");
                    string resposta = Console.ReadLine();
                    Console.Clear();

                    if(resposta.ToLower() == "não" || resposta.ToLower() == "nao" || resposta == "n")
                    {
                        projetos[i].statusProjeto = false;
                        Console.Clear();
                        Console.WriteLine("Projeto adicionado com sucesso!\n");
                        return;
                    }
                    else if(resposta.ToLower() == "sim" || resposta == "s" )
                    {
                        projetos[i].statusProjeto = true;
                        Console.Clear();
                        Console.WriteLine("Projeto adicionado com sucesso!\n");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Responda com sim ou não");
                    }
                }
            }
            
        };

        Console.WriteLine("A lista de projetos esta cheia");
    }



    public static void listarProjetos(Program.Projeto[] projetos){
        Console.Clear();
        
        bool temProjetos = false;

        foreach(var proj in projetos)
        {

            if(proj.ID != 0)
            {

                temProjetos = true;

                Console.WriteLine($"ID: {proj.ID}\n");
                Console.WriteLine($"Nome do projeto: {proj.nomeProjeto}");
                Console.WriteLine($"Nome do aluno: {proj.nomeAluno}");
                Console.WriteLine($"Área do projeto: {proj.areaProjeto}");
                Console.WriteLine($"Semestre: {proj.semestre}");

                if (proj.statusProjeto)
                {
                    Console.WriteLine($"Status do projeto: Concluído\n");
                }
                else
                {
                    Console.WriteLine($"Status do projeto: Em andamento\n");
                }
            }         	
      	}

        if (!temProjetos)
        {
            Console.WriteLine("Nenhum projeto adicionado ainda\n");
        }

        Console.Write("Digite qualquer coisa para voltar pro hub: ");
        Console.ReadKey();
        Console.Clear();
   }
}
    
