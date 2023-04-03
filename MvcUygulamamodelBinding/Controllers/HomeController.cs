using MvcUygulamamodelBinding.Models;
using MvcUygulamamodelBinding.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MvcUygulamamodelBinding.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Kisi kisi = new Kisi();
            kisi.ID = 1;
            kisi.Ad = "Umeyr";
            kisi.Soyad ="Gülçimen";
            kisi.Yas = 26;
            return View(kisi);
        }

        [HttpPost]
        public ActionResult Index(Kisi k)
        { 
            return View(k);
            
        }
        public ActionResult Homepage()
        {
          
        Kisi kisi =new Kisi();
            kisi.ID=1;
            kisi.Ad="Umeyr";
            kisi.Soyad="Gülçimen";
            kisi.Yas=26;

            Adres adres = new Adres();
            adres.AdresTanim ="Kadiköy";
            adres.sehir ="İstanbul";

            IndexView_model model = new IndexView_model();
            model.KisiTanim = kisi;
            model.kisiadres =adres;
            return View(model);
        }

        [HttpPost]
        public ActionResult HomePage(IndexView_model model)
        {
            return View(model);
        }

    }
}