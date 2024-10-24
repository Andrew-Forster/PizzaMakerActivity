using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModelsLibrary.Models
{
    public class PizzaModel
    {
        public string PizzaFor { get; set; }
        public List<string> Ingredients { get; set; }
        public List<string> Addons { get; set; }
        public string Crust { get; set; }
        public int SauceLevel { get; set; }
        public int CheeseLevel { get; set; }
        public DateTime DeliveryTime { get; set; }
        public decimal TotalPrice { get; set; }

        public PizzaModel()
        {
            Ingredients = new List<string>();
            Addons = new List<string>();

            PizzaFor = string.Empty;
            Crust = string.Empty;
            SauceLevel = 0;
            CheeseLevel = 0;
            DeliveryTime = DateTime.Now;
            TotalPrice = 0.0m;
        }

    }
}
