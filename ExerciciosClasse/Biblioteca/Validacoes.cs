using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class Validacoes
    {
        public static char ValidaChar(string mensagem)
        {
            char caracter = ' ';
            try
            {
                Console.WriteLine(mensagem);
                caracter = char.Parse(Console.ReadLine().ToUpper());

            }
            catch
            {
                caracter = ValidaChar(mensagem);
            }
            return caracter;
        }
        /// <summary>
        /// Metodo para validar um numero decimal 
        /// </summary>
        /// <param name="mensagem"></param>
        /// <returns></returns>
        public static double ValidaDouble(string mensagem)
        {
            double valor = 0.0;
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
        /// Metodo para validar um numero inteiro 
        /// </summary>
        /// <param name="mensagem"></param>
        /// <returns></returns>
        public static int ValidaInt(string mensagem)
        {
            var valor = 0;
            try
            {
                Console.WriteLine(mensagem);
                valor = int.Parse(Console.ReadLine());
            }
            catch
            {
                valor = ValidaInt(mensagem);
            }
            return valor;
        }
        /// <summary>
        /// Metodo para validar CPF
        /// </summary>
        /// <param name="vrCPF"></param>
        /// <returns></returns>
        public static bool ValidaCPF(string vrCPF)
        {
            {
                //Analisar codigo 
                string valor = vrCPF.Replace(".", "");

                valor = valor.Replace("-", "");



                if (valor.Length != 11)

                    return false;



                bool igual = true;

                for (int i = 1; i < 11 && igual; i++)

                    if (valor[i] != valor[0])

                        igual = false;



                if (igual || valor == "12345678909")

                    return false;



                int[] numeros = new int[11];



                for (int i = 0; i < 11; i++)

                    numeros[i] = int.Parse(

                      valor[i].ToString());



                int soma = 0;

                for (int i = 0; i < 9; i++)

                    soma += (10 - i) * numeros[i];



                int resultado = soma % 11;



                if (resultado == 1 || resultado == 0)

                {

                    if (numeros[9] != 0)

                        return false;

                }

                else if (numeros[9] != 11 - resultado)

                    return false;



                soma = 0;

                for (int i = 0; i < 10; i++)

                    soma += (11 - i) * numeros[i];



                resultado = soma % 11;



                if (resultado == 1 || resultado == 0)

                {

                    if (numeros[10] != 0)

                        return false;

                }

                else

                    if (numeros[10] != 11 - resultado)

                    return false;



                return true;

            }

        }
    }
}
