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

    public static void editarProjeto(Program.Projeto[] projetos)
    {
        while (true){
    
            Console.Write("Digite o ID do projeto que deseja editar ou digite 0 para sair: ");
            string entradaID = Console.ReadLine();

            if (int.TryParse(entradaID, out int idParaEditar))
            {
                if (idParaEditar == 0)
                {
                    Console.Clear();
                    break;
                }

                bool encontrado = false;

                for (int j = 0; j < projetos.Length; j++)
                {

                    if (projetos[j].ID == idParaEditar)
                    {
                        encontrado = true;
                        Console.Clear();
                        Console.WriteLine($"--- Editando Projeto ID: {idParaEditar} ---");

                        Console.Write($"Nome do projeto ({projetos[j].nomeProjeto}): ");
                        string novoNomeProjeto = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(novoNomeProjeto))
                        {
                            projetos[j].nomeProjeto = novoNomeProjeto;
                        }

                        Console.Write($"Nome do aluno ({projetos[j].nomeAluno}): ");
                        string novoNomeAluno = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(novoNomeAluno))
                        {
                            if (novoNomeAluno.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                            {
                                projetos[j].nomeAluno = novoNomeAluno;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Nome do aluno inválido. Mantendo valor anterior\n.");
                                
                            }
                        }

                        Console.Write($"Área do projeto ({projetos[j].areaProjeto}): ");
                        string novaAreaProjeto = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(novaAreaProjeto))
                        {
                            projetos[j].areaProjeto = novaAreaProjeto;
                        }

                        Console.Write($"Semestre ({projetos[j].semestre}): ");
                        string entradaSemestre = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(entradaSemestre))
                        {
                            if (int.TryParse(entradaSemestre, out int novoSemestre))
                            {
                                projetos[j].semestre = novoSemestre;
                            }
                            else
                            {
                                Console.WriteLine("Valor inválido para semestre. Mantendo valor anterior.\n");
                            }
                        }

                        string statusAtual = projetos[j].statusProjeto ? "Concluído" : "Em andamento";

                        Console.Write($"Projeto concluído? (S/N) ({statusAtual}): ");
                        string entradaStatus = Console.ReadLine();


                        if (!string.IsNullOrWhiteSpace(entradaStatus))
                        {
                            string respostaStatus = entradaStatus.Trim().ToLower();
                            if (respostaStatus == "sim" || respostaStatus == "s")
                            {
                                projetos[j].statusProjeto = true;
                            }
                            else if (respostaStatus == "não" || respostaStatus == "nao" || respostaStatus == "n")
                            {
                                projetos[j].statusProjeto = false;
                            }
                            else
                            {
                                Console.WriteLine("Status inválido. Mantendo valor anterior.\n");
                            }
                        }

                        Console.Clear();
                        Console.WriteLine("Projeto atualizado com sucesso\n");

                        return;
                    }
                }

                if (!encontrado)
                {
                    Console.WriteLine("ID não encontrado na lista.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            else
            {
                Console.WriteLine("Por favor, digite um número de ID válido.");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }

    public static void deletarProjeto(Program.Projeto[] projetos)
    {

        
        while (true)
        {
            Console.Write("Digite o ID do projeto que deseja deletar ou digite 0 para sair: ");
            string entradaID = Console.ReadLine();


            if (!int.TryParse(entradaID, out int idParaDeletar))
            {
                Console.WriteLine("Por favor, digite um número de ID válido.");
                Console.ReadKey();
                Console.Clear();
                continue;
            }

            if (idParaDeletar == 0)
            {
                
                Console.Clear();
                break;
            }

            int indiceProjeto = -1;
            for (int i = 0; i < projetos.Length; i++)
            {
                if (projetos[i].ID == idParaDeletar)
                {
                    indiceProjeto = i;
                    break;
                }
            }

            if (indiceProjeto == -1)
            {
                Console.WriteLine("ID não encontrado na lista.");
                Console.ReadKey();
                Console.Clear();
                continue;
            }

            for (int i = indiceProjeto; i < projetos.Length - 1; i++)
            {
                projetos[i] = projetos[i + 1];

                if (projetos[i].ID != 0)
                {
                    projetos[i].ID = i + 1;
                }
            }

            projetos[projetos.Length - 1] = new Program.Projeto();

            Console.WriteLine("Projeto deletado com sucesso!");
            Console.ReadKey();
            Console.Clear();
            return;
        }
    }



}
    
