using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaBiblioteca
{
    public static class ListaCerveja
    {
        /// <summary>
        /// Método para listar as marcas de cerveja
        /// </summary>
        public static void Cervejas()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            var cerveja = new List<string>
            {
                "Skol","Budweiser","Brahma","Antarctica","Bohemia"
            };

            cerveja.ForEach(item => Console.WriteLine(item));

        }
       
    }
}
