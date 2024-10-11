namespace GerenciamentoEscolar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Disciplina disciplina1 = new Disciplina("Sistemas distribuídos e mobile", "D1");
            Disciplina disciplina2 = new Disciplina("Usabilidade, desenvolvimento web, mobile e jogos", "D2");

            Turma turma1 = new Turma("T1", disciplina1);
            Turma turma2 = new Turma("T2", disciplina2);

            Boolean encerrar = false;
            string opcao, nome, email;
            int matricula;
            Aluno aluno;

            do
            {
                Console.Clear();
                Console.WriteLine("   MENU\n\nInforme uma opção: \n\n1. Turmas \n\n2. Buscar aluno \n\n3. Atualizar informações de um aluno \n\n4. Encerra");
                opcao = Console.ReadLine();

                switch (opcao) 
                {
                    case "1":
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("   TURMA\n\nInforme a turma \n\n1. Turma - Sistemas distribuídos e mobile \n\n2. Turma - Usabilidade, desenvolvimento web, mobile e jogos \n\n3. Voltar");
                            opcao = Console.ReadLine();

                            switch (opcao)
                            {
                                case "1":
                                    do
                                    {
                                        Console.Clear();
                                        Console.WriteLine("   SISTEMAS DISTRIBUÍDOS E MOBILE \n\nInforme uma opção:\n\n1. Adicionar aluno \n\n2. Exibir todos alunos \n\n3. Remover aluno \n\n4. Voltar");
                                        opcao = Console.ReadLine();

                                        switch (opcao)
                                        {
                                            case "1":
                                                Console.Clear();
                                                Console.Write("Informe o Nome: ");
                                                nome = Console.ReadLine();

                                                Console.Write("Informe a matricula: ");
                                                matricula = int.Parse(Console.ReadLine());

                                                Console.Write("Informe o email: ");
                                                email = Console.ReadLine();

                                                turma1.adicionarAluno(new Aluno(nome, matricula, email));
                                                break;

                                            case "2":
                                                Console.Clear();
                                                foreach (Aluno obj in turma1.Alunos)
                                                {
                                                    Console.WriteLine(obj);
                                                }
                                                Console.ReadKey();
                                                break;

                                            case "3":
                                                Console.Clear();
                                                Console.Write("Informe a matricula do aluno: ");
                                                matricula = int.Parse(Console.ReadLine());
                                                turma1.removerAluno(matricula);
                                                break;

                                            case "4":
                                                break;


                                            default:
                                                Console.Clear();
                                                Console.WriteLine("Opção invalida!");
                                                Console.ReadKey();
                                                break;
                                        }
                                    } while (opcao != "4");

                                    break;



                                case "2":
                                    do
                                    {
                                        Console.Clear();
                                        Console.WriteLine("   USABILIDADE, DESENVOLVIMENTO WEB, MOBILE E JOGOS \n\n Informe uma opção:\n\n1. Adicionar aluno \n\n2. Exibir todos alunos \n\n3. Remover aluno \n\n4. Voltar");
                                        opcao = Console.ReadLine();

                                        switch (opcao)
                                        {
                                            case "1":
                                                Console.Clear();
                                                Console.Write("Informe o Nome: ");
                                                nome = Console.ReadLine();

                                                Console.Write("Informe a matricula: ");
                                                matricula = int.Parse(Console.ReadLine());

                                                Console.Write("Informe o email: ");
                                                email = Console.ReadLine();

                                                turma2.adicionarAluno(new Aluno(nome, matricula, email));
                                                break;

                                            case "2":
                                                Console.Clear();
                                                foreach (Aluno obj in turma2.Alunos)
                                                {
                                                    Console.WriteLine(obj);
                                                }
                                                Console.ReadKey();
                                                break;

                                            case "3":
                                                Console.Clear();
                                                Console.Write("Informe a matricula do aluno: ");
                                                matricula = int.Parse(Console.ReadLine());
                                                turma2.removerAluno(matricula);
                                                break;

                                            case "4":
                                                break;


                                            default:
                                                Console.Clear();
                                                Console.WriteLine("Opção invalida!");
                                                Console.ReadKey();
                                                break;
                                        }
                                    }while (opcao != "4");

                                    break;

                                case "3":
                                    break;

                                default:
                                    Console.Clear();
                                    Console.WriteLine("Opção invalida!");
                                    Console.ReadKey();
                                    break;
                            }
                        } while (opcao != "3");

                        break;

                    case "2":
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("   BUSCA DE ALUNO \n\nInforme a turma no aluno: \n\n1. Turma - Sistemas distribuídos e mobile \n\n2. Turma - Usabilidade, desenvolvimento web, mobile e jogos \n\n3. Voltar");
                            opcao = Console.ReadLine();
                            switch (opcao)
                            {
                                case "1":
                                    Console.Clear();
                                    Console.Write("   SISTEMAS DISTRIBUÍDOS E MOBILE - BUSCA \n\nInforme a matricula do aluno: ");
                                    matricula = int.Parse(Console.ReadLine());

                                    aluno = turma1.buscarAlunoPorMatricula(matricula);
                                    Console.WriteLine(aluno);

                                    Console.ReadKey();
                                    break;

                                case "2":
                                    Console.Clear();
                                    Console.Write("   USABILIDADE, DESENVOLVIMENTO WEB, MOBILE E JOGOS - BUSCA \n\nInforme a matricula do aluno: ");
                                    matricula = int.Parse(Console.ReadLine());

                                    aluno = turma1.buscarAlunoPorMatricula(matricula);
                                    Console.WriteLine(aluno);
                                    Console.ReadKey();
                                    break;

                                case "3":
                                    break;

                                default:
                                    Console.Clear();
                                    Console.WriteLine("Opção invalida!");
                                    Console.ReadKey();
                                    break;
                            }
                        } while (opcao != "3");
                        break;

                    case "3":
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("   ATUALIZAR INFORMAÇÂO DE ALUNO \n\nInforme a turma no aluno: \n\n1. Turma - Sistemas distribuídos e mobile \n\n2. Turma - Usabilidade, desenvolvimento web, mobile e jogos \n\n3. Voltar");
                            opcao = Console.ReadLine();
                            switch (opcao)
                            {
                                case "1":
                                    Console.Clear();
                                    Console.Write("   SISTEMAS DISTRIBUÍDOS E MOBILE - ATUALIZAR INFORMAÇÂO DE ALUNO \n\nInforme a matricula do aluno: ");
                                    matricula = int.Parse(Console.ReadLine());

                                    aluno = turma1.buscarAlunoPorMatricula(matricula);

                                    Console.Write("Informe o Nome: ");
                                    nome = Console.ReadLine();

                                    Console.Write("Informe a Matricula: ");
                                    matricula = int.Parse(Console.ReadLine());

                                    Console.Write("Informe o Email: ");
                                    email = Console.ReadLine();

                                    aluno.Nome = nome;
                                    aluno.Matricula = matricula;
                                    aluno.Email = email;

                                    break;

                                case "2":
                                    Console.Clear();
                                    Console.Write("   USABILIDADE, DESENVOLVIMENTO WEB, MOBILE E JOGOS - ATUALIZAR INFORMAÇÂO DE ALUNO\n\nInforme a matricula do aluno: ");
                                    matricula = int.Parse(Console.ReadLine());

                                    aluno = turma2.buscarAlunoPorMatricula(matricula);

                                    Console.Write("Informe o Nome: ");
                                    nome = Console.ReadLine();

                                    Console.Write("Informe a Matricula: ");
                                    matricula = int.Parse(Console.ReadLine());

                                    Console.Write("Informe o Email: ");
                                    email = Console.ReadLine();

                                    aluno.Nome = nome;
                                    aluno.Matricula = matricula;
                                    aluno.Email = email;

                                    break;

                                case "3":
                                    break;

                                default:
                                    Console.Clear();
                                    Console.WriteLine("Opção invalida!");
                                    Console.ReadKey();
                                    break;
                            }
                        }while(opcao != "3");

                        break;

                    case "4":
                        encerrar = true;
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Opção invalida!");
                        Console.ReadKey();
                        break;
                }
            
            }while (!encerrar);

            Console.Clear();
            Console.WriteLine("Programa Encerrado.");
        }
    }
}
