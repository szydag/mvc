using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace hafta_1_app.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult HtmlTags()
        {

            return View();
        }

        public ActionResult FormElements()
        {
            return View();
        }


        public ActionResult FormTest(string textReturn,string o)
        {
            ViewBag.model = textReturn+"-"+o;
            return View();
        }

        [HttpPost]
        public ActionResult formPost(string hidden_value,string text1,string text2,int select1,int radio_btn, int[] check_btn) 
        {
            string model = "POST METHOD:" + hidden_value +"-"+text1+"-"+text2+"-rd: "+radio_btn.ToString()+"- ch:"+check_btn[0];


            return RedirectToAction("FormTest", new { textReturn = model });
        }

        public ActionResult formGet(string hidden_value, string text1, string text2, int select1, int radio_btn, int[] check_btn)
        {
            string model = "GET METHOD:"+hidden_value + "-" + text1 + "-" + text2 + "-rd: " + radio_btn.ToString() + "- ch:" + check_btn[0];


            return RedirectToAction("FormTest", new { textReturn = model });
        }
    }
}