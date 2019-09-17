using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ForeachNaLista
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaDeDecimais();
            Console.ReadKey();
        }
        /// <summary>
        /// Metodo para listar numeros inteiros
        /// </summary>
        private static void ListaNumerosInteiros()
        {
            var minhaLista = new List<int>();
            for (int i = 10; i < 21; i++) minhaLista.Add(i);
            minhaLista.ForEach(i => Console.WriteLine(i));
        }
        /// <summary>
        /// Metodo para adicionar datas em lista 
        /// </summary>
        private static void ListaDateTime()
        {
            var minhaLista = new List<DateTime>();
            minhaLista.Add(new DateTime(2019, 9, 17));
            minhaLista.Add(new DateTime(2019, 9, 18));
            minhaLista.Add(new DateTime(2019, 9, 19));
            minhaLista.Add(new DateTime(2019, 9, 20));
            minhaLista.ForEach(minhaData => Console.WriteLine(minhaData.ToString("yy/MMMMM/dd")));

        }
        /// <summary>
        /// Metodo para adicionar string numa lista 
        /// </summary>
        private static void ListaString()
        {
            var minhaLista = new List<string>();
            minhaLista.Add("XIAOMI");
            minhaLista.Add("IPHONE APPLE");
            minhaLista.Add("SAMSUNG");
            minhaLista.Add("NOKIA");
            //expressão lambda exemplo, substitui a expressão tradicional de foreach 
            minhaLista.ForEach(i => Console.WriteLine(i));


        }
        /// <summary>
        /// Metodo para adicionar e listar decimais numa lista
        /// </summary>
        private static void ListaDeDecimais() {
            var minhaLista = new List<double>();
            minhaLista.Add(3.75);
            minhaLista.Add(4.98);
            minhaLista.Add(2.42);
            minhaLista.Add(0.05);
            minhaLista.ForEach(meuDecimal => Console.WriteLine("\nMeus valores: \nReal: " + meuDecimal.ToString("C") + "\nDólar: " + FormataNumeroDecimalMoeda(meuDecimal, "en-US", 4.5008) + "\nYen: " + FormataNumeroDecimalMoeda(meuDecimal, "ja-JP", 0.038) + "\nEuro: " + FormataNumeroDecimalMoeda(meuDecimal, "en-US", 4.53).Replace("$", "Euro ") + "\nBitCoin: BTC " + FormataNumeroDecimalParaBitCoin(meuDecimal, 41793.27)));  }
        /// <summary>
        /// Metodo para converter o valor para outras moedas
        /// </summary>
        /// <param name="meuNumero"></param>
        /// <param name="culture"></param>
        /// <param name="diferença"></param>
        /// <returns>Retorna o valor convertido </returns>
        private static string FormataNumeroDecimalMoeda(double meuNumero, string culture, double diferença) { 
            return (meuNumero / diferença).ToString("C3", CultureInfo.CreateSpecificCulture(culture));}
        /// <summary>
        /// Metodo para converter o valor para BitCoin
        /// </summary>
        /// <param name="meuNumero"></param>
        /// <param name="diferença"></param>
        /// <returns>Retorna o valor convertido</returns>
        private static string FormataNumeroDecimalParaBitCoin(double meuNumero, double diferença) {
            return (meuNumero / diferença).ToString(); }
    }
}
