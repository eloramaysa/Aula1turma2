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

        [HttpGet]
        [Route("Api/Vendas/VendaAno/{ano}")]
        public IHttpActionResult VendaAno(int ano)
        {
            var listaVendas = db.Vendas.ToList();
            var listaCarros = db.Carros.ToList();
            var conteudoRetorno = from ven in listaVendas
                                  join car in listaCarros
                                  on ven.Carro equals car.Id
                                  where ven.DatInc.Year == ano
                                  select new
                                  {
                                      CarroId = car.Id,
                                      CarroNome = car.Modelo,
                                      CarroQuantidade = ven.Quantidade,
                                      CarroValor = ven.Valor,
                                      CarroDataVenda = ven.DatInc.Year
                                  };
            return Ok(conteudoRetorno);

            /*  var listaVendas = db.Vendas.ToList();
              Venda conferencia;
              List<Venda> vendas = new List<Venda>();
              foreach (var obj in listaVendas)
              {
                  foreach (var itemVenda in obj)
                  {

                  }
                  conferencia = db.Vendas.FirstOrDefault(x => x.DatInc.Year == item);
                  if (conferencia == null)
                  {
                      return NotFound();
                  }
                  vendas.Add(conferencia);
              }

              return Ok(vendas);*/
        }

        [HttpGet]
        [Route("Api/Vendas/VendaPorUsuario/{ano}/{id}")]
        public IHttpActionResult VendaUsuAno(int ano, int id)
        {
            var listaVendas = db.Vendas.ToList();
            var listaCarros = db.Carros.ToList();
            var listaUsuarios = db.Usuarios.ToList();

            var retornoVendas = from ven in listaVendas join
                                car in listaCarros on ven.Carro equals car.Id
                                join usu in listaUsuarios on ven.UsuInc equals usu.Id
                                where ven.DatInc.Year == ano 
                                where usu.Id == id
                                select new
                                {
                                    UsuarioId = usu.Id,
                                    UsuarioVenda = usu.Usuario1,
                                    CarroId = car.Id,
                                    CarroNome = car.Modelo,
                                    CarroQuantidade = ven.Quantidade,
                                    CarroValor = ven.Valor,
                                    CarroDataVenda = ven.DatInc.Year

                                };

            return Ok(retornoVendas);
            
        }

        [HttpGet]
        [Route("Api/Vendas/MarcaAno/{ano}/{marID}")]
        public IHttpActionResult MarcaAno (int ano, int marID)
        {
            var listaVendas = db.Vendas.ToList();
            var listaCarros = db.Carros.ToList();
            var listaMarcas = db.Marcas.ToList();

            var retornoVendas = from ven in listaVendas join
                               car in listaCarros on
                               ven.Carro equals car.Id join mar in
                                listaMarcas on car.Marca equals mar.Id
                                where ven.DatInc.Year == ano where
                                mar.Id == marID
                                orderby (ven.Quantidade * ven.Valor) descending
                                select new
                                {
                                    MarcaId = mar.Id,
                                    MarcaNome = mar.Nome,
                                    CarroId = car.Id,
                                    CarroNome = car.Modelo,
                                    CarroQuantidade = ven.Quantidade,
                                    CarroValor = ven.Valor,
                                    CarroDataVenda = ven.DatInc.Year

                                };

            return Ok(retornoVendas);
        }


    }
}