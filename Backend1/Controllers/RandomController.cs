using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Backend1.Services;
using Backend1.Models;

namespace Backend1.Controllers
{
    public class RandomController : Controller
    {
        private readonly IArithmetService arithmetService;
        private readonly IRandomService randomService;

        public RandomController(IArithmetService arithmetService, IRandomService randomService)
        {
            this.arithmetService = arithmetService;
            this.randomService = randomService;  

        }

        public ActionResult NumberUsingData()
        {
            var first1 = this.randomService.Rand(0, 10);
            this.ViewData["First"] = first1;
            var second1 = this.randomService.Rand(0, 10);
            this.ViewData["Second"] = second1;
            this.ViewData["Sum"]  = this.arithmetService.sum(first1, second1);
            if (second1 != 0)
                this.ViewData["Del"] = this.arithmetService.del(first1, second1);
            this.ViewData["Plus"] = this.arithmetService.plus(first1, second1);
            this.ViewData["Minus"] = this.arithmetService.minus(first1, second1);

            return this.View();
        }

        public ActionResult NumberUsingBag()
        {
            var first = this.randomService.Rand(0, 10);
            this.ViewBag.First = first;
            var second = this.randomService.Rand(0, 10);
            this.ViewBag.Second = second;
            this.ViewBag.Sum = this.arithmetService.sum(first, second);
            if (second != 0)
                this.ViewBag.Del = this.arithmetService.del(first, second);
            this.ViewBag.Plus = this.arithmetService.plus(first, second);
            this.ViewBag.Minus = this.arithmetService.minus(first, second);

            return this.View();
        }

        public ActionResult NumberUsingModel()
        {
            var first2 = this.randomService.Rand(0, 10);
            var second2 = this.randomService.Rand(0, 10);
            var sum = this.arithmetService.sum(first2, second2);
            var del = this.arithmetService.del(first2, second2);
            var plus = this.arithmetService.plus(first2, second2);
            var minus = this.arithmetService.minus(first2, second2);
            var model = new NumberViewModel
            {
                First = first2,
                Second = second2,
                Sum = sum,
                Del = del,
                Plus = plus,
                Minus = minus         

            };

            return this.View(model);
        }

        public ActionResult NumberAccessServiceDirectly()
        {
            return this.View();
        }
    }
}
