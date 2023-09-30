﻿using System;
using Enumeracao.Entities;
using Enumeracao.Entities.Enums;

namespace Enumeracao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayments
            };
            
             
                
           Console.WriteLine(order);

            string txt = OrderStatus.PendingPayments.ToString();

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");


            Console.WriteLine(os);
            Console.WriteLine(txt);

        }
    }
}