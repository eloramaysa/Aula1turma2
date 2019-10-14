using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoFlores.Model;
namespace BancoFlores.Controller
{
    public class FlorController
    {
        FlorContext florContext = new FlorContext();

        public IQueryable<Flor> GetFlores()
        {
            return florContext.Flores.OrderByDescending(x => x.Quantidade);
        }

        public int SomaFlores()
        {
            return florContext.Flores.Sum(x => x.Quantidade);
        }

        public bool AdicionarFlor(Flor item)
        {
            if (string.IsNullOrWhiteSpace(item.Nome)) return false;
            florContext.Flores.Add(item);
            florContext.SaveChanges();
            return true;
        }
    }
}
