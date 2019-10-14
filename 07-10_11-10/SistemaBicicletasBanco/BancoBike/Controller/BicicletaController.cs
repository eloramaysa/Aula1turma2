using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoBike.Model;
namespace BancoBike.Controller
{
    public class BicicletaController
    {
        public BicicletaContext bicicleta = new BicicletaContext();


        /// <summary>
        /// Metodo que lista as bicicletas ativas do banco de dados
        /// </summary>
        /// <returns></returns>
        public IQueryable<Bicicleta> GetBicicletas()
        {
            return bicicleta.Bicicletas.Where(x => x.Ativo == true);
        }

        /// <summary>
        /// Metodo que insere novas bicicletas no banco de dados
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool InserirBicicleta(Bicicleta item)
        {
            if (string.IsNullOrWhiteSpace(item.Marca)) return false;

            if (string.IsNullOrWhiteSpace(item.Modelo)) return false;

            if (item.Preco <= 0) return false;

            bicicleta.Bicicletas.Add(item);
            bicicleta.SaveChanges();

            return true;
        }

        /// <summary>
        /// Metodo para atualizar bicicleta
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool AtualizarBicicleta(Bicicleta item)
        {
            var bike = bicicleta.Bicicletas.FirstOrDefault(x => x.Id == item.Id);

            if (bike == null) return false;

            item.DataAlteracao = DateTime.Now;
            bicicleta.SaveChanges();

            return true;

        }

        /// <summary>
        /// Metodo para desativar uma bicicleta da nosso banco de dados 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool RemoverBicleta(int id)
        {
            var bike = bicicleta.Bicicletas.FirstOrDefault(x => x.Id == id);

            if (bike == null) return false;

            bike.Ativo = false;

            bicicleta.SaveChanges();

            return true;

        }

        /// <summary>
        /// Metodo que retorna lista de Bicicletas em ordem descendete de preco
        /// </summary>
        /// <returns></returns>
       public IQueryable<Bicicleta> OrdenandoBike()
        {
            return bicicleta.Bicicletas.Where(x => x.Ativo == true).OrderByDescending(x => x.Preco);
        }

        /// <summary>
        /// Metodo que retorna o valor total de bicicletas do bando de dados
        /// </summary>
        /// <returns></returns>
        public double TotalBike()
        {
            return bicicleta.Bicicletas.Sum(x => x.Preco);
        }


    }
}
