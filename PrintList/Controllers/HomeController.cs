using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrintList.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //var prints="";
            //foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            //{
            //    prints = printer;
            //    Print(printer);
            //}
            return View();
        }
        public void Print(string printer)
        {
            var doc = new PrintDocument();
            doc.PrinterSettings.PrinterName = printer;
            doc.PrintPage += new PrintPageEventHandler(ProvideContent);
            //doc.PrintPage += new PrintPageEventHandler(ProvideContent);
            doc.Print();
        }
        public void ProvideContent(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(
              "Hello world",
              new Font("Arial", 12),
              Brushes.Black,
              e.MarginBounds.Left,
              e.MarginBounds.Top);
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
    }
}