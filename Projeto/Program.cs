using Projeto;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            List<Pessoa> ListaPessoas = new List<Pessoa>();
            int opcao = 0;

            do
            {
                Console.Clear();
                Console.WriteLine(" ==== Sistema de Cadastro ====");
                Console.WriteLine("1 - Cadastrar Aluno");
                Console.WriteLine("2 - Cadastrar Professor");
                Console.WriteLine("3 - Exibir Todos Cadastros");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("Escolha uma Opção");

                string entrada = Console.ReadLine();
                if (int.TryParse(entrada, out opcao))
                {
                    switch (opcao)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("-- Cadastro de Aluno");
                            Console.Write("Digite o Nome do Aluno: ");
                            string nomeAluno = Console.ReadLine();

                            Console.Write("Digite o Curso: ");
                            string curso = Console.ReadLine();

                            ListaPessoas.Add(new Aluno(nomeAluno, curso));
                            Console.WriteLine("\n Aluno Cadastrado com Sucesso!");
                            Console.ReadKey();
                            break;

                        case 2:
                            Console.Clear();
                            Console.WriteLine("-- Cadastro de Professor");
                            Console.Write("Digite o Nome do Professor: ");
                            string nomeProf = Console.ReadLine();

                            Console.Write("Digite a Disciplina: ");
                            string disciplina = Console.ReadLine();

                            ListaPessoas.Add(new Aluno(nomeProf, disciplina));
                            Console.WriteLine("\n Professor Cadastrado com Sucesso!");
                            Console.ReadKey();
                            break;

                        case 3:
                            Console.Clear();
                            Console.WriteLine("-- Lista de Cadastros");
                            if (ListaPessoas.Count == 0)
                            {
                                Console.WriteLine("\n Nenhum Cadastro Encontrado!");
                            }
                            else
                            {
                                foreach (var pessoa in ListaPessoas)
                                {
                                    pessoa.ExibirInfo();
                                }
                                Console.WriteLine("Pressione qualquer tecla para sair");
                                Console.ReadKey();
                                break;
                            }
                        case 0:
                            Console.WriteLine("Saindo do Sistema...");
                            break;
                        default:
                            Console.WriteLine("Opção Inválida!");
                            Console.ReadKey();
                            break;
                    }
                }
            } while (opcao != 0);
        }catch(Exception ex)
        {
            Console.WriteLine($"Ocorreu um erro desconhecido:{ex.Message}");
            Console.WriteLine("Pressione qualquer tecla para fechar");
            Console.ReadKey();
        }
    }
}