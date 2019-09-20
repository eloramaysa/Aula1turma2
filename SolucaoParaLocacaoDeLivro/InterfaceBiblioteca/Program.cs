using LocacaoBiblioteca.Controller;
using LocacaoBiblioteca.Model;
using System;

namespace InterfaceBiblioteca
{
    class Program
    {
        //torna-se uma base de dados, método construtor
        static LivrosController livros = new LivrosController();

        static UsuarioController usuarios = new UsuarioController();
        static void Main(string[] args)
        {
            Console.WriteLine("SISTEMA DE LOCAÇÃO DE LIVROS 1.0");
            //Enquanto o metodo retorna o valor falso, retorna a mensagem de dados inválidos 
            //e chama o metod de novo até a inserção correta 
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
            Console.Clear();
            Console.WriteLine("SISTEMA DE LOCAÇÃO DE LIVROS 1.0");

            Console.WriteLine("Menu Sistema");
            Console.WriteLine("1- Listar usuários");
            Console.WriteLine("2- Listar Livros");
            Console.WriteLine("3- Cadastrar Livro");
            Console.WriteLine("4- Trocar de usuario");
            Console.WriteLine("0- Sair ");
            var resposta = int.MinValue;
            while (resposta != 0)
            {
                resposta = int.Parse(Console.ReadKey().KeyChar.ToString());
                switch (resposta)
                {
                    case 0:
                        Console.ReadKey();
                        break;
                    case 1:
                        MostrarUsuarios();
                        MostraMenuSistema();

                        break;

                    case 2:
                        MostrarLivro();
                        MostraMenuSistema();
                        break;
                    case 4:
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

        /// <summary>
        /// Metodo que mostra os usuarios já cadastrados na lista
        /// </summary>
        private static void MostrarUsuarios()
        {
            usuarios.Usuarios.ForEach(i => Console.WriteLine(i.Login));
            Console.ReadKey();
        }
        /// <summary>
        /// Metodo que mostra os livros já cadastrados no Livro 
        /// </summary>
        private static void MostrarLivro()
        {
            livros.Livros.ForEach(i => Console.WriteLine(i.Nome));
            Console.ReadKey();
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

            UsuarioController usuarioController = new UsuarioController();

            return usuarioController.LoginSistema(new Usuario()
            {
                Login = loginDoUsuario,
                Senha = senhaDoUsuario
            });

        }
    }
}
