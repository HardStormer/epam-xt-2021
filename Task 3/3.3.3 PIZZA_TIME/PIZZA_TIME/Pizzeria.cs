using System;
using System.Threading;
using System.Threading.Tasks;

namespace PIZZA_TIME
{
    class Pizzeria
    {
        public Action<int, Pizza[]> OnOrderComplete;
        public void CreateOrder(int id, Pizza[] pizzas)
        {
            Task.Factory.StartNew(() =>
            {
                int sum = 0;
                foreach (var pizza in pizzas)
                {
                    sum += pizza.cookingTime;
                }
                Thread.Sleep(sum * 1000);
                OnOrderComplete(id, pizzas);
            });
        }
    }
}
