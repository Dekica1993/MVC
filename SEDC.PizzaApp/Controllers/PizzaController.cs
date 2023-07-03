using System;
using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Models.Domain;

namespace SEDC.PizzaApp.Controllers
{
	public class PizzaController : Controller
	{
		public IActionResult GetPizzas()
		{
			var pizzas = StaticDb.Pizzas;

			return View(pizzas);

		}

	public IActionResult Details(int? Id)
		{
			if (Id == null)
			{
				return RedirectToAction("Error");

			}

			Pizza pizza = StaticDb.Pizzas.FirstOrDefault(pizza => pizza.Id == Id);

			if (pizza == null)
			{
				return RedirectToAction("Error");
			}
			return View(pizza);
		}

		public IActionResult Error()
		{
			return View();
		}

		public IActionResult Index()
		{
			var pizza = StaticDb.Pizzas;

			return View(pizza);
		}

	}
}

