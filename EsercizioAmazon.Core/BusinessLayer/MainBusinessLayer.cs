using EsercizioAmazon.Core.Entities;
using EsercizioAmazon.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioAmazon.Core.BusinessLayer
{
    public class MainBusinessLayer : IMainBusinessLayer
    {
        private readonly IProdottoRepository prodottiRepo;
        public MainBusinessLayer(IProdottoRepository prodotti)
        {
            prodottiRepo = prodotti;
        }

        public string EliminaProdotto(string codiceProdottoDaEliminare)
        {
            Prodotto prodottoEsistente = prodottiRepo.GetByCode(codiceProdottoDaEliminare);
            if (prodottoEsistente == null)
            {
                return "Errore: Codice prodotto errato o non presente!!";
            }

            prodottiRepo.Delete(prodottoEsistente);

            return "Complimenti il prodotto è stato eliminato con successo!";
        }

        public List<Prodotto> GetAllProdotti()
        {
            return prodottiRepo.GetAll();
        }

        public string InserisciNuovoProdotto(Prodotto newProdotto)
        {
            var prodottoEsistente = prodottiRepo.GetByCode(newProdotto.Codice);

            if (prodottoEsistente != null)
            {
                return "Errore: Codice prodotto già presente!!";
            }
            prodottiRepo.Add(newProdotto);

            return "Prodotto aggiunto correttamente";
        }

        public string ModificaProdotto(string codiceProdottoDaModificare, string nuovaDescrizione, Tipo nuovaTipologia, decimal nuovoPrezzoPubblico)
        {
            Prodotto prodottoEsistente = prodottiRepo.GetByCode(codiceProdottoDaModificare);
            if (prodottoEsistente == null)
            {
                return "Errore: Codice Prodotto errato o non presente!!";
            }
            
            prodottoEsistente.Descrizione = nuovaDescrizione;
            prodottoEsistente._Tipologia = nuovaTipologia;
            prodottoEsistente.PrezzoPubblico = nuovoPrezzoPubblico;

            prodottiRepo.Update(prodottoEsistente);

            return "Congraturazioni il Prodotto è stato modificato con successo!";
        }
    }
}
