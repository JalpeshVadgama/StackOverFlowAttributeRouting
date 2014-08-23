using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using StackOverFlowRouting.Models;

namespace StackOverFlowRouting.Controllers
{
    public class QuestionController : Controller
    {
        private readonly List<Question> _questions;
        public QuestionController()
        {
            _questions = new List<Question>
                        {
                            new Question {QuestionId=1,
                                           Title="Title of first question",
                                           Description="Description of first question"},
                            new Question {QuestionId=1,
                                           Title="Title of second question",
                                           Description="Description of second question"}
                        };
        }
        // GET: Question
        public ActionResult Index()
        {
            return View(_questions);
        }

        // GET: Question/Details/5
        [Route("Question/{id}/{*title}")]
        public ActionResult Details(int id)
        {
            var question = _questions.FirstOrDefault(q => q.QuestionId == id);
            return View(question);
        }
    }
}
