using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebApiBancoCarros.Models;

namespace WebApiBancoCarros.Controllers
{
    public partial  class UsuariosController
    {
        [HttpGet]
        [Route("Api/Usuarios/CustomQUery")]
        public object CustomUsuariosQuery()
        {
            var listaDeUsuarios = db.Usuarios.ToList();

            var retornoUsu = from usu in listaDeUsuarios
                             select new
                             {
                                 Nome = usu.Usuario1,
                                 NomeId = usu.Id
                             };

            return retornoUsu;
        }
    }
}