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
            btnPizzaConfirm = new Button();
            SuspendLayout();
            // 
            // btnPizzaConfirm
            // 
            btnPizzaConfirm.BackColor = Color.FromArgb(192, 192, 255);
            btnPizzaConfirm.FlatStyle = FlatStyle.Popup;
            btnPizzaConfirm.Location = new Point(556, 406);
            btnPizzaConfirm.Name = "btnPizzaConfirm";
            btnPizzaConfirm.Size = new Size(273, 46);
            btnPizzaConfirm.TabIndex = 0;
            btnPizzaConfirm.Text = "Confirm Pizza";
            btnPizzaConfirm.UseVisualStyleBackColor = false;
            // 
            // FrmPizzaConfirm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(841, 464);
            Controls.Add(btnPizzaConfirm);
            Name = "FrmPizzaConfirm";
            Text = "Pizza Confirm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnPizzaConfirm;
    }
}