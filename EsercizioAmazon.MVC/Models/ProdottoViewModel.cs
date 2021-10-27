using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EsercizioAmazon.MVC.Models
{
    public class ProdottoViewModel
    {

        [Required]
        [DisplayName("Codice Prodotto")]
        public string Codice { get; set; }
        [Required]
        [DisplayName("Descrizione Prodotto")]
        public string Descrizione { get; set; }
        [Required]
        [DisplayName("Tipologia Prodotto")]
        public Tipologia _Tipo { get; set; }
        [Required]
        [DisplayName("Prezzo al Pubblico")]
        public decimal PrezzoPubblico { get; set; }
        [Required]
        [DisplayName("Prezzo Fornitore")]
        public decimal PrezzoFornitore { get; set; }
    }
    public enum Tipologia
    {
        Elettronica,
        Abbigliamento,
        Casalinghi
    }
}
