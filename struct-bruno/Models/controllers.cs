namespace struct_bruno.Models;
using struct_bruno.obj;

public class Controllers(){
    public static void addProjeto(Program.Projeto[] projetos){
        for(int i = 0; i < projetos.Length; i++)
        {
          if(projetos[i].ID == 0)
            {

                while (true)
                {
                    Console.Write("Nome do projeto: ");
                    string respostaNomeProjetoForm = Console.ReadLine();

                    if(string.IsNullOrWhiteSpace(respostaNomeProjetoForm) )
                    {
                        Console.Clear();
                        Console.WriteLine("Campo em branco");
                    }
                    else
                    {
                        projetos[i].nomeProjeto = respostaNomeProjetoForm;
                        Console.Clear();
                        break;
                    }

                    
                }
                
                while (true)
                {
                    Console.Write("Nome do aluno: ");

                    string respostaNomeAlunoForm = Console.ReadLine();

                    if (!string.IsNullOrWhiteSpace(respostaNomeAlunoForm) && respostaNomeAlunoForm.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                    {
                        projetos[i].nomeAluno = respostaNomeAlunoForm;
                        Console.Clear();
                        break;
                    }
                    else
                    {   
                        Console.Clear();
                        Console.WriteLine("O nome deve conter apenas letras e não pode ser em branco");
                    }
                }
                
                
                Console.Write("Área do projeto: ");
                projetos[i].areaProjeto = Console.ReadLine();
                Console.Clear();
                
                


                while (true){
                    Console.Write("Semestre: ");
                    string entradaSemestre = Console.ReadLine();

                    if (int.TryParse(entradaSemestre, out int respostaCertaSemestre)){
                        projetos[i].semestre = respostaCertaSemestre;
                        Console.Clear();
                        break;
                    }
                    else
                    {   
                        Console.Clear();
                        Console.WriteLine("Digite um número válido para o semestre");
                    }
                }

                

                projetos[i].ID = i + 1;

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
    
