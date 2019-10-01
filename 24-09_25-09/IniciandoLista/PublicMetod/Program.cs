using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicMetod
{
    public class Program
    {
        static void Main(string[] args)
        {
            ConversorDeMoeda();

        }
        /// <summary>
        /// Metodo que da inicio a conversão de moedas
        /// </summary>
        public static void ConversorDeMoeda()
        {
            Console.WriteLine("Sistema conversor de moedas");
            var mensagemValor = "Informe um valor a ser convertido:";
            var valorASerConvertido = ValidaDouble(mensagemValor);
            var moeda = Mensagem();
            ConvertMoeda(valorASerConvertido, moeda);
            Console.WriteLine("Deseja converter para mais alguma moeda? Sim: 1, Não: Qualquer tecla");
            while (int.Parse(Console.ReadKey().KeyChar.ToString()) == 1)
            {
                var mensagemvalor = "Informe um valor a ser convertido:";
                var valorSerConvertido = ValidaDouble(mensagemvalor);
                var moeda2 = Mensagem();
                ConvertMoeda(valorSerConvertido, moeda2);
                Console.WriteLine("Deseja converter para mais alguma moeda? Sim: 1, Não: Qualquer tecla");
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Metodo para receber o valor e validar
        /// </summary>
        /// <param name="mensagem"></param>
        /// <returns></returns>
        public static double ValidaDouble(string mensagem)
        {
            var valor = 0.0;
            try
            {
                Console.WriteLine(mensagem);
                valor = double.Parse(Console.ReadLine());   
            }
            catch 
            {
                valor = ValidaDouble(mensagem);
            }
            return valor;
        }
        /// <summary>
        /// Metodo para receber o tipo de moeda e validar
        /// </summary>
        /// <returns></returns>
        public static string Mensagem()
        {

            Console.WriteLine("Informe uma moeda para conversão:");
            Console.WriteLine("Euro, Dolar, Yen, BTC");
            var resposta = Console.ReadLine();

            switch (resposta)
            {
                case "Euro":
                    return resposta;
                case "Dolar":
                    return resposta;
                case "Yen":
                    return resposta;
                case "BTC":
                    return resposta;
                default:
                    return Mensagem();
            }

        }
        /// <summary>
        /// Metodo que converte moeda em real para um alvo especificado 
        /// para converter digite os alvos:
        ///"Euro"
        ///"Yen"
        ///"BTC"
        ///"Dolar"
        /// </summary>
        /// <param name="minhaMoeda"></param>
        /// <param name="moedaAlvo"></param>
        public static void ConvertMoeda(double minhaMoeda, string moedaAlvo)
        {

            switch (moedaAlvo)
            {
                case "Dolar":
                    Console.WriteLine(FormataNumeroDecimalMoeda(minhaMoeda, 4.50008, "en-US"));
                    break;
                case "Euro":
                    Console.WriteLine(FormataNumeroDecimalMoeda(minhaMoeda, 4.53, "en-US").Replace("$", "Euro "));
                    break;
                case "Yen":
                    Console.WriteLine(FormataNumeroDecimalMoeda(minhaMoeda, 0.038, "ja-JP"));
                    break;
                case "BTC":
                    Console.WriteLine(FormataNumeroBTC(minhaMoeda, 41793.27));
                    break;
            }
            
           
        }
        /// <summary>
        /// Metodo que converte real para outras moedas
        /// </summary>
        /// <param name="meuNumero"></param>
        /// <returns>Retorna o valor formatado </returns>
        public static string FormataNumeroDecimalMoeda(double meuNumero, double diferenca, string culture)
        {
            return (meuNumero / diferenca).ToString("C2", CultureInfo.CreateSpecificCulture(culture));
        }
        /// <summary>
        /// Metodo que converte real para BTC 
        /// </summary>
        /// <param name="meuNumero"></param>
        /// <param name="diferença"></param>
        /// <returns></returns>
        public static string FormataNumeroBTC (double meuNumero, double diferença)
        {
            return (meuNumero / diferença).ToString();
        }
    }
}
