using EsercizioAmazon.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioAmazon.Core.BusinessLayer
{
    public interface  IMainBusinessLayer
    {
        public List<Prodotto> GetAllProdotti();
        public string InserisciNuovoProdotto(Prodotto newProdotto);
        public string ModificaProdotto(string codiceProdottoDaModificare, string nuovaDescrizione, Tipo nuovaTipologia, decimal PrezzoProdotto);
        public string EliminaProdotto(string codiceProdottoDaEliminare);
    }
}
