using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaBiblioteca
{
    public static class ListaCarros
    {
        /// <summary>
        /// Metodo para listar marcas de carros
        /// </summary>
        public static void Carros()
        {
            Console.ForegroundColor = ConsoleColor.Red;

            var carros = new List<string>
            {
                "Volkswagen","Honda","Toyota","FIAT","Ford","Hyundai","Audi","Chevrolet","Renault"
            };

            carros.ForEach(item => Console.WriteLine(item));
        }
    }
}
