using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCervejas.Model;

namespace ListagemDeCervejas.Controller
{
    public class CervejaController
    {
        private SistemaCervejaContext cervejaContext = new SistemaCervejaContext();

        /// <summary>
        /// Metodo que retorna para o usuario a listagem de todas as cervejas
        /// </summary>
        /// <returns></returns>
        public List<Cerveja> ListagemCervejas()
        {
            return cervejaContext.ListaDeCervejas;
        }

        /// <summary>
        /// Metodo que adiciona novas cervejas na lista cerveja
        /// </summary>
        /// <param name="cerveja"></param>
        public void AdicionarCerveja(Cerveja cerveja)
        {
            cerveja.Id = cervejaContext.contador++;
            cervejaContext.ListaDeCervejas.Add(cerveja);
        }
        /// <summary>
        /// Metodo que calcula a quantidade de itens dentro da lista cerveja
        /// </summary>
        /// <returns></returns>
        public int TotalCerveja()
        {
            return cervejaContext.ListaDeCervejas.Count();
        }
        /// <summary>
        /// Metodo que calcula a quantidade de litros de cerveja está presente na lista 
        /// </summary>
        /// <returns></returns>
        public double TotalLitros()
        {
            return cervejaContext.ListaDeCervejas.Sum(i => i.Litros);
        }
        /// <summary>
        /// Metodo que soma a quantidade de teor alcoolico presente na lista de cerveja
        /// </summary>
        /// <returns></returns>
        public double TotalTeor()
        {
            return cervejaContext.ListaDeCervejas.Sum(i => i.Alcool);
        }
        /// <summary>
        /// Metodo que calcular o teor alcoolico no sangue da pessoa e infoma se ela será presa ou não
        /// </summary>
        /// <param name="peso"></param>
        /// <param name="sexo"></param>
        public void TeorAlcool( double peso, char sexo)
        {
            var pesocerveja = ((TotalTeor()) * TotalLitros())* (790);
            var ta = 0.0;
            switch (sexo)
            {
                case 'M':
                    ta = pesocerveja/(peso * 0.7);
                    break;
                case 'F':
                     ta = pesocerveja / (peso * 0.6);
                    break;
            }
            if (ta > 0.34) Console.WriteLine($"Você será preso sua Taxa Álcoolica no sangue é de: {ta}");
            else Console.WriteLine($"Você não será preso sua Taxa Álcoolica no sangue é de: {ta}");
           

            
        }

    }
}