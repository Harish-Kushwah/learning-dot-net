namespace Calculator
{
    public partial class Form1 : Form
    {
        private TextBox txtDisplay;
        private Button[] btnNumbers;
        private Button btnDecimal;
        private Button btnAdd;
        private Button btnSubtract;
        private Button btnMultiply;
        private Button btnDivide;
        private Button btnEquals;
        private Button btnClear;

        private double firstNumber = 0;
        private string operation = "";
        private bool newNumber = true;
        private string currentDisplay = "0";

        public Form1()
        {
            InitializeComponent();
            InitializeCalculatorControls();
        }

        private void InitializeCalculatorControls()
        {
            this.Width = 300;
            this.Height = 400;
            this.Text = "Calculator";

            txtDisplay = new TextBox
            {
                Location = new Point(20, 20),
                Width = 240,
                Height = 40,
                Text = "0",
                TextAlign = HorizontalAlignment.Right,
                Font = new Font("Arial", 16)
                // Removed ReadOnly = true to allow updates
            };

            btnNumbers = new Button[10];
            for (int i = 0; i < 10; i++)
            {
                btnNumbers[i] = new Button
                {
                    Text = i.ToString(),
                    Width = 50,
                    Height = 50,
                    Font = new Font("Arial", 12)
                };
                btnNumbers[i].Click += NumberButton_Click;
            }

            btnNumbers[7].Location = new Point(20, 80);
            btnNumbers[8].Location = new Point(80, 80);
            btnNumbers[9].Location = new Point(140, 80);
            btnNumbers[4].Location = new Point(20, 140);
            btnNumbers[5].Location = new Point(80, 140);
            btnNumbers[6].Location = new Point(140, 140);
            btnNumbers[1].Location = new Point(20, 200);
            btnNumbers[2].Location = new Point(80, 200);
            btnNumbers[3].Location = new Point(140, 200);
            btnNumbers[0].Location = new Point(80, 260);

            btnAdd = new Button { Text = "+", Width = 50, Height = 50, Location = new Point(200, 80), Font = new Font("Arial", 12) };
            btnSubtract = new Button { Text = "-", Width = 50, Height = 50, Location = new Point(200, 140), Font = new Font("Arial", 12) };
            btnMultiply = new Button { Text = "×", Width = 50, Height = 50, Location = new Point(200, 200), Font = new Font("Arial", 12) };
            btnDivide = new Button { Text = "÷", Width = 50, Height = 50, Location = new Point(200, 260), Font = new Font("Arial", 12) };
            btnEquals = new Button { Text = "=", Width = 50, Height = 50, Location = new Point(140, 260), Font = new Font("Arial", 12) };
            btnDecimal = new Button { Text = ".", Width = 50, Height = 50, Location = new Point(20, 260), Font = new Font("Arial", 12) };
            btnClear = new Button { Text = "C", Width = 50, Height = 50, Location = new Point(20, 320), Font = new Font("Arial", 12) };

            this.Controls.Add(txtDisplay);
            foreach (Button btn in btnNumbers) this.Controls.Add(btn);
            this.Controls.Add(btnAdd);
            this.Controls.Add(btnSubtract);
            this.Controls.Add(btnMultiply);
            this.Controls.Add(btnDivide);
            this.Controls.Add(btnEquals);
            this.Controls.Add(btnDecimal);
            this.Controls.Add(btnClear);

            btnAdd.Click += Operation_Click;
            btnSubtract.Click += Operation_Click;
            btnMultiply.Click += Operation_Click;
            btnDivide.Click += Operation_Click;
            btnEquals.Click += Equals_Click;
            btnDecimal.Click += Decimal_Click;
            btnClear.Click += Clear_Click;
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (newNumber)
            {
                currentDisplay = btn.Text;
                newNumber = false;
            }
            else
            {
                currentDisplay += btn.Text;
            }
            txtDisplay.Text = currentDisplay;
        }

        private void Decimal_Click(object sender, EventArgs e)
        {
            if (!currentDisplay.Contains("."))
            {
                currentDisplay += ".";
                txtDisplay.Text = currentDisplay;
            }
        }

        private void Operation_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            // If there's a previous operation, calculate it first
            if (!string.IsNullOrEmpty(operation) && !newNumber)
            {
                Equals_Click(null, null);
            }

            firstNumber = double.Parse(currentDisplay);
            operation = btn.Text;
            txtDisplay.Text = $"{firstNumber} {operation}";
            newNumber = true;
        }

        private void Equals_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(operation)) return;

            double secondNumber;
            if (!double.TryParse(currentDisplay, out secondNumber))
                return;

            double result = 0;
            try
            {
                switch (operation)
                {
                    case "+":
                        result = firstNumber + secondNumber;
                        break;
                    case "-":
                        result = firstNumber - secondNumber;
                        break;
                    case "×":
                        result = firstNumber * secondNumber;
                        break;
                    case "÷":
                        if (secondNumber == 0)
                        {
                            txtDisplay.Text = "Error: Divide by zero";
                            ResetCalculator();
                            return;
                        }
                        result = firstNumber / secondNumber;
                        break;
                }
                currentDisplay = result.ToString();
                txtDisplay.Text = currentDisplay;
                firstNumber = result;
                operation = "";
                newNumber = true;
            }
            catch (Exception)
            {
                txtDisplay.Text = "Error";
                ResetCalculator();
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            ResetCalculator();
            txtDisplay.Text = "0";
        }

        private void ResetCalculator()
        {
            currentDisplay = "0";
            firstNumber = 0;
            operation = "";
            newNumber = true;
        }
    }
}