using AmigosFixo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigosFixo
{
    class Program
    {
        static void Main(string[] args)
        {

            var listaAmigos = new List<Amigo>
            {
                new Amigo()
                {
                    Nome="Adriele",
                    TempoAmizade= 15
                },
                new Amigo()
                {
                    Nome="Debora",
                    TempoAmizade=4
                },
                new Amigo()
                {
                    Nome="Kenndra",
                    TempoAmizade= 7
                }
            };
            //Propriedade que vai listar todos os amigos armazenados na lista de amizade
            listaAmigos.ForEach(i => Console.WriteLine($"Nome: {i.Nome} Tempo de amizade: {i.TempoAmizade} anos"));
            Console.ReadKey();
        }
    }
}
