using Microsoft.AspNetCore.Mvc;
using Who_wants_to_be_a_millionaire_show.Models;
using System.Linq;
using Microsoft.AspNetCore.Http;
//using System.Data.SqlClient;

namespace Who_wants_to_be_a_millionaire_show.Controllers
{
    [Route("question")]
    public class QuestionController : Controller
    {
        private QuEntities db = new QuEntities();

        [Route("index")]
        [Route("")]
        [Route("~/")]
        public IActionResult Index()
        {
            ViewBag.Questions = db.Questions.ToList();

            return View();
        }

        [HttpPost]
        [Route("submit")]
        public IActionResult Submit(IFormCollection iformCollection)
        {
            int score = 0;
            string[] questionIDs = iformCollection["QuestionId"];
            foreach (var QuestionId in questionIDs)
            {
                int answeridcorrect = db.Questions.Find(int.Parse
                (QuestionId)).Answers.Where(a => a.Correct == true).FirstOrDefault().IdAnswer;
                if (answeridcorrect == int.Parse(iformCollection["question_"
                    + QuestionId]))
                {
                    score++;
                }
            }
            ViewBag.score = score;
            return View("GameOver");
        }
    }
}
    