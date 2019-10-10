using LocacaoBiblioteca.Controller;
using LocacaoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceBiblioteca
{
    class Program
    {
        //torna-se uma base de dados, método construtor
        static LivrosController livrosController = new LivrosController();

        static UsuarioController usuariosController = new UsuarioController();

        static void Main(string[] args)
        {
            Console.WriteLine("SISTEMA DE LOCAÇÃO DE LIVROS 1.0");
            //Enquanto o metodo retorna o valor falso, retorna a mensagem de dados inválidos 
            //e chama o metodo de novo até a inserção correta 
          while (!RealizaLoginSistema())
               Console.WriteLine("Login e senha inválidos");

            MostraMenuSistema();
            Console.ReadKey();

        }


        /// <summary>
        /// Mostra no console o menu disponivel do sistema 
        /// </summary>
        private static void MostraMenuSistema()
        {
           
            var resposta = int.MinValue;
            while (resposta != 0)
            {
                Console.WriteLine("SISTEMA DE LOCAÇÃO DE LIVROS 1.0");

                Console.WriteLine("Menu Sistema");
                Console.WriteLine("1- Listar Usuários");
                Console.WriteLine("2- Listar Livros");
                Console.WriteLine("3- Cadastrar Livro");
                Console.WriteLine("4 -Cadastrar Usuários ");
                Console.WriteLine("5 - Remover Usuário ");
                Console.WriteLine("6 - Remover Livro ");
                Console.WriteLine("7 - Alterar Usuário");
                Console.WriteLine("8- Alterar Livro");
                Console.WriteLine("9- Trocar de Usuario");
                Console.WriteLine("0- Sair ");
                resposta = int.Parse(Console.ReadKey().KeyChar.ToString());
                Console.Clear();
                switch (resposta)
                {
                    case 0:

                        break;
                    case 1:
                        MostrarUsuarios();
                       
                        //MostraMenuSistema();

                        break;

                    case 2:
                        MostrarLivro();
                        
                        //MostraMenuSistema();
                        break;

                    case 3:
                        AdicionarLivro();
                        //MostraMenuSistema();
                        break;
                    case 4:
                        AdicionarUsuario();
                       // MostraMenuSistema();
                        break;
                    case 5:
                        RemoverUsuarioPeloId();
                       // MostraMenuSistema();
                        break;
                    case 6:
                        RemoverLivroPeloId();
                      //  MostraMenuSistema();
                        break;
                    case 7:
                        AlterarUsuario();
                       // MostraMenuSistema();
                        break;
                    case 8:
                        AlterarLivro();
                       //MostraMenuSistema();
                        break;
                    case 9:
                        while (!RealizaLoginSistema())
                            Console.WriteLine("Login e senha inválidos");
                        //MostraMenuSistema();
                        break;
                  
                    default:
                       
                        break;
                 
                }
                Console.ReadKey(true);
                Console.Clear();

            }


        }


        /// <summary>
        /// Metodo para Alterar o login do usuario 
        /// </summary>
        private static void AlterarUsuario()
        {
            Console.WriteLine("Alterar usuario");
            MostrarUsuarios();
            Console.WriteLine("Informe o Id do Usuario para alterar");
            var usuarioId = int.Parse(Console.ReadLine());

            var usuAlt = usuariosController.GetUsuarios().FirstOrDefault(x => x.Id == usuarioId);
            if (usuAlt == null)
            {
                Console.WriteLine("Id não encontrado ");
                return;
            }
            Console.WriteLine("Informe o nome do Usuario:");
            usuAlt.Login = Console.ReadLine();
            Console.WriteLine("Informe uma nova senha:");
            usuAlt.Senha = Console.ReadLine();

            var resultado = usuariosController.AlterarUsuario(usuAlt);
            if (resultado) Console.WriteLine("Usuario Atualizado com sucesso");
            else Console.WriteLine("Erro ao alterar o usuario");
        }


        /// <summary>
        /// Metodo para alterar o livro
        /// </summary>
        private static void AlterarLivro()
        {
            Console.WriteLine("Alterar Livro");
            MostrarLivro();
            Console.WriteLine("Informe o Id do Livro para alterar");
            var livroId = int.Parse(Console.ReadLine());

            var livroAlt = livrosController.GetLivros().FirstOrDefault(x => x.Id == livroId);
            if (livroAlt == null)
            {
                Console.WriteLine("Id não encontrado ");
                return;
            }
            Console.WriteLine("Informe o nome do Livro:");
            livroAlt.Nome= Console.ReadLine();

            var resultado = livrosController.AlterarLivro(livroAlt);
            if (resultado) Console.WriteLine("Livro Atualizado com sucesso");
            else Console.WriteLine("Erro ao alterar o livro");
        }


        /// <summary>
        /// Metodo que remove livro pelo Id
        /// </summary>
        private static void RemoverLivroPeloId()
        {
            Console.WriteLine("Remover Livro");
            MostrarLivro();
            Console.WriteLine("Informe o Id do livro para desativar");
            var livroId = int.Parse(Console.ReadLine());
            var resultado = livrosController.RemoverLivroPorID(livroId);
            if (resultado) Console.WriteLine("Livro removido com sucesso");
            else Console.WriteLine("Erro ao desativar o livro");
        }
        
        /// <summary>
        /// Metodo que remove usuario pelo Id
        /// </summary>
        private static void RemoverUsuarioPeloId()
        {
            Console.WriteLine("Remover o usuário pelo Id no sistema");
            MostrarUsuarios();

            Console.WriteLine("Informe o Id para desativar do sistema:");
            var usuarioID = int.Parse(Console.ReadLine());

            var resultado = usuariosController.RemoverUsuarioPorId(usuarioID);

            if (resultado) Console.WriteLine("Usuário desativado com sucesso");
            else Console.WriteLine("Erro ao desativar o usuário");

        }


        /// <summary>
        /// Metodo para cadastrar um novo usuário
        /// </summary>
        private static void AdicionarUsuario()
        {
            Console.WriteLine("Cadastrar um novo usuário no sistema");
            Console.WriteLine("Informe um novo usuário: ");
            var novoUsuario = Console.ReadLine();
            Console.WriteLine("Informe uma nova senha: ");
            var senhaUsuario = Console.ReadLine();
            var resultado = usuariosController.AdicionaUsuario(new Usuario()
            {
                Login = novoUsuario,
                Senha = senhaUsuario
            });

            if (resultado)
                Console.WriteLine("Usuário cadastrado com sucesso!");
            else Console.WriteLine("Erro ao cadastrar o usuário");
        }


        /// <summary>
        /// Metodo que adiciona dentro de nossa lista um novo registro de livro
        /// </summary>
        private static void AdicionarLivro()
        {

            Console.WriteLine("Cadastrar livro dentro do sistema: ");
            Console.WriteLine("Nome do livro para cadastro");
            var nomeDoLivro = Console.ReadLine();

            var resultado = livrosController.AdicionarLivro(new Livro()
            {
                Nome = nomeDoLivro
            });
            if (resultado) Console.WriteLine("Livro cadastrado com sucesso!");
            else Console.WriteLine("Erro ao cadastrar o livro");

        }

        /// <summary>
        /// Metodo que mostra os usuarios já cadastrados na lista
        /// </summary>
        private static void MostrarUsuarios()
        {
            usuariosController.GetUsuarios().ToList<Usuario>().ForEach(i => Console.WriteLine($"Id: {i.Id} Nome do Usuário: {i.Login} "));
        }


        /// <summary>
        /// Metodo que mostra os livros já cadastrados no Livro 
        /// </summary>
        public static void MostrarLivro()
        {

            livrosController.GetLivros().ToList<Livro>().ForEach(x => Console.WriteLine($"Id: {x.Id} Nome: {x.Nome}"));


        }


        /// <summary>
        /// Metodo que realiza os procedimentos completos de login dentro do sistema
        /// como solicitação de login e senha pelo console assim como a 
        /// respectivas validações que o mesmo precisa para entrar no sistema 
        /// </summary>
        /// <returns> Retorna verdadeiro quando o login e senha informados estiverem corretos</returns>
        private static bool RealizaLoginSistema()
        {
            Console.WriteLine("Informe seu login e senha para acessar o sistema:");

            Console.WriteLine("Login:");
            var loginDoUsuario = Console.ReadLine();

            Console.WriteLine("Senha:");
            var senhaDoUsuario = Console.ReadLine();

            return usuariosController.LoginSistema(new Usuario()
            {
                Login = loginDoUsuario,
                Senha = senhaDoUsuario
            });

        }
    }
}
