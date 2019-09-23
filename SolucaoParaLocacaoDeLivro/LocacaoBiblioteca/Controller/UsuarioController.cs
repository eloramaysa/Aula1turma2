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
        //Criando privado para impedir o programador de adionar um ID ou alterarar fora da classe
        private int ContadorId = 100;

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
            return RetornaListaDeUsuarios().Exists(x => x.Login == usuarios.Login && x.Senha == usuarios.Senha);
        }


        /// <summary>
        /// Metodo que cria lista com todos os usuarios inseridos
        /// </summary>
        private  List<Usuario> Usuarios { get; set; }


        /// <summary>
        /// Metodo para adicionar novos usuarios na classe usuário
        /// </summary>
        public UsuarioController()
        {
            
            Usuarios = new List<Usuario>();
            Usuarios.Add(new Usuario()
            {
                Login = "admin",
                Senha = "admin",
                Id = ContadorId++

            }) ;
            Usuarios.Add(new Usuario()
            {
                Login = "user",
                Senha = "user",
                Id = ContadorId++
            });
        }


        /// <summary>
        /// Metodo para adicionar um novo usuario na lista usuarios e adiciona um novo id na propriedade Id
        /// </summary>
        /// <param name="parametroUsuario">Novo usuário que será adicionado a lista</param>
        public void AdicionaUsuario(Usuario parametroUsuario)
        {
            parametroUsuario.Id = ContadorId++;
            Usuarios.Add(parametroUsuario);
        }


        /// <summary>
        /// Metodo que retorna nossa lista interna de usuarios 
        /// </summary>
        /// <returns>Lista contendo os usuarios ativos </returns>
        public List<Usuario> RetornaListaDeUsuarios()
        {
            //Retorna agora somente a lsita de usuarios ativos com a expressao where
            return Usuarios.Where(x=> x.Ativo).ToList<Usuario>();
        }


        /// <summary>
        /// Metodo que desativa um registro de usuario cadastrado em nossa lista
        /// </summary>
        /// <param name="identificadoId">parametro que identifica o usuario que seta desativado </param>
        public void RemoverUsuarioPorId(int identificadoId)
        {
            //Aqui usamos o metodo FirstOrDefault para localizar nosso usuario dentro da lista
            //com isso conseguimos acessar as propriedade dele e desativar o registro
            Usuarios.FirstOrDefault(x => x.Id == identificadoId).Ativo = false;
        }

    }
}
