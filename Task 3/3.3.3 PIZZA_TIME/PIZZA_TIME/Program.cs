using System;
using System.Collections.Generic;

namespace PIZZA_TIME
{
    class Program
    {
        static Pizzeria pizzeria = new Pizzeria();
        static int id = 0;
        static void Main(string[] args)
        {
            pizzeria.OnOrderComplete += ShowMessage;
            while (true)
            {
                Console.WriteLine("Нажмите, чтобы сделать заказ");
                Console.ReadLine();
                id++;
                GetOrder(id);
            }
        }

        public static void ShowMessage(int id, Pizza[] pizzas)
        {
            foreach (var item in pizzas)
            {
                Console.Write(item.Name + " ");
            }
            Console.Write($"пицца(ы) готовы, заказ номер ");
            Console.WriteLine($"{id}");
        }
        public static void GetOrder(int id)
        {
            PizzaMaker pm = new PizzaMaker();
            List<Pizza> pizzas = new List<Pizza>();
            Console.WriteLine("Какую пиццу хотите?");
            bool ord = true;
            while (ord)
            {
                Console.WriteLine("1 - Мясная");
                Console.WriteLine("2 - Веганская");
                Console.WriteLine("3 - Рыбная");
                Console.WriteLine("4 - Заказать");
                int.TryParse(Console.ReadLine(), out int choice);
                switch (choice)
                {
                    case 1:
                        pizzas.Add(pm.GetMeat());
                        break;
                    case 2:
                        pizzas.Add(pm.GetVegan());
                        break;
                    case 3:
                        pizzas.Add(pm.GetFish());
                        break;

                    case 4:
                        ord = false;
                        break;

                    default:
                        break;
                }
            }
            Console.WriteLine($"Ожидайте готовности заказа, ваш номер заказа - {id}");
            pizzeria.CreateOrder(id, pizzas.ToArray());
        }
    }
}
