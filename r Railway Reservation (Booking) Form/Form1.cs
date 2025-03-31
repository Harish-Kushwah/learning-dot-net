using System;
using System.Drawing;
using System.Windows.Forms;

namespace Railway_Reservation_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ApplyStyling(); // Apply custom styling
        }

        private void ApplyStyling()
        {
            // Form styling
            this.BackColor = Color.FromArgb(240, 248, 255); // Light blue background
            this.Font = new Font("Segoe UI", 9F);

            // Labels styling
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Label)
                {
                    ctrl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                    ctrl.ForeColor = Color.FromArgb(0, 51, 102); // Dark blue
                }
            }

            // TextBox styling
            txtPassengerName.BackColor = Color.White;
            txtAge.BackColor = Color.White;
            txtSource.BackColor = Color.White;
            txtDestination.BackColor = Color.White;

            // ComboBox styling
            cmbClass.BackColor = Color.White;
            cmbGender.BackColor = Color.White;

            // Button styling
            btnBook.BackColor = Color.FromArgb(0, 153, 0); // Green
            btnBook.ForeColor = Color.White;
            btnBook.FlatStyle = FlatStyle.Flat;
            btnBook.Font = new Font("Segoe UI", 9F, FontStyle.Bold);

            btnClear.BackColor = Color.FromArgb(204, 0, 0); // Red
            btnClear.ForeColor = Color.White;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);

            // Result label
            lblResult.BackColor = Color.FromArgb(245, 245, 220); // Beige
            lblResult.BorderStyle = BorderStyle.FixedSingle;
            lblResult.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            try
            {
                // Basic validation
                if (string.IsNullOrWhiteSpace(txtPassengerName.Text))
                    throw new ArgumentException("Passenger name is required");
                if (string.IsNullOrWhiteSpace(txtAge.Text) || !int.TryParse(txtAge.Text, out int age) || age <= 0)
                    throw new ArgumentException("Valid age is required");
                if (string.IsNullOrWhiteSpace(txtSource.Text))
                    throw new ArgumentException("Source station is required");
                if (string.IsNullOrWhiteSpace(txtDestination.Text))
                    throw new ArgumentException("Destination station is required");
                if (cmbClass.SelectedIndex == -1)
                    throw new ArgumentException("Please select a class");
                if (cmbGender.SelectedIndex == -1)
                    throw new ArgumentException("Please select gender");

                // Display booking details
                string bookingDetails = $"Booking Confirmed!\n" +
                                      $"Passenger: {txtPassengerName.Text}\n" +
                                      $"Age: {txtAge.Text}\n" +
                                      $"Gender: {cmbGender.SelectedItem}\n" +
                                      $"From: {txtSource.Text}\n" +
                                      $"To: {txtDestination.Text}\n" +
                                      $"Class: {cmbClass.SelectedItem}\n" +
                                      $"Booking Date: {DateTime.Now:dd-MM-yyyy HH:mm:ss}";

                lblResult.Text = bookingDetails;
            }
            catch (ArgumentException ex)
            {
                lblResult.Text = $"Error: {ex.Message}";
            }
            catch (Exception ex)
            {
                lblResult.Text = $"Unexpected error: {ex.Message}";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassengerName.Text = "";
            txtAge.Text = "";
            txtSource.Text = "";
            txtDestination.Text = "";
            cmbClass.SelectedIndex = -1;
            cmbGender.SelectedIndex = -1;
            lblResult.Text = "";
        }
    }
}