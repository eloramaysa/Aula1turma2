using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPessoas.Controller
{
    public class PessoaController
    {
        private List<Pessoa> ListaDePessoas { get; set; }

        /// <summary>
        /// O metodo contrutor ajuda a iniciar nosa classe para utilizarmos de maneira correta as informações internas, com isso podemos iniciar nossa lista de pessoas 
        /// sem depender do usuario ou programador na parte da interface
        /// </summary>
        public PessoaController()
        {
            //Iniciamos a lista de pessoas dentro do nosso metodo construtor
            ListaDePessoas = new List<Pessoa>
            {
                new Pessoa()
                {
                    Id = 1,
                    Nome = "Spears",
                    DataDeNascimento=DateTime.Parse("07/11/2004"),
                    ValorCarteira =  846.96
                },
                new Pessoa()
                {
                    Id = 2,
                    Nome = "Swanson",
                    DataDeNascimento=DateTime.Parse("20/06/2003"),
                    ValorCarteira =   233.09
                },
                new Pessoa()
                {
                    Id = 3,
                    Nome = "Gay",
                    DataDeNascimento=DateTime.Parse("03/12/2001"),
                    ValorCarteira =911.92
                },
                 new Pessoa()
                {
                    Id = 4,
                    Nome = "Gregory",
                    DataDeNascimento=DateTime.Parse("02/01/2000"),
                    ValorCarteira = 469.01
                },
                 new Pessoa()
                {
                    Id = 5,
                    Nome = "Olson",
                    DataDeNascimento=DateTime.Parse("18/07/2001"),
                    ValorCarteira = 261.90
                },
                 new Pessoa()
                {
                    Id = 6,
                    Nome = "Garza",
                    DataDeNascimento=DateTime.Parse("01/04/2000"),
                    ValorCarteira =  360.41
                },
                  new Pessoa()
                {
                    Id = 7,
                    Nome = "Sweet",
                    DataDeNascimento=DateTime.Parse("12/03/2003"),
                    ValorCarteira =  312.76
                },
                   new Pessoa()
                {
                    Id = 8,
                    Nome = "Cline",
                    DataDeNascimento=DateTime.Parse("26/03/2002"),
                    ValorCarteira = 484.51
                },
                      new Pessoa()
                {
                    Id = 8,
                    Nome = "Cline",
                    DataDeNascimento=DateTime.Parse("26/03/2002"),
                    ValorCarteira = 484.51
                },
                new Pessoa()
                {
                    Id = 9,
                    Nome = "Oliver",
                    DataDeNascimento=DateTime.Parse("05/07/2004"),
                    ValorCarteira = 513.76
                },
                new Pessoa()
                {
                    Id = 10,
                    Nome = "Vang",
                    DataDeNascimento=DateTime.Parse("10/07/2000"),
                    ValorCarteira =  271.05
                },
                new Pessoa()
                {
                    Id = 11,
                    Nome = "Maddox",
                    DataDeNascimento=DateTime.Parse("29/05/2004"),
                    ValorCarteira =  783.97
                },
                 new Pessoa()
                {
                    Id = 12,
                    Nome = "Garrett",
                    DataDeNascimento=DateTime.Parse("03/06/2006"),
                    ValorCarteira =   154.11
                },
                 new Pessoa()
                {
                    Id = 13,
                    Nome = "Mcintosh",
                    DataDeNascimento=DateTime.Parse("06/07/2006"),
                    ValorCarteira = 902.80
                },
                 new Pessoa()
                {
                    Id = 14,
                    Nome = "Yang",
                    DataDeNascimento=DateTime.Parse("29/04/2005"),
                    ValorCarteira =  550.48
                },
                 new Pessoa()
                {
                    Id = 15,
                    Nome = "Hendricks",
                    DataDeNascimento=DateTime.Parse("05/09/2003	"),
                    ValorCarteira =410.56
                },
                  new Pessoa()
                {
                    Id = 16,
                    Nome = "Cain",
                    DataDeNascimento=DateTime.Parse("12/01/2002	"),
                    ValorCarteira =221.13
                },
                    new Pessoa()
                {
                    Id = 17,
                    Nome = "Blackburn",
                    DataDeNascimento=DateTime.Parse("10/05/2000	"),
                    ValorCarteira =135.67
                },
                     new Pessoa()
                {
                    Id = 18,
                    Nome = "Howe",
                    DataDeNascimento=DateTime.Parse("27/09/2005"),
                    ValorCarteira = 360.14
                },
                      new Pessoa()
                {
                    Id = 19,
                    Nome = "Pratt",
                    DataDeNascimento=DateTime.Parse("18/09/2000"),
                    ValorCarteira =  991.83
                },
                         new Pessoa()
                {
                    Id = 20,
                    Nome = "Sherman	",
                    DataDeNascimento=DateTime.Parse("20/02/2003"),
                    ValorCarteira =  667.00
                },
            };

        }
        /// <summary>
        /// Temos uma propriedade agora que nos retorna nossa lista com essa propriedade temos a lista completa
        /// e sem regras da lista de pessoas, mas ao liberar somente o GET não damos acesso para alterar fora da classe
        /// a lista, apenas visualização 
        /// </summary>
        public List<Pessoa> ListaDePessoasPublica
        {
            //NO get podemos retorna propriedades privadas e calculo de metodos quando necessário 
            get { return ListaDePessoas; }
        }

        /// <summary>
        /// Metodo que retorna nossa lista de pessoas ordenada de forma Asc
        /// pelo nome de cada uma
        /// </summary>
        /// <returns>Retornarmos o valor já ordenado de nossa lista</returns>
        public List<Pessoa> GetPessoasOrdenadaAsc()
        {
            return ListaDePessoas.OrderBy(x => x.Nome).ToList<Pessoa>();
        }
        /// <summary>
        /// Metodo publico que retorna a lista ordenada pela data de nascimento da maior data para a menor data
        /// </summary>
        /// <returns>Lista ordenada</returns>
        public List<Pessoa> GetPessoasDataDecres()
        {
            return ListaDePessoas.OrderByDescending(x => x.DataDeNascimento).ToList<Pessoa>();
        }
        /// <summary>
        /// Metodo publico que retorna a lista filtrada com as pessoas que tem mais de 500 reais na carteira
        /// </summary>
        /// <returns>Lista filtrada</returns>
        public List<Pessoa> GetPessoasRicas(double valor=500) //Em caso de não informado o valor, o 500 passa a ser utilizado 
        {
            return ListaDePessoas.FindAll(x => x.ValorCarteira > valor).OrderBy(x => x.ValorCarteira).ToList<Pessoa>();
        }
        /// <summary>
        /// Metodo publico que retorna lista filtrada de pessoas maiores de 18 anos 
        /// </summary>
        /// <returns>Lista Filtrada</returns>
        public List<Pessoa> GetPessoasMaioresDe(int idade =18)
        {
            return ListaDePessoas.FindAll(x => ( (DateTime.Now.Year - x.DataDeNascimento.Year) >= idade)).ToList<Pessoa>();
        }
        /// <summary>
        /// Metodo publico que retorna lista filtrada de pessoas mmenores de 16 anos 
        /// </summary>
        /// <param name="idade"></param>
        /// <returns></returns>
        public List<Pessoa> GetPessoasMenoresDe(int idade=16)
        {
            return ListaDePessoas.FindAll(x => ((DateTime.Now.Year - x.DataDeNascimento.Year) < idade)).ToList<Pessoa>();
        }


    }
}
