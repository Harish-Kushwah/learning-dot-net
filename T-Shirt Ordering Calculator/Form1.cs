using System;
using System.Windows.Forms;

namespace T_Shirt_Ordering_Calculator
{
    public partial class Form1 : Form
    {
        // Constants
        private const double SMALL_PRICE = 125.0;
        private const double MEDIUM_PRICE = 175.0;
        private const double LARGE_PRICE = 250.0;
        private const double GST_RATE = 0.09; // 9%
        private const string PROMO_CODE = "TRUEBLUE";
        private const double DISCOUNT_RATE = 0.10; // 10%

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Get quantity
                int quantity = int.Parse(txtQuantity.Text);
                if (quantity <= 0)
                    throw new ArgumentException("Quantity must be positive");

                // Get size and base price
                double basePrice = 0;
                if (rbSmall.Checked) basePrice = SMALL_PRICE;
                else if (rbMedium.Checked) basePrice = MEDIUM_PRICE;
                else if (rbLarge.Checked) basePrice = LARGE_PRICE;
                else throw new ArgumentException("Please select a size");

                // Calculate subtotal
                double subtotal = quantity * basePrice;

                // Apply discount if promo code is correct
                double discount = 0;
                if (txtPromoCode.Text.Trim().ToUpper() == PROMO_CODE)
                {
                    discount = subtotal * DISCOUNT_RATE;
                }

                // Calculate total before GST
                double totalBeforeGST = subtotal - discount;

                // Apply GST
                double gstAmount = totalBeforeGST * GST_RATE;
                double finalPrice = totalBeforeGST + gstAmount;

                // Display results
                lblResult.Text = $"Subtotal: Rs. {subtotal:F2}\n" +
                               $"Discount: Rs. {discount:F2}\n" +
                               $"GST (9%): Rs. {gstAmount:F2}\n" +
                               $"Final Price: Rs. {finalPrice:F2}";
            }
            catch (FormatException)
            {
                lblResult.Text = "Please enter a valid quantity";
            }
            catch (ArgumentException ex)
            {
                lblResult.Text = ex.Message;
            }
            catch (Exception ex)
            {
                lblResult.Text = $"An error occurred: {ex.Message}";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtQuantity.Text = "";
            rbSmall.Checked = false;
            rbMedium.Checked = false;
            rbLarge.Checked = false;
            txtPromoCode.Text = "";
            lblResult.Text = "";
        }
    }
}