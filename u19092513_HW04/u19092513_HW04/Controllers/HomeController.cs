using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using u19092513_HW04.Models;

namespace u19092513_HW04.Controllers
{
    public class HomeController : Controller
    {

        public static List<Donation> Donations = new List<Donation>();
        public ActionResult Index()
        {
            return View(Donations);
        }

       
        [HttpGet]
        public ActionResult Donate()
        {
            return View(); 
        }

        [HttpPost]
        public ActionResult Donate(string desc, string cond,string date, string details, int type, int ? quantity, int ? costofpurchase, int ? total, int ? weight, int ? number, HttpPostedFileBase File)
        {
            if (type == 1)
            {
                Clothing newC = new Clothing(desc, cond, date, details, Convert.ToInt32(quantity), Convert.ToInt32(costofpurchase));

                Donations.Add(newC);
            }

            else if (type == 2)
            {
                Money newM = new Money(desc, cond, date, details, Convert.ToInt32(total));

                Donations.Add(newM);
            }

            else if (type == 3)
            {
                Food newF = new Food(desc, cond, date,details, Convert.ToInt32(weight), Convert.ToInt32(number));

                Donations.Add(newF);
            }

            if (File != null && File.ContentLength > 0)
            {
                var fileName = Path.GetFileName(File.FileName);

                var path = Path.Combine(Server.MapPath("~/App_Data/uploads"), fileName);

                File.SaveAs(path);

            }
            

            return RedirectToAction("Index");
        }

        public ActionResult Usecase()
        {
            String path = Server.MapPath("~/App_Data/");
            String[] imagesfiles = Directory.GetFiles(path);
            ViewBag.images = imagesfiles;
            return View();
        }
        






    }
}