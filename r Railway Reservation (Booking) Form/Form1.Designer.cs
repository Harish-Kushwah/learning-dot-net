namespace Railway_Reservation_Form
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Form controls
        private Label lblPassengerName;
        private TextBox txtPassengerName;
        private Label lblAge;
        private TextBox txtAge;
        private Label lblGender;
        private ComboBox cmbGender;
        private Label lblSource;
        private TextBox txtSource;
        private Label lblDestination;
        private TextBox txtDestination;
        private Label lblClass;
        private ComboBox cmbClass;
        private Button btnBook;
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

            // Initialize controls
            this.lblPassengerName = new Label();
            this.txtPassengerName = new TextBox();
            this.lblAge = new Label();
            this.txtAge = new TextBox();
            this.lblGender = new Label();
            this.cmbGender = new ComboBox();
            this.lblSource = new Label();
            this.txtSource = new TextBox();
            this.lblDestination = new Label();
            this.txtDestination = new TextBox();
            this.lblClass = new Label();
            this.cmbClass = new ComboBox();
            this.btnBook = new Button();
            this.btnClear = new Button();
            this.lblResult = new Label();

            this.SuspendLayout();

            // lblPassengerName
            this.lblPassengerName.Location = new System.Drawing.Point(20, 20);
            this.lblPassengerName.Text = "Passenger Name:";
            this.lblPassengerName.Size = new System.Drawing.Size(120, 20);

            // txtPassengerName
            this.txtPassengerName.Location = new System.Drawing.Point(150, 17);
            this.txtPassengerName.Size = new System.Drawing.Size(200, 20);

            // lblAge
            this.lblAge.Location = new System.Drawing.Point(20, 50);
            this.lblAge.Text = "Age:";
            this.lblAge.Size = new System.Drawing.Size(120, 20);

            // txtAge
            this.txtAge.Location = new System.Drawing.Point(150, 47);
            this.txtAge.Size = new System.Drawing.Size(50, 20);

            // lblGender
            this.lblGender.Location = new System.Drawing.Point(20, 80);
            this.lblGender.Text = "Gender:";
            this.lblGender.Size = new System.Drawing.Size(120, 20);

            // cmbGender
            this.cmbGender.Location = new System.Drawing.Point(150, 77);
            this.cmbGender.Size = new System.Drawing.Size(100, 21);
            this.cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbGender.Items.AddRange(new object[] { "Male", "Female", "Other" });

            // lblSource
            this.lblSource.Location = new System.Drawing.Point(20, 110);
            this.lblSource.Text = "Source Station:";
            this.lblSource.Size = new System.Drawing.Size(120, 20);

            // txtSource
            this.txtSource.Location = new System.Drawing.Point(150, 107);
            this.txtSource.Size = new System.Drawing.Size(200, 20);

            // lblDestination
            this.lblDestination.Location = new System.Drawing.Point(20, 140);
            this.lblDestination.Text = "Destination Station:";
            this.lblDestination.Size = new System.Drawing.Size(120, 20);

            // txtDestination
            this.txtDestination.Location = new System.Drawing.Point(150, 137);
            this.txtDestination.Size = new System.Drawing.Size(200, 20);

            // lblClass
            this.lblClass.Location = new System.Drawing.Point(20, 170);
            this.lblClass.Text = "Class:";
            this.lblClass.Size = new System.Drawing.Size(120, 20);

            // cmbClass
            this.cmbClass.Location = new System.Drawing.Point(150, 167);
            this.cmbClass.Size = new System.Drawing.Size(100, 21);
            this.cmbClass.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbClass.Items.AddRange(new object[] { "Sleeper", "AC 3-Tier", "AC 2-Tier", "AC First" });

            // btnBook
            this.btnBook.Location = new System.Drawing.Point(150, 200);
            this.btnBook.Text = "Book Ticket";
            this.btnBook.Size = new System.Drawing.Size(100, 30);
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);

            // btnClear
            this.btnClear.Location = new System.Drawing.Point(260, 200);
            this.btnClear.Text = "Clear";
            this.btnClear.Size = new System.Drawing.Size(100, 30);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // lblResult
            this.lblResult.Location = new System.Drawing.Point(20, 240);
            this.lblResult.Size = new System.Drawing.Size(400, 120);
            this.lblResult.Text = "";

            // Form properties
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 400);
            this.Text = "Railway Reservation Form";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // Add controls to form
            this.Controls.Add(this.lblPassengerName);
            this.Controls.Add(this.txtPassengerName);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.lblSource);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.cmbClass);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblResult);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}