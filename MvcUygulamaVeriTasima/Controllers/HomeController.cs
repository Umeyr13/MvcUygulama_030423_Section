using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcUygulamaVeriTasima.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewData["Text1"] = "Umeyr Gülçimen";
            ViewData["kontrol"] = true;

            //Farklı versiyon

            ViewBag.text1="Umeyr Gülçimen";

            ViewBag.kontrol=true;
            //liste istediği için 

            ViewBag.liste = new SelectListItem[]
            {
                new SelectListItem() { Text = "Umeyr" },
                new SelectListItem() { Text = "yakup" },
                new SelectListItem() { Text = "atakan" }
            };

            TempData["text2"] = ViewBag.text1;
            TempData["kontrol2"] = ViewBag.kontrol;
            TempData.Keep();
            return View();
        }
        public ActionResult blog()
        {
            ViewBag.text1   = TempData["text2"];
            ViewBag.kontrol = TempData["kontrol2"];
            TempData["list1"] = new SelectListItem[]
            {
                new SelectListItem(){ Text ="Umeyr",Value="u"},
                new SelectListItem(){ Text ="Deneme",Value="d"},
                new SelectListItem(){ Text ="şimdi oldu",Value="s"}    
            };

            ViewBag.list1 = TempData["list1"];
            TempData.Keep();        
            return View();

        }

        [HttpPost]
        public ActionResult blog(string text1,bool kontrol,string list1)
        {
           ViewBag.list1 = TempData["list1"];
            TempData.Keep();//veriyi diğer forma göndermek için tutma
            var d1 = Request.Form["text1"];//formdaki veriyi yakalama
            var d2 = Request.Form.GetValues("kontrol")[0];//true ve false ın ikisini de alır biz sadece seçili olanı getir dedik.
            var d3 = Request.Form["list1"];
            return View();
        }
    }
}