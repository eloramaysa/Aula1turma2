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
    public partial class VendasController
    {

        [HttpGet]
        [Route("Api/Vendas/CustomQUery")]
        public object CustomVendasQuery()
        {
            var listaDeVendas = db.Vendas.ToList();

            var retornoVendas = from ven in listaDeVendas
                                select new
                                {
                                    Venda = ven.Carro1.Modelo,

                                };

            return retornoVendas;
        }
    }
}
