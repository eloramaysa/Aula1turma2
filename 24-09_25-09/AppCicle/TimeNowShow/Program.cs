using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TimeNowShow
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Hora Atual: {DateTime.Now.ToString("HH:mm:ss.ffff")}");
                //Quando vc não esta usando uma classe e quer ativar ela, digita o método + ctrl +. e depois para usar enter+ ctrl + .
                // O valor dentro () é o tempo em milisegundos que vc quer deixar o relógio parado. 
                Thread.Sleep(1000);

            }
        }
    }
}
