using Services;
using SharedModelsLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaMaker
{
    public partial class FrmPizzaConfirm : Form
    {
        public List<PizzaModel>? Orders { get; set; }

        BusinessLayer businessLayer = new BusinessLayer();
        public FrmPizzaConfirm()
        {
            InitializeComponent();
        }

        public FrmPizzaConfirm(List<PizzaModel> orders)
        {
            InitializeComponent();
            Orders = orders;
        }


        public void ShowPizza()
        {
            lblPizzaOrder.Text = "";

            foreach (PizzaModel pizza in Orders)
            {
                lblPizzaOrder.Text += $"Pizza for: {pizza.PizzaFor}\n {string.Join(", ", pizza.Ingredients)}\n\nAddons: {string.Join(", ", pizza.Addons)}\n\nCrust: {pizza.Crust}\n\nSauce Level: {pizza.SauceLevel}\n\nCheese Level: {pizza.CheeseLevel}\n\nDelivery Time: {pizza.DeliveryTime}\n\nTotal Price: {pizza.TotalPrice}\n\n";
            }
        }

        private void PizzaSave_OnClick(object sender, EventArgs e)
        {
            bool isSaved = false;

            isSaved = businessLayer.WriteToFile(lblPizzaOrder.Text);

            if (isSaved)
            {
                MessageBox.Show("Order saved successfully");
            }
            else
            {
                MessageBox.Show("Order not saved");
            }
        }
    }
}
