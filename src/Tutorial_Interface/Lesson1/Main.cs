﻿using System;
using System.Linq;

namespace Tutorial_Interface.Lesson1
{
    class Main
    {
        public void Run()
        {
            SampleCustomer c = new SampleCustomer("customer one", new DateTime(2010, 5, 31))
            {
                Reminders =
                {
                    { new DateTime(2010, 08, 12), "childs's birthday" },
                    { new DateTime(1012, 11, 15), "anniversary" }
                }
            };

            SampleOrder o = new SampleOrder(new DateTime(2012, 6, 1), 5m);
            c.AddOrder(o);

            o = new SampleOrder(new DateTime(2103, 7, 4), 25m);
            c.AddOrder(o);

            // Check the discount:
            ICustomer theCustomer = c;
            Console.WriteLine($"Current discount: {theCustomer.ComputeLoyaltyDiscount()}");
        }
    }
}
