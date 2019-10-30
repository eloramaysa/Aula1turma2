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
    public partial class MarcasController
    {

        [HttpGet]
        [Route("Api/Marcas/CustomQUery")]
        public object CustomMarcasQuery()
        {
            var listaDeMarcas = db.Marcas.ToList();

            var retornoMarcas = from mar in listaDeMarcas
                                select new
                                {
                                    NomeMarca = mar.Nome,
                                    MarcaId = mar.Id
                                };

            return retornoMarcas;
        }
    }
}