using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Blog.Service;
using Blog.Models;

namespace Blog.Controllers
{
    public class HomeController : Controller
    {
        public TopicService _topicService = new TopicService();
        public HomeController()
        {

        }

        public HomeController(TopicService topicService)
        {
            _topicService = topicService;
        }

        public ActionResult Index()
        {
            Topic model = _topicService.GetLasted();
            ViewBag.MoreTopics = _topicService.GetMore(model.Id);
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}