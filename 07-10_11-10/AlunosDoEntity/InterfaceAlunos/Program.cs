using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityClass.Controller;
using EntityClass.Model;
namespace InterfaceAlunos
{
    class Program
    {
        static AlunoController alunoController = new AlunoController();
        static void Main(string[] args)
        {
            MostrarMenu();
        }
        public static void ListarAlunos()
        {
            alunoController.GetAlunos().ToList<Aluno>().ForEach(x => Console.WriteLine($"Id: {x.Id} Nome: {x.Nome} Idade: {x.Idade}"));
        }
        public static void AdicionarAluno()
        {
            Aluno obj = new Aluno();
            Console.WriteLine("Informe o nome do Aluno");
            obj.Nome = Console.ReadLine();
            Console.WriteLine("Informe a idade do Aluno");
            obj.Idade = int.Parse(Console.ReadLine());

            alunoController.AddAluno(obj);
            Console.WriteLine("Aluno Adicionado Com Sucesso");

        }
        public static void LimpaTela()
        {
            Console.ReadKey();
            Console.Clear();
            MostrarMenu();
        }
        public static void MostrarMenu()
        {
            Console.WriteLine("Escolha qual opção deseja realizar");
            Console.WriteLine("1 - Listar Alunos:");
            Console.WriteLine("2 - Cadastrar Novos Alunos: ");
            Console.WriteLine("0 - Para sair");
            int resposta = int.Parse(Console.ReadLine());
            switch (resposta)
            {
                case 1:
                    ListarAlunos();
                    LimpaTela();
                    break;
                case 2:
                    AdicionarAluno();
                    LimpaTela();
                    break; 
                default:
                    Console.ReadKey();
                        break;
            }
        }
    }
}
