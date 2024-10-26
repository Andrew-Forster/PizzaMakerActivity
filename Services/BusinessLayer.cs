
using SharedModelsLibrary.Models;

namespace Services
{
    public class BusinessLayer
    {
        DataAccessLayer dataAccessLayer = new DataAccessLayer();
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

        /// <summary>
        /// Write pizza orders to a file
        /// </summary>
        /// <param name="pizzaOrders"></param>
        /// <returns></returns>
        public bool WriteToFile(string pizzaOrders)
        {
            return dataAccessLayer.WriteToFile(pizzaOrders);
        }

        /// <summary>
        /// Calculate the total price of a pizza
        /// </summary>
        /// <param name="pizza"></param>
        /// <returns></returns>
        public decimal CalculateTotalPrice(PizzaModel pizza)
        {
            decimal totalPrice = 10.00m;

            if (pizza.Ingredients.Count > 0)
            {
                totalPrice += pizza.Ingredients.Count * 1.00m;
            }

            if (pizza.Addons.Count > 0)
            {
                totalPrice += pizza.Addons.Count * 0.50m;
            }

            totalPrice += pizza.SauceLevel * 0.05m;
            totalPrice += pizza.CheeseLevel * 0.05m;

            if (pizza.Crust == "Stuffed Crust")
            {
                totalPrice += 2.00m;
            }


            return totalPrice;
        }
    }
}
