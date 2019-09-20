using LocacaoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Controller
{
    /// <summary>
    /// Classe que contem os metodos de usuários do sistema
    /// </summary>
    public class UsuarioController
    {
        /// <summary>
        /// Metodo que realiza o login dentro do nosso sistema
        /// Para realizar o login padrão use:
        /// -Login:Admin
        /// -Senha:Admin
        /// </summary>
        /// <param name="Usuario">Passamos um objeto de nome Usuario como parametro</param>
        /// <returns>Retorna verdadeiro quando exister o usuário com este login e senha</returns>
        public bool LoginSistema(Usuario usuarios)
        {
            //Expressão lambda para saber se o login e senha informado estao no banco de dados 
            return Usuarios.Exists(x => x.Login == usuarios.Login && x.Senha == usuarios.Senha);
        }
        /// <summary>
        /// Metodo que cria lista com todos os usuarios inseridos
        /// </summary>
        public  List<Usuario> Usuarios { get; set; }
        /// <summary>
        /// Metodo para adicionar novos usuarios na classe usuário
        /// </summary>
        public UsuarioController()
        {
            Usuarios = new List<Usuario>();
            Usuarios.Add(new Usuario()
            {
                Login = "admin",
                Senha = "admin"
            });
            Usuarios.Add(new Usuario()
            {
                Login = "user",
                Senha = "user"
            });
        }

    }
}
