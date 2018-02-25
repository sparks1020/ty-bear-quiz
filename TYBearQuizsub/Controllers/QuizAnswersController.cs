using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TYBearQuiz.Database_files;
using TYBearQuiz.Models;

namespace TYBearQuiz.Controllers
{
    public class QuizAnswersController : Controller
    {
        public ActionResult Index()
        {
            Quiz answers = (Quiz)Session["quizAnswers"];
            return Match(answers);

        }

        public ActionResult Submit()
        {
            ViewData["Quiz Results"] = "We'll be right back with your results!";
            return View();
        }

        public ActionResult Match(Quiz answers)
        {
            using (var db = new BearQuizContext())
            {
                var answer = db.Beanies.Where(b=> string.Equals(b.Color, answers.color)).
                               Where(b=> string.Equals(b.Country, answers.country) || string.IsNullOrEmpty(b.Country))
                               .Where(b=>string.Equals(b.Animal, answers.animal)).First();
                return View(answer);
            }
        }

    }
}
