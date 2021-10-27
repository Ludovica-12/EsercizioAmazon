using EsercizioAmazon.Core.BusinessLayer;
using EsercizioAmazon.MVC.Helper;
using EsercizioAmazon.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EsercizioAmazon.MVC.Controllers
{
    public class ProdottiController : Controller
    {
        private readonly IMainBusinessLayer MainBL;
        public ProdottiController(IMainBusinessLayer mainBL)
        {
            MainBL = mainBL;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var prodotti = MainBL.GetAllProdotti();

            List<ProdottoViewModel> prodottiViewModel = new List<ProdottoViewModel>();

            foreach (var item in prodotti)
            {
                prodottiViewModel.Add(item.ToProdottoViewModel());
            }

            return View(prodottiViewModel);
        }

        [HttpGet("Prodotti/Details/{codice}")]
        public IActionResult Details(string code)
        {
            var prodotto = MainBL.GetAllProdotti().FirstOrDefault(p => p.Codice == code);

            var prodottoViewModel = prodotto.ToProdottoViewModel();

            return View(prodottoViewModel);
        }

        #region Create

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ProdottoViewModel prodottoViewModel)
        {
            if (ModelState.IsValid)
            {
                var prodotto = prodottoViewModel.ToProdotto();
                MainBL.InserisciNuovoProdotto(prodotto);
                return RedirectToAction(nameof(Index))
;
            }
            return View(prodottoViewModel);
        }
        #endregion

        #region Edit

        [HttpGet]
        public IActionResult Edit(string id)
        {
            var prodotto = MainBL.GetAllProdotti().FirstOrDefault(p => p.Codice == id);
            var prodottoViewModel = prodotto.ToProdottoViewModel();
            return View(prodottoViewModel);
        }

        [HttpPost]
        public IActionResult Edit(ProdottoViewModel prodottoViewModel)
        {
            if (ModelState.IsValid)
            {
                var prodotto = prodottoViewModel.ToProdotto();
                MainBL.ModificaProdotto(prodotto.Codice, prodotto.Descrizione, prodotto._Tipologia,prodotto.PrezzoPubblico);
                return RedirectToAction(nameof(Index));
            }
            return View(prodottoViewModel);

        }
        #endregion

        #region Delete
        [HttpGet]
        public IActionResult Delete(string id)
        {
            var prodotto = MainBL.GetAllProdotti().FirstOrDefault(p => p.Codice == id);
            var prodottoViewModel = prodotto.ToProdottoViewModel();
            return View(prodottoViewModel);
        }

        [HttpPost]
        public IActionResult Delete(ProdottoViewModel prodottoViewModel)
        {
            if (ModelState.IsValid)
            {
                var prodotto = prodottoViewModel.ToProdotto();
                MainBL.EliminaProdotto(prodotto.Codice);
                return RedirectToAction(nameof(Index));
            }
            return View(prodottoViewModel);
        }
        #endregion
    }
}
