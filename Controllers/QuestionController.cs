using Microsoft.AspNetCore.Mvc;
using Who_wants_to_be_a_millionaire_show.Models;
using System.Linq;
using Microsoft.AspNetCore.Http;

namespace Who_wants_to_be_a_millionaire_show.Controllers
{
    [Route("question")]
    public class QuestionController : Controller
    {
        private QuEntities db = new QuEntities();
        //Переменные для реализации пагинации
        //int QuestionNum = 0;
        //private int QuestionSize = 1;

        [Route("index")]
        [Route("")]
        [Route("~/")]
        public IActionResult Index()
        {
            ViewBag.Questions = db.Questions.ToList();
            //Настройка вывода постранчного вывода (структура вопрос-ответ)
            //ViewData["QuestionNum"] = QuestionNum;
            //ViewBag.Questions = (from Question in db.Questions orderby Question.IdQuestion select Question).
            //Skip(QuestionSize * QuestionNum).Take(QuestionSize).ToList();
            return View();
        }

        [HttpPost]
        [Route("submit")]
        public IActionResult Submit(IFormCollection iformCollection)
        {
            int score = 100;
            string[] questionIDs = iformCollection["QuestionId"];
            foreach (var QuestionId in questionIDs)
            {
                int answeridcorrect = db.Questions.Find(int.Parse
                (QuestionId)).Answers.Where(a => a.Correct == true).FirstOrDefault().IdAnswer;
                if (answeridcorrect == int.Parse(iformCollection["question_"
                    + QuestionId]))
                {
                    score = score * 2;
                }
                else
                {
                    //условие проигрыша
                    //score = 0;
                }
            }
            ViewBag.score = score;
            return View("GameOver");
        }
    }
}
    