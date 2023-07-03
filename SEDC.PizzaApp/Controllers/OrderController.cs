<<<<<<< HEAD
﻿using System;
using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Models.Domain;
using SEDC.PizzaApp.Models.Enums;
using SEDC.PizzaApp.Models.View;
using SEDC.PizzaApp.ViewModels;
=======
﻿
using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Mappers;
using SEDC.PizzaApp.Models.Domain;
using SEDC.PizzaApp.Models.viewModel;
using System.Data;

>>>>>>> 9ec4d26 (first commit)

namespace SEDC.PizzaApp.Controllers
{
	public class OrderController : Controller
	{
		public IActionResult Index()
		{
<<<<<<< HEAD
			return View();
=======
			List<Order> ordersFromDb = StaticDb.Orders;

			List<OrderListViewModel> orderViewModels = ordersFromDb.Select(order => order.ToOrderListViewModel())
				.ToList();

			ViewBag.NumberOfOrders = orderViewModels.Count;
			ViewBag.Date = DateTime.Now.ToShortDateString();
			ViewBag.FirstUser = StaticDb.Orders.First().User;

			return View(orderViewModels);

>>>>>>> 9ec4d26 (first commit)
		}

		public IActionResult Details(int? Id)
		{
		if (Id == null)
			{
<<<<<<< HEAD
				return new EmptyResult();
=======
				return RedirectToAction("Error", "Pizza");
>>>>>>> 9ec4d26 (first commit)
			}

			Order order = StaticDb.Orders.FirstOrDefault(order => order.Id == Id);

			if(order == null)
			{
<<<<<<< HEAD
				return new EmptyResult();
			}

			return View(order);
=======
				return RedirectToAction("Error", "Pizza");
			}
			OrderDetailsViewModel viewModel = order.ToOrderDetailsViewModel();
			return View(viewModel);
>>>>>>> 9ec4d26 (first commit)
		}

		[Route("json")]
		public IActionResult GetJson()
		{
			Pizza pizza = new Pizza
			{
				Id = 2,
				Name = "Kapricioza",
				Price = 350,
				IsOnPromotion = false

			};
			return new JsonResult(pizza);
		}

		public IActionResult Redirect()
		{
			return RedirectToAction("Index");
		}

<<<<<<< HEAD
		public IActionResult OrderDetailsViewModel()
		{
		  var user = new User
			{
				Id = 4,
				FirstName = "Dejan",
				LastName = "Mladenov",
				PhoneNumber = "436721"

			};

			var order = new Order
			{
				Id = 5,
				PizzaId = 1,
				UserId = 3,
				UserAdress = "Hristo Tatarcev 62 2/6"
			};


			var ViewModel = new OrderViewDetailsModels
			{
				User = user,
				Order = order
			};

			return View(ViewModel);


        }

		public IActionResult PizzaViewModel()
		{
			var pizza = new Pizza
			{
				Id = 3,
				Name = "Margarira",
				Price = 200,
				IsOnPromotion = false,
				PizzaSize = PizzaSize.Family
			};

			var pizzas = new PizzaViewModel
			{
				Id = 1,
				Name = "Quatro formagio",
				Price = 500,
				PizzaSize = PizzaSize.Normal
			};

			var PizzaView = new PizzaViewMapper
			{
				Pizza = pizza,

				PizzaViewModel = pizzas
			};

			return View(PizzaView);

		}

=======
		
		public IActionResult Delete(int? Id)
		{
			if(Id == null)
			{
				return new EmptyResult();
			}

			Order order = StaticDb.Orders.FirstOrDefault(order => order.Id == Id);

			if(order == null)
			{
				return new EmptyResult();

			}
			OrderDetailsViewModel viewModel = order.ToOrderDetailsViewModel();
			return View(viewModel);
		}

		public IActionResult ConfirmDelete(int? Id)
		{
			if(Id == null)
			{
				return new EmptyResult();
			}

			Order order = StaticDb.Orders.FirstOrDefault(order => order.Id == Id);

			if(order == null)
			{
				return new EmptyResult();
			}

			StaticDb.Orders.Remove(order);
			return RedirectToAction("Index");
		}

		[HttpGet]
		public IActionResult CreateOrder()
		{
			OrderViewModel viewModel = new OrderViewModel();

			return View(viewModel);
		}

		[HttpPost]
		public IActionResult CreateOrderPost(OrderViewModel viewModel)
		{
			return RedirectToAction("Index");
		}



>>>>>>> 9ec4d26 (first commit)
		
	}
}

