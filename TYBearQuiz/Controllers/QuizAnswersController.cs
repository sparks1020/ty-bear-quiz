using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TYBearQuiz.Controllers
{
    public class QuizAnswers : Controller
    {
        public ActionResult Index()
        {
            return View ();
        }

        public ActionResult Intake()
        {
           // take in answers from view
           // store in a list, return a list
        }

        public ActionResult Match()
        {
            //match List from Intake to database columns
            // some if statements
            //combine results from statements
            //return results from statements
        }

    }
}
