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
        private LocacaoContext contextDB = new LocacaoContext();


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
            return GetUsuarios().ToList<Usuario>().Exists(x => x.Login == usuarios.Login && x.Senha == usuarios.Senha);
        }
       
        /// <summary>
        /// Metodo para adicionar um novo usuario na lista usuarios e adiciona um novo id na propriedade Id
        /// </summary>
        /// <param name="parametroUsuario">Novo usuário que será adicionado a lista</param>
        public bool AdicionaUsuario(Usuario parametroUsuario)
        {
            if (string.IsNullOrWhiteSpace(parametroUsuario.Login)) return false;
            if (string.IsNullOrWhiteSpace(parametroUsuario.Senha)) return false;

            contextDB.Usuarios.Add(parametroUsuario);
            contextDB.SaveChanges();
            return true;
        }


        /// <summary>
        /// Metodo que retorna nossa lista interna de usuarios 
        /// </summary>
        /// <returns>Lista contendo os usuarios ativos </returns>
        public IQueryable<Usuario> GetUsuarios()
        {
            return contextDB.Usuarios.Where(x => x.Ativo == true);
        }
        
        /// <summary>
        /// Metodo que atualiza o usuario
        /// </summary>
        /// <param name="parametro"></param>
        /// <returns></returns>
        public bool AlterarUsuario(Usuario parametro)
        {
            var usuario = contextDB.Usuarios.FirstOrDefault(x => x.Id == parametro.Id);
            if (usuario == null) return false;

            else
            {
                parametro.DataAlteracao = DateTime.Now;

            }
            contextDB.SaveChanges();
            return true;
        }


        /// <summary>
        /// Metodo que desativa um registro de usuario cadastrado em nossa lista
        /// </summary>
        /// <param name="identificadoId">parametro que identifica o usuario que seta desativado </param>
        public bool RemoverUsuarioPorId(int identificadoId)
        {

            var usuRemove = contextDB.Usuarios.FirstOrDefault(x => x.Id == identificadoId);
            if (usuRemove == null) return false;
            usuRemove.Ativo = false;
            contextDB.SaveChanges();
            return true;
        }

    }
}
