using EsercizioAmazon.Core.Entities;
using EsercizioAmazon.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EsercizioAmazon.MVC.Helper
{
    public static class Mapping
    {
        public static ProdottoViewModel ToProdottoViewModel(this Prodotto prodotto)
        {
            return new ProdottoViewModel
            {
                Codice = prodotto.Codice,
                Descrizione = prodotto.Descrizione,
                _Tipo = (Models.Tipologia)(int)prodotto._Tipo,
                PrezzoPubblico = prodotto.PrezzoPubblico,
                PrezzoFornitore = prodotto.PrezzoFornitore
            };
        }

        public static Prodotto ToProdotto(this ProdottoViewModel prodottoViewModel)
        {
            return new Prodotto
            {
                Codice = prodottoViewModel.Codice,
                Descrizione = prodottoViewModel.Descrizione,
                _Tipo = (Models.Tipologia)(int)prodottoViewModel._Tipo,
                PrezzoPubblico = prodottoViewModel.PrezzoPubblico,
                PrezzoFornitore = prodottoViewModel.PrezzoFornitore
            };
        }
    }
}
