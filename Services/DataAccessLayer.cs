using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    class DataAccessLayer
    {

        /// <summary>
        /// Uses StreamWriter to write data to a file
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool WriteToFile(string data)
        {
            string pathToFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"App_Data\PizzaOrders.txt");
            try
            {
                using (StreamWriter sw = new StreamWriter(Path.Combine(pathToFile)))
                {
                    sw.WriteLine(data);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
