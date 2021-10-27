using EsercizioAmazon.Core.Entities;
using EsercizioAmazon.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioAmazon.EF.RepositoryEF
{
    public class RepositoryProdottiEF : IProdottoRepository
    {
        public Prodotto Add(Prodotto item)
        {
            using (var ctx = new AmazonContext())
            {
                ctx.Prodotti.Add(item);
                ctx.SaveChanges();
            }
            return item;
        }

        public bool Delete(Prodotto item)
        {
            using (var ctx = new AmazonContext())
            {
                ctx.Prodotti.Remove(item);
                ctx.SaveChanges();
            }
            return true;
        }

        public List<Prodotto> GetAll()
        {
            using (var ctx = new AmazonContext())
            {
                return ctx.Prodotti.ToList();
            }
        }

        public Prodotto GetByCode(string item)
        {
            using (var ctx = new AmazonContext())
            {
                return ctx.Prodotti.FirstOrDefault(p => p.Codice == item);
            }
        }

        public Prodotto Update(Prodotto item)
        {
            using (var ctx = new AmazonContext())
            {
                ctx.Prodotti.Update(item);
                ctx.SaveChanges();
            }
            return item;
        }
    }
}
