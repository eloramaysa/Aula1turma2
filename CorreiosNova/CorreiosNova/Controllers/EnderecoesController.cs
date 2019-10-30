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
using CorreiosNova.Models;

namespace CorreiosNova.Controllers
{
    public class EnderecoesController : ApiController
    {
        private EnderecoContext db = new EnderecoContext();

        // GET: api/Enderecoes
        public IQueryable<Endereco> GetEnderecoes()
        {
            return db.Enderecoes;
        }

        [HttpGet]
        [Route("Api/Enderecoes/{id}/InfoId")]
        public IQueryable<Endereco> EnderecosById(int id)
        {
            return db.Enderecoes.Where(x => x.Id == id);
        }

        [HttpGet]
        [Route("Api/Enderecoes/{cep}/InfoCep")]
        public IQueryable<Endereco> EnderecosByCep(string cep)
        {
            return db.Enderecoes.Where(x => x.CEP == cep);
        }


        [HttpGet]
        [Route("Api/Enderecoes/{bairro}/InfoBairro")]
        public IQueryable<Endereco> EnderecosByBairro(string bairro)
        {
            return db.Enderecoes.Where(x => x.Bairro == bairro);
        }


        [HttpGet]
        [Route("Api/Enderecoes/{cidade}/InfoCidade")]
        public IQueryable<Endereco> EnderecosByCidade(string cidade)
        {
            return db.Enderecoes.Where(x => x.Municipio == cidade);
        }

        [HttpGet]
        [Route("Api/Enderecoes/{uf}/InfoUf")]
        public IQueryable<Endereco> EnderecosByUF(string uf)
        {
            return db.Enderecoes.Where(x => x.UF == uf);
        }


        [HttpGet]
        [Route("Api/Enderecoes/{rua}/InfoRua")]
        public IQueryable<Endereco> EnderecosByRua(string rua)
        {
            return db.Enderecoes.Where(x => x.Logradouro == rua);
        }

      





        // GET: api/Enderecoes/5
        [ResponseType(typeof(Endereco))]
        public IHttpActionResult GetEndereco(int id)
        {
            Endereco endereco = db.Enderecoes.Find(id);
            if (endereco == null)
            {
                return NotFound();
            }

            return Ok(endereco);
        }

        // PUT: api/Enderecoes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutEndereco(int id, Endereco endereco)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != endereco.Id)
            {
                return BadRequest();
            }

            db.Entry(endereco).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EnderecoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok("Update realizado com sucesso");
        }

        // POST: api/Enderecoes
        [ResponseType(typeof(Endereco))]
        public IHttpActionResult PostEndereco(Endereco endereco)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Enderecoes.Add(endereco);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = endereco.Id }, endereco);
        }

        // DELETE: api/Enderecoes/5
        [ResponseType(typeof(Endereco))]
        public IHttpActionResult DeleteEndereco(int id)
        {
            Endereco endereco = db.Enderecoes.Find(id);
            if (endereco == null)
            {
                return NotFound();
            }

            db.Enderecoes.Remove(endereco);
            db.SaveChanges();

            return Ok(endereco);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EnderecoExists(int id)
        {
            return db.Enderecoes.Count(e => e.Id == id) > 0;
        }
    }
}