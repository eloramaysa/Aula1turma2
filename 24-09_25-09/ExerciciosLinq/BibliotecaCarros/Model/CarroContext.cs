using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCarros.Model
{
    public class CarroContext
    {
        /// <summary>
        /// Criando A lista que vai armazenar os dados
        /// </summary>
        public List<Carro> ListaDeCarros { get; set; }

        /// <summary>
        /// Metodo que armazena toda a lista de carros
        /// </summary>
        public CarroContext()
        {
            ListaDeCarros = new List<Carro>
            {
new Carro(){ Id = 1  , CarroNome= " Risus Company                       ", Valor = 7200 , Quantidade = 18 , DataVenda = DateTime.Parse(" 29/01/2019") } ,
new Carro(){ Id = 2  , CarroNome= " Risus Associates                    ", Valor = 9961 , Quantidade = 4  , DataVenda = DateTime.Parse(" 10/02/2019")},
new Carro(){ Id = 3  , CarroNome= " Et Libero Proin Foundation          ", Valor = 8710 , Quantidade = 17 , DataVenda = DateTime.Parse(" 24/01/2019")},
new Carro(){ Id = 4  , CarroNome= " Cursus Et Ltd                       ", Valor = 9010 , Quantidade = 17 , DataVenda = DateTime.Parse(" 26/10/2019")},
new Carro(){ Id = 5  , CarroNome= " Odio Etiam Ligula Company           ", Valor = 5245 , Quantidade = 8  , DataVenda = DateTime.Parse(" 16/02/2019")},
new Carro(){ Id = 6  , CarroNome= " Eu Nibh Inc.                        ", Valor = 7922 , Quantidade = 9  , DataVenda = DateTime.Parse(" 27/06/2019")},
new Carro(){ Id = 7  , CarroNome= " Tellus Limited                      ", Valor = 7294 , Quantidade = 7  , DataVenda = DateTime.Parse(" 26/01/2019")},
new Carro(){ Id = 8  , CarroNome= " Imperdiet PC                        ", Valor = 8305 , Quantidade = 5  , DataVenda = DateTime.Parse(" 06/09/2019")},
new Carro(){ Id = 9  , CarroNome= " Elit Inc.                           ", Valor = 5398 , Quantidade = 18 , DataVenda = DateTime.Parse(" 09/06/2019")},
new Carro(){ Id = 10 , CarroNome= " Quam A Limited                      ", Valor = 5398 , Quantidade = 14 , DataVenda = DateTime.Parse(" 09/09/2019")},
new Carro(){ Id = 11 , CarroNome= " Adipiscing Institute                ", Valor = 8133 , Quantidade = 4  , DataVenda = DateTime.Parse(" 24/10/2019")},
new Carro(){ Id = 12 , CarroNome= " Posuere At Velit Ltd                ", Valor = 5121 , Quantidade = 15 , DataVenda = DateTime.Parse(" 19/11/2019")},
new Carro(){ Id = 13 , CarroNome= " Nunc In Industries                  ", Valor = 8902 , Quantidade = 2  , DataVenda = DateTime.Parse(" 21/07/2019")},
new Carro(){ Id = 14 , CarroNome= " Integer Vitae Nibh Corporation      ", Valor = 6313 , Quantidade = 20 , DataVenda = DateTime.Parse(" 02/02/2019")},
new Carro(){ Id = 15 , CarroNome= " Tellus Nunc Lectus Company          ", Valor = 9650 , Quantidade = 2  , DataVenda = DateTime.Parse(" 20/07/2019")},
new Carro(){ Id = 16 , CarroNome= " Suspendisse LLC                     ", Valor = 5319 , Quantidade = 12 , DataVenda = DateTime.Parse(" 24/12/2019")},
new Carro(){ Id = 17 , CarroNome= " Mauris Vestibulum Corporation       ", Valor = 5790 , Quantidade = 5  , DataVenda = DateTime.Parse(" 14/11/2019")},
new Carro(){ Id = 18 , CarroNome= " Sed Nec Corp.                       ", Valor = 8421 , Quantidade = 2  , DataVenda = DateTime.Parse(" 05/05/2019")},
new Carro(){ Id = 19 , CarroNome= " Enim Nisl Elementum Inc.            ", Valor = 5904 , Quantidade = 6  , DataVenda = DateTime.Parse(" 26/06/2019")},
new Carro(){ Id = 20 , CarroNome= " Ac Mattis Semper Corporation        ", Valor = 5110 , Quantidade = 4  , DataVenda = DateTime.Parse(" 14/01/2019")},
new Carro(){ Id = 21 , CarroNome= " Donec Tempus Lorem LLC              ", Valor = 8576 , Quantidade = 16 , DataVenda = DateTime.Parse(" 29/03/2019")},
new Carro(){ Id = 22 , CarroNome= " Tempor Augue Ac Ltd                 ", Valor = 9072 , Quantidade = 16 , DataVenda = DateTime.Parse(" 09/07/2019")},
new Carro(){ Id = 23 , CarroNome= " Diam Duis Mi LLC                    ", Valor = 8472 , Quantidade = 4  , DataVenda = DateTime.Parse(" 23/09/2019")},
new Carro(){ Id = 24 , CarroNome= " Aliquam Corp.                       ", Valor = 6607 , Quantidade = 4  , DataVenda = DateTime.Parse(" 28/09/2019")},
new Carro(){ Id = 25 , CarroNome= " Montes Institute                    ", Valor = 6176 , Quantidade = 8  , DataVenda = DateTime.Parse(" 19/06/2019")},
new Carro(){ Id = 26 , CarroNome= " Hendrerit Institute                 ", Valor = 8387 , Quantidade = 11 , DataVenda = DateTime.Parse(" 17/09/2019")},
new Carro(){ Id = 27 , CarroNome= " Erat Etiam Vestibulum Corporation   ", Valor = 7584 , Quantidade = 9  , DataVenda = DateTime.Parse(" 02/06/2019")},
new Carro(){ Id = 28 , CarroNome= " Adipiscing Ltd                      ", Valor = 7887 , Quantidade = 9  , DataVenda = DateTime.Parse(" 19/03/2019")},
new Carro(){ Id = 29 , CarroNome= " In Tempus Eu Inc.                   ", Valor = 5233 , Quantidade = 16 , DataVenda = DateTime.Parse(" 20/07/2019")},
new Carro(){ Id = 30 , CarroNome= " Elit Institute                      ", Valor = 7359 , Quantidade = 11 , DataVenda = DateTime.Parse(" 12/09/2019")},
new Carro(){ Id = 31 , CarroNome= " Aliquam Erat LLC                    ", Valor = 8842 , Quantidade = 4  , DataVenda = DateTime.Parse(" 14/03/2019")},
new Carro(){ Id = 32 , CarroNome= " A Feugiat Tellus PC                 ", Valor = 9176 , Quantidade = 4  , DataVenda = DateTime.Parse(" 10/12/2019")},
new Carro(){ Id = 33 , CarroNome= " Aliquet Incorporated                ", Valor = 9057 , Quantidade = 8  , DataVenda = DateTime.Parse(" 26/04/2019")},
new Carro(){ Id = 34 , CarroNome= " Dolor Dolor Tempus Institute        ", Valor = 8433 , Quantidade = 15 , DataVenda = DateTime.Parse(" 31/10/2019")},
new Carro(){ Id = 35 , CarroNome= " Risus Odio Auctor PC                ", Valor = 8286 , Quantidade = 11 , DataVenda = DateTime.Parse(" 29/03/2019")},
new Carro(){ Id = 36 , CarroNome= " Aliquet Molestie Tellus Corp.       ", Valor = 8779 , Quantidade = 1  , DataVenda = DateTime.Parse(" 05/07/2019")},
new Carro(){ Id = 37 , CarroNome= " Ipsum Corp.                         ", Valor = 5568 , Quantidade = 15 , DataVenda = DateTime.Parse(" 10/03/2019")},
new Carro(){ Id = 38 , CarroNome= " Mi Lacinia Foundation               ", Valor = 7442 , Quantidade = 20 , DataVenda = DateTime.Parse(" 09/07/2019")},
new Carro(){ Id = 39 , CarroNome= " Cubilia Curae; Corp.                ", Valor = 8421 , Quantidade = 7  , DataVenda = DateTime.Parse(" 26/05/2019")},
new Carro(){ Id = 40 , CarroNome= " Velit Sed Malesuada Associates      ", Valor = 9841 , Quantidade = 6  , DataVenda = DateTime.Parse(" 07/11/2019")},
new Carro(){ Id = 41 , CarroNome= " Duis Foundation                     ", Valor = 9849 , Quantidade = 6  , DataVenda = DateTime.Parse(" 08/12/2019")},
new Carro(){ Id = 42 , CarroNome= " Erat Semper Consulting              ", Valor = 6168 , Quantidade = 10 , DataVenda = DateTime.Parse(" 10/11/2019")},
new Carro(){ Id = 43 , CarroNome= " Turpis Inc.	                    ", Valor = 7758 , Quantidade = 7  , DataVenda = DateTime.Parse(" 12/08/2019")},
new Carro(){ Id = 44 , CarroNome= " Aenean Industries                   ", Valor = 8770 , Quantidade = 12 , DataVenda = DateTime.Parse(" 10/09/2019")},
new Carro(){ Id = 45 , CarroNome= " Nulla Industries                    ", Valor = 8884 , Quantidade = 8  , DataVenda = DateTime.Parse(" 10/11/2019")},
new Carro(){ Id = 46 , CarroNome= " Semper Egestas Urna Inc.	    ", Valor = 9428 , Quantidade = 11 , DataVenda = DateTime.Parse(" 26/06/2019")},
new Carro(){ Id = 47 , CarroNome= " Donec Luctus Aliquet Industries     ", Valor = 5928 , Quantidade = 8  , DataVenda = DateTime.Parse(" 11/07/2019")},
new Carro(){ Id = 48 , CarroNome= " Cum Sociis Natoque Foundation       ", Valor = 7506 , Quantidade = 2  , DataVenda = DateTime.Parse(" 21/07/2019")},
new Carro(){ Id = 49 , CarroNome= " Vitae Sodales Limited               ", Valor = 8912 , Quantidade = 8  , DataVenda = DateTime.Parse(" 22/06/2019")},
new Carro(){ Id = 50 , CarroNome= " Tellus Sem Mollis Ltd               ", Valor = 9615 , Quantidade = 20 , DataVenda = DateTime.Parse(" 30/10/2019")},
new Carro(){ Id = 51 , CarroNome= " Nulla Tincidunt LLC                 ", Valor = 5562 , Quantidade = 19 , DataVenda = DateTime.Parse(" 22/09/2019")},
new Carro(){ Id = 52 , CarroNome= " Sed Dictum Institute                ", Valor = 9243 , Quantidade = 14 , DataVenda = DateTime.Parse(" 26/06/2019")},
new Carro(){ Id = 53 , CarroNome= " Sed Turpis Company                  ", Valor = 7243 , Quantidade = 14 , DataVenda = DateTime.Parse(" 20/08/2019")},
new Carro(){ Id = 54 , CarroNome= " Vitae Diam Proin Associates         ", Valor = 6631 , Quantidade = 2  , DataVenda = DateTime.Parse(" 10/06/2019")},
new Carro(){ Id = 55 , CarroNome= " Curabitur Inc.	                    ", Valor = 8090 , Quantidade = 3  , DataVenda = DateTime.Parse(" 09/02/2019")},
new Carro(){ Id = 56 , CarroNome= " Suscipit Est Ac LLC                 ", Valor = 8567 , Quantidade = 15 , DataVenda = DateTime.Parse(" 08/03/2019")},
new Carro(){ Id = 57 , CarroNome= " Neque Morbi Industries              ", Valor = 5171 , Quantidade = 1  , DataVenda = DateTime.Parse(" 03/10/2019")},
new Carro(){ Id = 58 , CarroNome= " Non Ltd                             ", Valor = 5102 , Quantidade = 19 , DataVenda = DateTime.Parse(" 14/08/2019")},
new Carro(){ Id = 59 , CarroNome= " Arcu Vestibulum Ante Institute      ", Valor = 6128 , Quantidade = 1  , DataVenda = DateTime.Parse(" 08/10/2019")},
new Carro(){ Id = 60 , CarroNome= " Nulla Foundation                    ", Valor = 7636 , Quantidade = 6  , DataVenda = DateTime.Parse(" 14/04/2019")},
new Carro(){ Id = 61 , CarroNome= " Quis Massa Mauris LLP               ", Valor = 5053 , Quantidade = 3  , DataVenda = DateTime.Parse(" 09/10/2019")},
new Carro(){ Id = 62 , CarroNome= " Ut Incorporated                     ", Valor = 6922 , Quantidade = 17 , DataVenda = DateTime.Parse(" 16/09/2019")},
new Carro(){ Id = 63 , CarroNome= " Aenean Egestas Corp.                ", Valor = 8142 , Quantidade = 19 , DataVenda = DateTime.Parse(" 17/11/2019")},
new Carro(){ Id = 64 , CarroNome= " Fusce Mi Lorem Consulting           ", Valor = 8312 , Quantidade = 20 , DataVenda = DateTime.Parse(" 19/11/2019")},
new Carro(){ Id = 65 , CarroNome= " A Sollicitudin Orci PC              ", Valor = 5864 , Quantidade = 1  , DataVenda = DateTime.Parse(" 20/03/2019")},
new Carro(){ Id = 66 , CarroNome= " Sociosqu Limited                    ", Valor = 5985 , Quantidade = 12 , DataVenda = DateTime.Parse(" 28/11/2019")},
new Carro(){ Id = 67 , CarroNome= " Ullamcorper Duis Cursus LLC         ", Valor = 5164 , Quantidade = 7  , DataVenda = DateTime.Parse(" 22/12/2019")},
new Carro(){ Id = 68 , CarroNome= " Nibh Lacinia LLC                    ", Valor = 7760 , Quantidade = 10 , DataVenda = DateTime.Parse(" 13/06/2019")},
new Carro(){ Id = 69 , CarroNome= " Eu Dui Institute                    ", Valor = 7695 , Quantidade = 8  , DataVenda = DateTime.Parse(" 12/12/2019")},
new Carro(){ Id = 70 , CarroNome= " Fringilla Purus Mauris Consulting   ", Valor = 5845 , Quantidade = 6  , DataVenda = DateTime.Parse(" 01/03/2019")},
new Carro(){ Id = 71 , CarroNome= " Donec Tempus Lorem Industries       ", Valor = 8472 , Quantidade = 19 , DataVenda = DateTime.Parse(" 09/03/2019")},
new Carro(){ Id = 72 , CarroNome= " Auctor Incorporated                 ", Valor = 6795 , Quantidade = 1  , DataVenda = DateTime.Parse(" 04/10/2019")},
new Carro(){ Id = 73 , CarroNome= " Enim Etiam Imperdiet Corporation    ", Valor = 6532 , Quantidade = 13 , DataVenda = DateTime.Parse(" 14/10/2019")},
new Carro(){ Id = 74 , CarroNome= " Non Cursus Non Industries           ", Valor = 9569 , Quantidade = 16 , DataVenda = DateTime.Parse(" 25/10/2019")},
new Carro(){ Id = 75 , CarroNome= " Ut Semper Incorporated              ", Valor = 5760 , Quantidade = 18 , DataVenda = DateTime.Parse(" 14/01/2019")},
new Carro(){ Id = 76 , CarroNome= " Sed Malesuada Corporation           ", Valor = 6561 , Quantidade = 4  , DataVenda = DateTime.Parse(" 06/03/2019")},
new Carro(){ Id = 77 , CarroNome= " Sed Neque Consulting                ", Valor = 7308 , Quantidade = 2  , DataVenda = DateTime.Parse(" 31/08/2019")},
new Carro(){ Id = 78 , CarroNome= " Nisl Arcu PC                        ", Valor = 7260 , Quantidade = 8  , DataVenda = DateTime.Parse(" 19/06/2019")},
new Carro(){ Id = 79 , CarroNome= " Euismod Est Consulting              ", Valor = 6020 , Quantidade = 11 , DataVenda = DateTime.Parse(" 27/10/2019")},
new Carro(){ Id = 80 , CarroNome= " Leo Vivamus Ltd                     ", Valor = 5055 , Quantidade = 8  , DataVenda = DateTime.Parse(" 22/10/2019")},
new Carro(){ Id = 81 , CarroNome= " Tristique Neque Inc.                ", Valor = 9268 , Quantidade = 13 , DataVenda = DateTime.Parse(" 25/02/2019")},
new Carro(){ Id = 82 , CarroNome= " In Lobortis PC                      ", Valor = 5539 , Quantidade = 4  , DataVenda = DateTime.Parse(" 18/12/2019")},
new Carro(){ Id = 83 , CarroNome= " Nunc Ltd                            ", Valor = 6846 , Quantidade = 2  , DataVenda = DateTime.Parse(" 09/10/2019")},
new Carro(){ Id = 84 , CarroNome= " Dictum Proin Limited                ", Valor = 5543 , Quantidade = 12 , DataVenda = DateTime.Parse(" 05/10/2019")},
new Carro(){ Id = 85 , CarroNome= " Erat Vitae LLP                      ", Valor = 5060 , Quantidade = 7  , DataVenda = DateTime.Parse(" 12/12/2019")},
new Carro(){ Id = 86 , CarroNome= " Pellentesque Ultricies Dignissim PC ", Valor = 7971 , Quantidade = 15 , DataVenda = DateTime.Parse(" 25/10/2019")},
new Carro(){ Id = 87 , CarroNome= " Phasellus Elit Company              ", Valor = 5350 , Quantidade = 15 , DataVenda = DateTime.Parse(" 31/10/2019")},
new Carro(){ Id = 88 , CarroNome= " Luctus Felis Ltd                    ", Valor = 9872 , Quantidade = 13 , DataVenda = DateTime.Parse(" 06/01/2019")},
new Carro(){ Id = 89 , CarroNome= " Dui Suspendisse PC                  ", Valor = 6878 , Quantidade = 7  , DataVenda = DateTime.Parse(" 06/02/2019")},
new Carro(){ Id = 90 , CarroNome= " Odio Associates                     ", Valor = 7636 , Quantidade = 18 , DataVenda = DateTime.Parse(" 24/07/2019")},
new Carro(){ Id = 91 , CarroNome= " Vel Company                         ", Valor = 7410 , Quantidade = 5  , DataVenda = DateTime.Parse(" 16/02/2019")},
new Carro(){ Id = 92 , CarroNome= " Lobortis Institute                  ", Valor = 5110 , Quantidade = 8  , DataVenda = DateTime.Parse(" 27/05/2019")},
new Carro(){ Id = 93 , CarroNome= " Scelerisque Company                 ", Valor = 7983 , Quantidade = 19 , DataVenda = DateTime.Parse(" 03/12/2019")},
new Carro(){ Id = 94 , CarroNome= " Posuere Enim Company                ", Valor = 6968 , Quantidade = 19 , DataVenda = DateTime.Parse(" 22/04/2019")},
new Carro(){ Id = 95 , CarroNome= " Sem Ut Corp.                        ", Valor = 6504 , Quantidade = 11 , DataVenda = DateTime.Parse(" 02/02/2019")},
new Carro(){ Id = 96 , CarroNome= " Dui Fusce Aliquam PC                ", Valor = 7837 , Quantidade = 2  , DataVenda = DateTime.Parse(" 08/12/2019")},
new Carro(){ Id = 97 , CarroNome= " Nisl Sem Industries                 ", Valor = 6835 , Quantidade = 5  , DataVenda = DateTime.Parse(" 14/11/2019")},
new Carro(){ Id = 98 , CarroNome= " Vitae Corp.	                    ", Valor = 7669 , Quantidade = 7  , DataVenda = DateTime.Parse(" 09/11/2019")},
new Carro(){ Id = 99 , CarroNome= " Malesuada Incorporated              ", Valor = 5960 , Quantidade = 4  , DataVenda = DateTime.Parse(" 26/09/2019")},
new Carro(){ Id = 100, CarroNome= " Mauris Ltd                          ", Valor = 8974 , Quantidade = 18 , DataVenda = DateTime.Parse(" 16/05/2019")}
            };

        }
}
}
