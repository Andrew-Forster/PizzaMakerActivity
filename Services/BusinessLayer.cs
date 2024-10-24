
using SharedModelsLibrary.Models;

namespace Services
{
    public class BusinessLayer
    {
        /// <summary>
        /// Add pizza to the list of pizza orders
        /// </summary>
        /// <param name="pizza"></param>
        /// <param name="pizzaOrders"></param>
        /// <returns></returns>
        public (bool isPizza, List<PizzaModel> pizzaOrders) AddPizza(PizzaModel pizza, List<PizzaModel> pizzaOrders)
        {
            bool isPizza = false;
            if (pizza.PizzaFor != null && pizza.Ingredients.Count > 0)
            {
                isPizza = true;
                pizzaOrders.Add(pizza);
            }

            return (isPizza, pizzaOrders);
        }
    }
}
