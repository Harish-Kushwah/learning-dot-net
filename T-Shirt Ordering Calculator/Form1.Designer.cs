namespace T_Shirt_Ordering_Calculator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Form controls
        private Label lblQuantity;
        private TextBox txtQuantity;
        private Label lblSize;
        private RadioButton rbSmall;
        private RadioButton rbMedium;
        private RadioButton rbLarge;
        private Label lblPromoCode;
        private TextBox txtPromoCode;
        private Button btnCalculate;
        private Button btnClear;
        private Label lblResult;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            // Quantity
            this.lblQuantity = new Label();
            this.txtQuantity = new TextBox();
            this.lblSize = new Label();
            this.rbSmall = new RadioButton();
            this.rbMedium = new RadioButton();
            this.rbLarge = new RadioButton();
            this.lblPromoCode = new Label();
            this.txtPromoCode = new TextBox();
            this.btnCalculate = new Button();
            this.btnClear = new Button();
            this.lblResult = new Label();

            this.SuspendLayout();

            // lblQuantity
            this.lblQuantity.Location = new System.Drawing.Point(20, 20);
            this.lblQuantity.Text = "Number of T-Shirts:";
            this.lblQuantity.Size = new System.Drawing.Size(120, 20);

            // txtQuantity
            this.txtQuantity.Location = new System.Drawing.Point(150, 17);
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);

            // lblSize
            this.lblSize.Location = new System.Drawing.Point(20, 50);
            this.lblSize.Text = "Select Size:";
            this.lblSize.Size = new System.Drawing.Size(120, 20);

            // rbSmall
            this.rbSmall.Location = new System.Drawing.Point(150, 50);
            this.rbSmall.Text = "Small (Rs. 125)";
            this.rbSmall.Size = new System.Drawing.Size(100, 20);

            // rbMedium
            this.rbMedium.Location = new System.Drawing.Point(260, 50);
            this.rbMedium.Text = "Medium (Rs. 175)";
            this.rbMedium.Size = new System.Drawing.Size(100, 20);

            // rbLarge
            this.rbLarge.Location = new System.Drawing.Point(370, 50);
            this.rbLarge.Text = "Large (Rs. 250)";
            this.rbLarge.Size = new System.Drawing.Size(100, 20);

            // lblPromoCode
            this.lblPromoCode.Location = new System.Drawing.Point(20, 80);
            this.lblPromoCode.Text = "Promo Code:";
            this.lblPromoCode.Size = new System.Drawing.Size(120, 20);

            // txtPromoCode
            this.txtPromoCode.Location = new System.Drawing.Point(150, 77);
            this.txtPromoCode.Size = new System.Drawing.Size(100, 20);

            // btnCalculate
            this.btnCalculate.Location = new System.Drawing.Point(150, 110);
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 25);
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);

            // btnClear
            this.btnClear.Location = new System.Drawing.Point(230, 110);
            this.btnClear.Text = "Clear";
            this.btnClear.Size = new System.Drawing.Size(75, 25);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // lblResult
            this.lblResult.Location = new System.Drawing.Point(20, 150);
            this.lblResult.Size = new System.Drawing.Size(400, 100);
            this.lblResult.Text = "";

            // Form properties
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Text = "T-Shirt Ordering Calculator";

            // Add controls to form
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.rbSmall);
            this.Controls.Add(this.rbMedium);
            this.Controls.Add(this.rbLarge);
            this.Controls.Add(this.lblPromoCode);
            this.Controls.Add(this.txtPromoCode);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblResult);

            this.ResumeLayout(false);
        }
    }
}