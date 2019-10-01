using LocacaoBiblioteca.Controller;
using LocacaoBiblioteca.Model;
using System;

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
            //e chama o metod de novo até a inserção correta 
            while (!RealizaLoginSistema())
                Console.WriteLine("Login e senha inválidos");

            MostraMenuSistema();
            

        }

      
        /// <summary>
        /// Mostra no console o menu disponivel do sistema 
        /// </summary>
        private static void MostraMenuSistema()
        {
            Console.Clear();
            Console.WriteLine("SISTEMA DE LOCAÇÃO DE LIVROS 1.0");

            Console.WriteLine("Menu Sistema");
            Console.WriteLine("1- Listar Usuários");
            Console.WriteLine("2- Listar Livros");
            Console.WriteLine("3- Cadastrar Livro");
            Console.WriteLine("4 -Cadastrar Usuários ");
            Console.WriteLine("5 - Remover Usuário ");
            Console.WriteLine("6 - Remover Livro ");
            Console.WriteLine("7- Trocar de Usuario");
            Console.WriteLine("0- Sair ");

            var resposta = int.MinValue;
            while (resposta != 0)
            {
                resposta = int.Parse(Console.ReadKey().KeyChar.ToString());
                Console.Clear();
                switch (resposta)
                {
                    case 0:
                        
                        break;
                    case 1:
                        MostrarUsuarios();
                        Console.ReadKey();
                        MostraMenuSistema();

                        break;

                    case 2:
                        MostrarLivro();
                        Console.ReadKey();
                        MostraMenuSistema();
                        break;

                    case 3:
                        AdicionarLivro();
                        MostraMenuSistema();
                        break;
                    case 4:
                        AdicionarUsuario();
                        MostraMenuSistema();
                        break;
                    case 5:
                        RemoverUsuarioPeloId();
                        MostraMenuSistema();
                        break;
                    case 6:
                        RemoverLivroPeloId();
                        MostraMenuSistema();
                        break;
                    case 7:
                        while (!RealizaLoginSistema())
                            Console.WriteLine("Login e senha inválidos");
                        MostraMenuSistema();
                        break;
                    default:
                        MostraMenuSistema();
                        break;
                }
                
            }
            Console.ReadKey();
        }
        private static void RemoverLivroPeloId()
        {
            Console.WriteLine("Remover o livro pelo Id no sistema");
            MostrarLivro();

            Console.WriteLine("Informe o Id que deseja desativar do sistema:");
            var livroId = int.Parse(Console.ReadLine());
            livrosController.RemoverLivroPorID(livroId);
            Console.WriteLine("Livro removido com sucesso");
            Console.ReadKey();
        }

        private static void RemoverUsuarioPeloId()
        {
            Console.WriteLine("Remover o usuário pelo Id no sistema");
            MostrarUsuarios();

            Console.WriteLine("Informe o Id para desativar do sistema:");
            var usuarioID = int.Parse(Console.ReadLine());

            usuariosController.RemoverUsuarioPorId(usuarioID);

            Console.WriteLine("Usuário desativado com sucesso");
            Console.ReadKey();
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
            usuariosController.AdicionaUsuario(new Usuario()
            {
                Login = novoUsuario,
                Senha = senhaUsuario
            }); 
            Console.WriteLine("Usuário cadastrado com sucesso!");
            Console.ReadKey();
        }


        /// <summary>
        /// Metodo que adiciona dentro de nossa lista um novo registro de livro
        /// </summary>
        private static void AdicionarLivro()
        {
            //Identificamos que o mesmo esta na parte de cadastro de livros do sistema
            Console.WriteLine("Cadastrar livro dentro do sistema: ");
            Console.WriteLine("Nome do livro para cadastro");
            var nomeDoLivro = Console.ReadLine();
            //"livrosControlle" livros controle e o nosso"objeto" em memoria 
            //Com isso temos disponivel nele ferramentas que nos ajudam a realizar as tarefas
            //como adionar um item a nossa lista de livros
            livrosController.AdicionarLivro(new Livro()
            {
                //Aqui atribuimos o nome que demos ao livro na propriedade Nome do nosso livro 
                Nome = nomeDoLivro
            });
            Console.WriteLine("Livro cadastrado com sucesso!");
            Console.ReadKey();
        }

        /// <summary>
        /// Metodo que mostra os usuarios já cadastrados na lista
        /// </summary>
        private static void MostrarUsuarios()
        {
            usuariosController.RetornaListaDeUsuarios().ForEach(i => Console.WriteLine($"Id: {i.Id} Nome do Usuário: {i.Login}"));
           
        }


        /// <summary>
        /// Metodo que mostra os livros já cadastrados no Livro 
        /// </summary>
        private static void MostrarLivro()
        {

            livrosController.RetornaListaDeLivros().ForEach(i => Console.WriteLine($"Id: {i.Id} Nome do Livro: {i.Nome}"));
           
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
