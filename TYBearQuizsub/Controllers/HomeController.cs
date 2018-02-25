using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using TYBearQuiz.Models;

namespace TYBearQuiz.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() 
        {
            ViewData ["project title"] = "TY Bear Quiz";
            return View();
        }

        public ActionResult Quiz()
        {
            return View("WebformQuestions");
        }

        [HttpPost]
        public ActionResult Quiz(Quiz answers)
        {
            Session["quizAnswers"] = answers;
            return RedirectToAction("Index", "QuizAnswers");
        }

        public ActionResult Answer()
        {
            return View();

        }
    }
}
