using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCarros.Model
{
    public class SistemaCarrosContext
    {
        /// <summary>
        /// Metodo que cria lista de carros que será armazenado posteriormente
        /// </summary>
        public List<Carro> ListaDeCarros { get; set; }

        /// <summary>
        /// Metodo que armazena os dados na lista de carros
        /// </summary>
        public SistemaCarrosContext()
        {
            ListaDeCarros = new List<Carro>()
            { new Carro()
            {
                Id = 1,
                Modelo= "Gol",
                Marca = "Volkswagen",
                Ano = 2012,
                Cilindradas = 1.4,
                Portas = 4
                },
                new Carro()
            {
                Id = 2,
                Modelo= "Mobi",
                Marca = "Fiat",
                Ano = 2016,
                Cilindradas = 1.6,
                Portas = 4
                },
                 new Carro()
            {
                Id = 3,
                Modelo= "HB20",
                Marca = "Hyundai",
                Ano = 2015,
                Cilindradas = 1.0,
                Portas = 4
                },
                 new Carro()
            {
                Id = 4,
                Modelo= "Uno",
                Marca = "Fiat",
                Ano = 2003,
                Cilindradas = 1.0,
                Portas = 2
                },
                 new Carro()
            {
                Id = 5,
                Modelo= "Jetta",
                Marca = "Volkswagen",
                Ano = 2017,
                Cilindradas = 1.8,
                Portas = 4
                },
                 new Carro()
            {
                Id = 6,
                Modelo= "Hylux",
                Marca = "Toyota",
                Ano = 2019,
                Cilindradas = 2.0,
                Portas = 4
                },
                 new Carro()
            {
                Id = 7,
                Modelo= "Onix",
                Marca = "Chevrolet",
                Ano = 2016,
                Cilindradas = 1.4,
                Portas = 4
                },
                  new Carro()
            {
                Id = 8,
                Modelo= "Etios",
                Marca = "Toyota",
                Ano = 2018,
                Cilindradas = 1.4,
                Portas = 4
                },
                   new Carro()
            {
                Id = 9,
                Modelo= "Up",
                Marca = "Volkswagen",
                Ano = 2014,
                Cilindradas = 1.0,
                Portas = 4
                },
                    new Carro()
            {
                Id = 10,
                Modelo= "Ford KA",
                Marca = "Ford",
                Ano = 2008,
                Cilindradas = 1.0,
                Portas = 2
                },
            };

        }

    }
}
