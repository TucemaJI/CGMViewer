using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CGM2SVG;
using CGM.Scanner;

namespace CGMViewer.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      CGM2SVG.CGM2SVG cgmContex = new CGM2SVG.CGM2SVG(@"C:\Users\sergkondrashov\Desktop\ICN-S1000DBIKE-AAA-DA24000-0-C0419-12345-A-04-1.CGM");

      cgmContex.Run();
      var xml = cgmContex.GetSVGString();
      ViewBag.Title = "Home Page";

      return View();
    }
  }
}
