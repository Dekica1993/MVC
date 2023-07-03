using System;
using SEDC.PizzaApp.Models.Domain;
using SEDC.PizzaApp.Models.Enums;

namespace SEDC.PizzaApp
{
	public static class StaticDb
	{
		public static List<Pizza> Pizzas = new List<Pizza>
		{
			new Pizza
			{
				Id = 1,
				Name = "Capri",
				Price = 300,
				IsOnPromotion = true
			},

			new Pizza
			{
				Id = 2,
				Name = "Peperoni",
				Price = 400,
				IsOnPromotion = false
			},
		};

		public static List<User> Users = new List<User>
		{
			new User
			{
				Id = 1,
				FirstName = "Bob",
				LastName = "Bobsky",
				PhoneNumber = "12345"
			},

			new User
			{
				Id = 2,
				FirstName = "Kate",
				LastName = "Katesy",
				PhoneNumber = "56789"
			},
		};

		public static List<Order> Orders = new List<Order>
		{
			new Order
			{
				Id = 1,
				PizzaId = 1,
				UserId = 2,
				Pizza = Pizzas.First(),
				User = Users.First(user => user.Id == 2),
				PaymantMethod = PaymantMethod.Cash
			},

			new Order
			{
				Id = 2,
				PizzaId = 1,
				UserId = 1,
				Pizza = Pizzas.First(),
				User = Users.First(user => user.Id == 1),
				PaymantMethod = PaymantMethod.Card
			},

			new Order
			{
				Id = 3,
				PizzaId = 2,
				UserId = 2,
				Pizza = Pizzas.First(),
				User = Users.First(user => user.Id == 3),
				PaymantMethod = PaymantMethod.Card

			},

			new Order
			{
				Id = 4,
				PizzaId = 3,
				UserId = 3,
				Pizza = Pizzas.First(),
				User = Users.First(user => user.Id == 4),
				PaymantMethod = PaymantMethod.Card

			},

			new Order
			{
				Id = 5,
				PizzaId = 4,
				UserId = 4,
				Pizza = Pizzas.First(),
				User = Users.First(user => user.Id == 5),
				PaymantMethod = PaymantMethod.Cash,
<<<<<<< HEAD
				UserAdress = "Hristo Tatarcev 62 2/6"
=======
				
>>>>>>> 9ec4d26 (first commit)
			}


		};

	}
}
	
