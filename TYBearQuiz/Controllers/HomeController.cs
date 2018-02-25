using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace TYBearQuiz.Controllers
{
    public class StartQuiz : Controller
    {
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult Quiz()
        {
            return View("WebformQuestions");
        }

        public ActionResult Answer()
        {
            return View();

        }
    }
}
