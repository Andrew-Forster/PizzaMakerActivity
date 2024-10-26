namespace PizzaMaker
{
    partial class FrmPizzaMaker
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPizzaMaker));
            label1 = new Label();
            txtPizzaFor = new TextBox();
            grpIngredients = new GroupBox();
            cbHam = new CheckBox();
            cbOlives = new CheckBox();
            cbPepperoni = new CheckBox();
            cbPeppers = new CheckBox();
            cbTomatoes = new CheckBox();
            cbBacon = new CheckBox();
            cbSausage = new CheckBox();
            cbCheese = new CheckBox();
            grpCrust = new GroupBox();
            rbStuffedCrust = new RadioButton();
            rbDeepDish = new RadioButton();
            rbHandTossed = new RadioButton();
            rbThinCrispy = new RadioButton();
            grpTime = new GroupBox();
            dtDeliveryTime = new DateTimePicker();
            lbAddons = new ListBox();
            grpAddons = new GroupBox();
            grpGoodies = new GroupBox();
            lblCheeseLvl = new Label();
            hsbCheeseLvl = new HScrollBar();
            lblSauceLvl = new Label();
            hsbSauceLvl = new HScrollBar();
            btnCreate = new Button();
            btnReset = new Button();
            btnSave = new Button();
            btnCheckout = new Button();
            lblPrice = new Label();
            lblPriceAmount = new Label();
            grpIngredients.SuspendLayout();
            grpCrust.SuspendLayout();
            grpTime.SuspendLayout();
            grpAddons.SuspendLayout();
            grpGoodies.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 19);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(216, 22);
            label1.TabIndex = 0;
            label1.Text = "Who's the pizza for?";
            // 
            // txtPizzaFor
            // 
            txtPizzaFor.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPizzaFor.Location = new Point(240, 16);
            txtPizzaFor.Margin = new Padding(4, 3, 4, 3);
            txtPizzaFor.Name = "txtPizzaFor";
            txtPizzaFor.Size = new Size(261, 29);
            txtPizzaFor.TabIndex = 1;
            txtPizzaFor.Leave += TxtPizzaFor_OnLeave;
            // 
            // grpIngredients
            // 
            grpIngredients.Controls.Add(cbHam);
            grpIngredients.Controls.Add(cbOlives);
            grpIngredients.Controls.Add(cbPepperoni);
            grpIngredients.Controls.Add(cbPeppers);
            grpIngredients.Controls.Add(cbTomatoes);
            grpIngredients.Controls.Add(cbBacon);
            grpIngredients.Controls.Add(cbSausage);
            grpIngredients.Controls.Add(cbCheese);
            grpIngredients.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpIngredients.Location = new Point(13, 60);
            grpIngredients.Margin = new Padding(4, 3, 4, 3);
            grpIngredients.Name = "grpIngredients";
            grpIngredients.Padding = new Padding(4, 3, 4, 3);
            grpIngredients.Size = new Size(296, 175);
            grpIngredients.TabIndex = 2;
            grpIngredients.TabStop = false;
            grpIngredients.Text = "Ingredients";
            // 
            // cbHam
            // 
            cbHam.AutoSize = true;
            cbHam.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbHam.Location = new Point(141, 124);
            cbHam.Name = "cbHam";
            cbHam.Size = new Size(75, 26);
            cbHam.TabIndex = 7;
            cbHam.Text = "Ham";
            cbHam.UseVisualStyleBackColor = true;
            cbHam.CheckedChanged += Ingredients_Changed;
            // 
            // cbOlives
            // 
            cbOlives.AutoSize = true;
            cbOlives.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbOlives.Location = new Point(141, 60);
            cbOlives.Name = "cbOlives";
            cbOlives.Size = new Size(87, 26);
            cbOlives.TabIndex = 6;
            cbOlives.Text = "Olives";
            cbOlives.UseVisualStyleBackColor = true;
            cbOlives.CheckedChanged += Ingredients_Changed;
            // 
            // cbPepperoni
            // 
            cbPepperoni.AutoSize = true;
            cbPepperoni.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbPepperoni.Location = new Point(141, 92);
            cbPepperoni.Name = "cbPepperoni";
            cbPepperoni.Size = new Size(122, 26);
            cbPepperoni.TabIndex = 5;
            cbPepperoni.Text = "Pepperoni";
            cbPepperoni.UseVisualStyleBackColor = true;
            cbPepperoni.CheckedChanged += Ingredients_Changed;
            // 
            // cbPeppers
            // 
            cbPeppers.AutoSize = true;
            cbPeppers.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbPeppers.Location = new Point(141, 28);
            cbPeppers.Name = "cbPeppers";
            cbPeppers.Size = new Size(104, 26);
            cbPeppers.TabIndex = 4;
            cbPeppers.Text = "Peppers";
            cbPeppers.UseVisualStyleBackColor = true;
            cbPeppers.CheckedChanged += Ingredients_Changed;
            // 
            // cbTomatoes
            // 
            cbTomatoes.AutoSize = true;
            cbTomatoes.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbTomatoes.Location = new Point(7, 124);
            cbTomatoes.Name = "cbTomatoes";
            cbTomatoes.Size = new Size(119, 26);
            cbTomatoes.TabIndex = 3;
            cbTomatoes.Text = "Tomatoes";
            cbTomatoes.UseVisualStyleBackColor = true;
            cbTomatoes.CheckedChanged += Ingredients_Changed;
            // 
            // cbBacon
            // 
            cbBacon.AutoSize = true;
            cbBacon.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbBacon.Location = new Point(7, 60);
            cbBacon.Name = "cbBacon";
            cbBacon.Size = new Size(86, 26);
            cbBacon.TabIndex = 2;
            cbBacon.Text = "Bacon";
            cbBacon.UseVisualStyleBackColor = true;
            cbBacon.CheckedChanged += Ingredients_Changed;
            // 
            // cbSausage
            // 
            cbSausage.AutoSize = true;
            cbSausage.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbSausage.Location = new Point(7, 92);
            cbSausage.Name = "cbSausage";
            cbSausage.Size = new Size(108, 26);
            cbSausage.TabIndex = 1;
            cbSausage.Text = "Sausage";
            cbSausage.UseVisualStyleBackColor = true;
            cbSausage.CheckedChanged += Ingredients_Changed;
            // 
            // cbCheese
            // 
            cbCheese.AutoSize = true;
            cbCheese.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbCheese.Location = new Point(7, 28);
            cbCheese.Name = "cbCheese";
            cbCheese.Size = new Size(98, 26);
            cbCheese.TabIndex = 0;
            cbCheese.Text = "Cheese";
            cbCheese.UseVisualStyleBackColor = true;
            cbCheese.CheckedChanged += Ingredients_Changed;
            // 
            // grpCrust
            // 
            grpCrust.Controls.Add(rbStuffedCrust);
            grpCrust.Controls.Add(rbDeepDish);
            grpCrust.Controls.Add(rbHandTossed);
            grpCrust.Controls.Add(rbThinCrispy);
            grpCrust.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpCrust.Location = new Point(331, 60);
            grpCrust.Name = "grpCrust";
            grpCrust.Size = new Size(170, 175);
            grpCrust.TabIndex = 3;
            grpCrust.TabStop = false;
            grpCrust.Text = "Crust";
            // 
            // rbStuffedCrust
            // 
            rbStuffedCrust.AutoSize = true;
            rbStuffedCrust.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbStuffedCrust.Location = new Point(11, 124);
            rbStuffedCrust.Name = "rbStuffedCrust";
            rbStuffedCrust.Size = new Size(149, 26);
            rbStuffedCrust.TabIndex = 3;
            rbStuffedCrust.TabStop = true;
            rbStuffedCrust.Text = "Stuffed Crust";
            rbStuffedCrust.UseVisualStyleBackColor = true;
            // 
            // rbDeepDish
            // 
            rbDeepDish.AutoSize = true;
            rbDeepDish.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbDeepDish.Location = new Point(11, 92);
            rbDeepDish.Name = "rbDeepDish";
            rbDeepDish.Size = new Size(123, 26);
            rbDeepDish.TabIndex = 2;
            rbDeepDish.TabStop = true;
            rbDeepDish.Text = "Deep Dish";
            rbDeepDish.UseVisualStyleBackColor = true;
            // 
            // rbHandTossed
            // 
            rbHandTossed.AutoSize = true;
            rbHandTossed.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbHandTossed.Location = new Point(11, 60);
            rbHandTossed.Name = "rbHandTossed";
            rbHandTossed.Size = new Size(144, 26);
            rbHandTossed.TabIndex = 1;
            rbHandTossed.TabStop = true;
            rbHandTossed.Text = "Hand Tossed";
            rbHandTossed.UseVisualStyleBackColor = true;
            // 
            // rbThinCrispy
            // 
            rbThinCrispy.AutoSize = true;
            rbThinCrispy.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbThinCrispy.Location = new Point(11, 28);
            rbThinCrispy.Name = "rbThinCrispy";
            rbThinCrispy.Size = new Size(132, 26);
            rbThinCrispy.TabIndex = 0;
            rbThinCrispy.TabStop = true;
            rbThinCrispy.Text = "Thin Crispy";
            rbThinCrispy.UseVisualStyleBackColor = true;
            rbThinCrispy.CheckedChanged += Crust_Chanaged;
            // 
            // grpTime
            // 
            grpTime.Controls.Add(dtDeliveryTime);
            grpTime.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpTime.Location = new Point(517, 60);
            grpTime.Name = "grpTime";
            grpTime.Size = new Size(274, 66);
            grpTime.TabIndex = 4;
            grpTime.TabStop = false;
            grpTime.Text = "Delivery Time";
            // 
            // dtDeliveryTime
            // 
            dtDeliveryTime.CustomFormat = "MM/dd/yyyy hh:mm";
            dtDeliveryTime.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtDeliveryTime.Format = DateTimePickerFormat.Custom;
            dtDeliveryTime.Location = new Point(6, 28);
            dtDeliveryTime.Name = "dtDeliveryTime";
            dtDeliveryTime.Size = new Size(243, 29);
            dtDeliveryTime.TabIndex = 0;
            dtDeliveryTime.Value = new DateTime(2024, 10, 15, 12, 8, 31, 0);
            dtDeliveryTime.ValueChanged += DeliveryTime_Changed;
            // 
            // lbAddons
            // 
            lbAddons.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbAddons.FormattingEnabled = true;
            lbAddons.ItemHeight = 22;
            lbAddons.Items.AddRange(new object[] { "Peanut Butter", "Pickled Jalapenos", "Mushrooms", "Chipotle", "Basil", "Salami", "Onions", "Pineapple" });
            lbAddons.Location = new Point(6, 28);
            lbAddons.Name = "lbAddons";
            lbAddons.SelectionMode = SelectionMode.MultiSimple;
            lbAddons.Size = new Size(211, 114);
            lbAddons.TabIndex = 5;
            lbAddons.Leave += Addons_OnLeave;
            // 
            // grpAddons
            // 
            grpAddons.Controls.Add(lbAddons);
            grpAddons.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpAddons.Location = new Point(12, 241);
            grpAddons.Name = "grpAddons";
            grpAddons.Size = new Size(223, 145);
            grpAddons.TabIndex = 6;
            grpAddons.TabStop = false;
            grpAddons.Text = "Additional Add-ons";
            // 
            // grpGoodies
            // 
            grpGoodies.Controls.Add(lblCheeseLvl);
            grpGoodies.Controls.Add(hsbCheeseLvl);
            grpGoodies.Controls.Add(lblSauceLvl);
            grpGoodies.Controls.Add(hsbSauceLvl);
            grpGoodies.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpGoodies.Location = new Point(258, 241);
            grpGoodies.Name = "grpGoodies";
            grpGoodies.Size = new Size(243, 145);
            grpGoodies.TabIndex = 7;
            grpGoodies.TabStop = false;
            grpGoodies.Text = "Extra Goodies";
            // 
            // lblCheeseLvl
            // 
            lblCheeseLvl.AutoSize = true;
            lblCheeseLvl.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCheeseLvl.Location = new Point(3, 84);
            lblCheeseLvl.Name = "lblCheeseLvl";
            lblCheeseLvl.Size = new Size(144, 22);
            lblCheeseLvl.TabIndex = 5;
            lblCheeseLvl.Text = "Cheese Level: ";
            // 
            // hsbCheeseLvl
            // 
            hsbCheeseLvl.LargeChange = 0;
            hsbCheeseLvl.Location = new Point(3, 106);
            hsbCheeseLvl.Name = "hsbCheeseLvl";
            hsbCheeseLvl.Size = new Size(227, 29);
            hsbCheeseLvl.SmallChange = 0;
            hsbCheeseLvl.TabIndex = 4;
            hsbCheeseLvl.Scroll += Goodies_OnScroll;
            // 
            // lblSauceLvl
            // 
            lblSauceLvl.AutoSize = true;
            lblSauceLvl.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSauceLvl.Location = new Point(6, 28);
            lblSauceLvl.Name = "lblSauceLvl";
            lblSauceLvl.Size = new Size(132, 22);
            lblSauceLvl.TabIndex = 1;
            lblSauceLvl.Text = "Sauce Level: ";
            // 
            // hsbSauceLvl
            // 
            hsbSauceLvl.LargeChange = 0;
            hsbSauceLvl.Location = new Point(6, 50);
            hsbSauceLvl.Name = "hsbSauceLvl";
            hsbSauceLvl.Size = new Size(227, 29);
            hsbSauceLvl.SmallChange = 0;
            hsbSauceLvl.TabIndex = 0;
            hsbSauceLvl.Scroll += Goodies_OnScroll;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.FromArgb(192, 255, 192);
            btnCreate.FlatStyle = FlatStyle.Popup;
            btnCreate.Location = new Point(797, 132);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(291, 46);
            btnCreate.TabIndex = 8;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += CreatePizza_OnClick;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(255, 192, 192);
            btnReset.FlatStyle = FlatStyle.Popup;
            btnReset.Location = new Point(517, 132);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(274, 46);
            btnReset.TabIndex = 9;
            btnReset.Text = "Reset Form";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += ResetForm_OnClick;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(192, 192, 255);
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Location = new Point(12, 392);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(246, 48);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save Pizza";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += SavePizza_OnClick;
            // 
            // btnCheckout
            // 
            btnCheckout.BackColor = Color.FromArgb(255, 224, 192);
            btnCheckout.FlatStyle = FlatStyle.Popup;
            btnCheckout.Location = new Point(264, 392);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(237, 48);
            btnCheckout.TabIndex = 11;
            btnCheckout.Text = "Checkout";
            btnCheckout.UseVisualStyleBackColor = false;
            btnCheckout.Click += PizzaCheckout_OnClick;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.Location = new Point(521, 195);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(127, 22);
            lblPrice.TabIndex = 12;
            lblPrice.Text = "Pizza Price:";
            // 
            // lblPriceAmount
            // 
            lblPriceAmount.AutoSize = true;
            lblPriceAmount.ForeColor = Color.Green;
            lblPriceAmount.Location = new Point(644, 195);
            lblPriceAmount.Name = "lblPriceAmount";
            lblPriceAmount.Size = new Size(21, 22);
            lblPriceAmount.TabIndex = 13;
            lblPriceAmount.Text = "$";
            // 
            // FrmPizzaMaker
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 456);
            Controls.Add(lblPriceAmount);
            Controls.Add(lblPrice);
            Controls.Add(btnCheckout);
            Controls.Add(btnSave);
            Controls.Add(btnReset);
            Controls.Add(btnCreate);
            Controls.Add(grpGoodies);
            Controls.Add(grpAddons);
            Controls.Add(grpTime);
            Controls.Add(grpCrust);
            Controls.Add(grpIngredients);
            Controls.Add(txtPizzaFor);
            Controls.Add(label1);
            Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmPizzaMaker";
            Text = "Pizza Maker";
            grpIngredients.ResumeLayout(false);
            grpIngredients.PerformLayout();
            grpCrust.ResumeLayout(false);
            grpCrust.PerformLayout();
            grpTime.ResumeLayout(false);
            grpAddons.ResumeLayout(false);
            grpGoodies.ResumeLayout(false);
            grpGoodies.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPizzaFor;
        private GroupBox grpIngredients;
        private CheckBox cbCheese;
        private CheckBox cbBacon;
        private CheckBox cbSausage;
        private CheckBox cbTomatoes;
        private CheckBox cbHam;
        private CheckBox cbOlives;
        private CheckBox cbPepperoni;
        private CheckBox cbPeppers;
        private GroupBox grpCrust;
        private RadioButton rbThinCrispy;
        private RadioButton rbStuffedCrust;
        private RadioButton rbDeepDish;
        private RadioButton rbHandTossed;
        private GroupBox grpTime;
        private DateTimePicker dtDeliveryTime;
        private ListBox lbAddons;
        private GroupBox grpAddons;
        private GroupBox grpGoodies;
        private HScrollBar hsbSauceLvl;
        private Label lblSauceLvl;
        private Label lblCheeseLvl;
        private HScrollBar hsbCheeseLvl;
        private Button btnCreate;
        private Button btnReset;
        private Button btnSave;
        private Button btnCheckout;
        private Label lblPrice;
        private Label lblPriceAmount;
    }
}
