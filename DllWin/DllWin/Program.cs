using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DllPastaWin;
namespace DllWin
{
    class Program
    {
        static DocumentsAutoGenerate autoGenerate = new DocumentsAutoGenerate();
        static HoraDoShow doShow = new HoraDoShow();
        static void Main(string[] args)
        {
            //autoGenerate.CriarPastaMeusDocumentos("pastaTeste");
            autoGenerate.DeletarPastaMeusDocumentos("pastaElora", true);
            autoGenerate.ObterPastasDiretorioMeuDocumentos().ForEach(i => Console.WriteLine(i));
           
            doShow.Birllllllllll();
            Console.ReadKey();

        }
    }
}
