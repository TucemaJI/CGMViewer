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
      CGM2SVG.CGM2SVG cgmContex = new CGM2SVG.CGM2SVG(@"D:\CGMs\ICN-BD700-A-J212301-G-3AB48-03702-A-001-01.CGM");

      cgmContex.Run();
      var xml = cgmContex.GetSVGString();
      ViewBag.Title = "Home Page";

      return View();
    }
  }
}
