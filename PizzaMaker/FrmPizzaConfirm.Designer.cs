namespace PizzaMaker
{
    partial class FrmPizzaConfirm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPizzaConfirm));
            btnPizzaSave = new Button();
            lblPizzaOrder = new Label();
            SuspendLayout();
            // 
            // btnPizzaSave
            // 
            btnPizzaSave.BackColor = Color.FromArgb(192, 192, 255);
            btnPizzaSave.FlatStyle = FlatStyle.Popup;
            btnPizzaSave.Location = new Point(556, 406);
            btnPizzaSave.Name = "btnPizzaSave";
            btnPizzaSave.Size = new Size(273, 46);
            btnPizzaSave.TabIndex = 0;
            btnPizzaSave.Text = "Save Pizza";
            btnPizzaSave.UseVisualStyleBackColor = false;
            btnPizzaSave.Click += PizzaSave_OnClick;
            // 
            // lblPizzaOrder
            // 
            lblPizzaOrder.AutoSize = true;
            lblPizzaOrder.BackColor = Color.Black;
            lblPizzaOrder.ForeColor = SystemColors.ButtonFace;
            lblPizzaOrder.Location = new Point(17, 18);
            lblPizzaOrder.Name = "lblPizzaOrder";
            lblPizzaOrder.Size = new Size(50, 20);
            lblPizzaOrder.TabIndex = 1;
            lblPizzaOrder.Text = "label1";
            // 
            // FrmPizzaConfirm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(841, 464);
            Controls.Add(lblPizzaOrder);
            Controls.Add(btnPizzaSave);
            DoubleBuffered = true;
            Name = "FrmPizzaConfirm";
            Text = "Pizza Confirm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPizzaSave;
        private Label lblPizzaOrder;
    }
}