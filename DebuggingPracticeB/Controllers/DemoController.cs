using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace HttpPractice.Controllers
{
    public class DemoController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PageTwo(string mascot)
        {
            ViewBag.Mascott = mascot;
            return View();
        }

        public IActionResult PageThree()
        {
            return View();
        }

        public IActionResult Quiz1()
        {
            Random rand = new Random();
            ViewBag.Number1 = rand.Next(100);
            ViewBag.Number2 = rand.Next(100);
            return View();
        }

        public IActionResult Quiz1Answer(int number1, int number2, int answer)
        {
            string check = "wrong :-(";
            if (number1 + number2 == answer)
                check = "right!";
            return Content(check);
        }


        [HttpGet]
        public IActionResult Quiz2()
        {
            Random rand = new Random();
            List<int> numbers = new List<int>();
            numbers.Add(rand.Next(10));
            numbers.Add(rand.Next(10));
            return View(numbers);
        }

        [HttpPost]
        public IActionResult Quiz2(int number1, int number2, int answer)
        {
            string check = "wrong :-(";
            if (number1 * number2 == answer)
                check = "right!";
            return Content(check);
        }


    }
}
