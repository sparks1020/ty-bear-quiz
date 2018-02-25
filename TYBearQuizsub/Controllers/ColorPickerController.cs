using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TYBearQuiz.Database_files;
using System.Data;

namespace TYBearQuiz.Controllers
{
    public class ColorPickerController : Controller
    {
        public ActionResult Index()
        {
            using (var db = new BearQuizContext())
            {
                var model = db.Beanies.Where(b => b.Image != "" && string.IsNullOrEmpty(b.Color) && !b.Image.EndsWith("soon.jpg")).OrderBy(b => b.Name).FirstOrDefault();
                    
                if (model == null)
                {
                    return RedirectToAction("Index", "Home" );
                }
                return View(model);

            }



        }

        public ActionResult Picker(string AnswerColor)
        {
            using(var context = new BearQuizContext())
            {
                var model = context.Beanies.Where(b => b.Image != "" && string.IsNullOrEmpty(b.Color) && !b.Image.EndsWith("soon.jpg")).OrderBy(b => b.Name).FirstOrDefault();
                model.Color = AnswerColor;
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
