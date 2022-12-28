using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web2.Controllers
{
	public class AboutUsController : Controller
	{
		// GET: AboutUs
		public ActionResult Index()
		{
			Models.User u = new Models.User();
			u.FirstName = "El bachir";
			u.LastName = " El fouiresse";
			u.Email = "bafo6690@gmail.com";
			return View(u);
		}
		[HttpPost]
		public ActionResult Index(FormCollection col)
		{
			
			if (col["btnSubmit"].ToString() == "Close") {

				return RedirectToAction("Index", "Home");
			}
			if (col["btnSubmit"].ToString() == "More") {

				return RedirectToAction("More");
			}
			return View();
	
		}

		public ActionResult More()
		{
			Models.User u = new Models.User();
			u.FirstName = "El bachir";
			u.LastName = " El fouiresse";
			return View(u);
		
		}
		[HttpPost]
		public ActionResult More(FormCollection col)
		{
			if (col["btnSubmit"].ToString() == "Close") {

				return RedirectToAction("Index");
			}
			return View();

		}

	}
}