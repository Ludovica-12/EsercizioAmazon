using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioAmazon.Core.Entities
{
    public class Prodotto
    {
        public string Codice { get; set; }
        public string Descrizione { get; set; }
        public Tipo _Tipologia { get; set; }
        public decimal PrezzoPubblico { get; set; }
        public decimal PrezzoFornitore { get; set; }
    }

    public enum Tipo
    {
        Elettronica,
        Abbigliamento,
        Casalinghi
    }
}
