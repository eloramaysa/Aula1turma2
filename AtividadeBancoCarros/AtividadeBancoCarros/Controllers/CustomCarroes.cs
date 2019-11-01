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
using AtividadeBancoCarros.Models;


namespace AtividadeBancoCarros.Controllers
{
    public partial class CarroesController
    {
        [HttpGet]
        [Route("Api/Carroes/CustomQUery")]
        public object CustomCarrosQuery()
        {
            var listaDeCarros = db.Carros.ToList();

            var retornoCarros = from cr in listaDeCarros
                                select new
                                {
                                    ModeloCarro = cr.Modelo,
                                    CarroId = cr.Id
                                };

            return retornoCarros;
        }

        [HttpGet]
        [Route("Api/Carroes/CarrosComMarcas")]
        public object CustomCarrosOnMarcas()
        {
            var listCarros = db.Carros.ToList();

            // var listMarcas = db.Marcas.ToList();

            //  var NomeMarca = db.Carros.Find(1).Marca1.Nome; lazyLoading 
            List<Object> ListaObjetos = new List<Object>();
            foreach (var item in listCarros)
            {
                ListaObjetos.Add(new
                {
                    CarroId = item.Id,
                    CarroNome = item.Modelo,
                    MarcaId = item.Marca,
                    MarcaNome = item.Marca1.Nome
                });
            }

            return ListaObjetos;
        }
        [HttpGet]
        [Route("Api/Carroes/CarrosComUsuarios")]
        public object CustomCarrosOnUsuarios()
        {
            //Criar chave estrangeira 
            var listCarros = db.Carros.ToList();
            var listUsu = db.Usuarios.ToList();

            var conteudoRetorno = from usu in listUsu
                                  join car in listCarros on usu.Id equals car.UsuInc
                                  select new
                                  {
                                      CarroId = car.Id,
                                      CarroNome = car.Modelo,
                                      UsuarioId = usu.Id,
                                      UsuarioNome = usu.Usuario1
                                  };

            return conteudoRetorno;
        }

    }

}
