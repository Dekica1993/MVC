using System;
using SEDC.PizzaApp.Models.Domain;
using SEDC.PizzaApp.Models.Enums;
using SEDC.PizzaApp.Models.viewModel;

namespace SEDC.PizzaApp.Mappers
{
	public static class OrderMapper
	{
        public static OrderViewModel ToOrderViewModel (this Order order)
        {
        return new OrderViewModel
        {
        PizzaName = order.Pizza.Name,
        PaymentMethod = order.PaymantMethod,
        Id = order.Id



        };

        }




        public static OrderDetailsViewModel ToOrderDetailsViewModel(this Order order)
        {
            return new OrderDetailsViewModel
            {
                Id = order.Id,
                IsDelivered = order.IsDelivered,
                PizzaName = order.Pizza.Name,
                Price = (int)(order.Pizza.Price + 100),
                UserFullName = $"{order.User.FirstName} {order.User.LastName}",
                PaymantMethod = order.PaymantMethod

            };
        }

        public static OrderListViewModel ToOrderListViewModel(this Order order)
		{
			return new OrderListViewModel
			{
				Id = order.Id,
				PizzaName = order.Pizza.Name,
				UserFullName = $"{order.User.FirstName} {order.User.LastName}"

			};
		}
	}
}

