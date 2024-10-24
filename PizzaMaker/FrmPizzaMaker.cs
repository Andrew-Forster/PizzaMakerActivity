using Services;
using SharedModelsLibrary.Models;

namespace PizzaMaker
{
    public partial class FrmPizzaMaker : Form
    {

        PizzaModel pizzaOrder = new PizzaModel();
        List<PizzaModel> pizzaOrders = new List<PizzaModel>();

        BusinessLayer businessLayer = new BusinessLayer();

        public FrmPizzaMaker()
        {
            InitializeComponent();

            Control[] controls = { btnCreate, btnCheckout, btnReset, btnSave, lblPriceAmount };

            foreach (Control control in controls)
            {
                control.Visible = false;
            }

            // Fix scroll bar only going to 91


        }

        private void TxtPizzaFor_OnLeave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPizzaFor.Text))
            {
                pizzaOrder.PizzaFor = txtPizzaFor.Text;
                AllowCreatePizza();
            }
        }

        /// <summary>
        /// Manage buttons visibility for initial setup
        /// </summary>
        private void AllowCreatePizza()
        {
            btnCreate.Visible = true;
            btnReset.Visible = true;
        }


        private void Ingredients_Changed(object sender, EventArgs e)
        {
            CheckBox changedCb = (CheckBox)sender;

            if (changedCb != null)
            {
                if (changedCb.Checked)
                {
                    pizzaOrder.Ingredients.Add(changedCb.Text);
                }
                else
                {
                    pizzaOrder.Ingredients.Remove(changedCb.Text);
                }
            }
        }

        private void Addons_OnLeave(object sender, EventArgs e)
        {
            pizzaOrder.Addons.Clear();

            foreach (var item in lbAddons.SelectedItems)
            {
                pizzaOrder.Addons.Add(item.ToString());
            }
        }

        private void Crust_Chanaged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton != null)
            {
                pizzaOrder.Crust = radioButton.Text;
            }
        }

        private void Goodies_OnScroll(object sender, ScrollEventArgs e)
        {
            HScrollBar hScrollBar = (HScrollBar)sender;

            if (hScrollBar != null)
            {
                if (hScrollBar.Name == "hsbSauceLvl")
                {
                    pizzaOrder.SauceLevel = hScrollBar.Value;
                    lblSauceLvl.Text = $"Sauce Level: {hScrollBar.Value.ToString()}";
                }
                else if (hScrollBar.Name == "hsbCheeseLvl")
                {
                    lblCheeseLvl.Text = $"Cheese Level: {hScrollBar.Value.ToString()}";
                    pizzaOrder.CheeseLevel = hScrollBar.Value;
                }
            }
        }
        /// <summary>
        /// Set the delivery time for the pizza
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeliveryTime_Changed(object sender, EventArgs e)
        {
            pizzaOrder.DeliveryTime = dtDeliveryTime.Value;
        }

        /// <summary>
        /// Create the pizza and add it to the list of pizzas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreatePizza_OnClick(object sender, EventArgs e)
        {
            var results = businessLayer.AddPizza(pizzaOrder, pizzaOrders);
            // If is pizza, Show buttons

            if (results.isPizza)
            {
                pizzaOrders = results.pizzaOrders;
                btnCheckout.Visible = true;
                btnSave.Visible = true;
                lblPriceAmount.Visible = true;
                lblPriceAmount.Text = $"Total Price: {pizzaOrder.TotalPrice.ToString()}";
            }

        }

        private void PizzaCheckout_OnClick(object sender, EventArgs e)
        {
            FrmPizzaConfirm frmPizzaConfirm = new FrmPizzaConfirm(pizzaOrders);
        }

        private void ResetForm_OnClick(object sender, EventArgs e)
        {
            // Andrew Forster

            txtPizzaFor.Text = string.Empty;
            
            foreach(Control control in grpIngredients.Controls)
            {
                if (control is CheckBox)
                {
                    ((CheckBox)control).Checked = false;
                }
            }

            lbAddons.ClearSelected();

            hsbCheeseLvl.Value = 0;
            hsbSauceLvl.Value = 0;

            foreach (Control control in grpCrust.Controls)
            {
                if (control is RadioButton)
                {
                    ((RadioButton)control).Checked = false;
                }
            }

            dtDeliveryTime.Value = DateTime.Now;
        }
    }
}
