namespace ToDoListApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string task = inputBox.Text.Trim(); // Get text and remove unnecessary spaces

            if (!string.IsNullOrEmpty(task))
            {
                alltaskBox.Items.Add(task); // Add task to list
                inputBox.Clear(); // Clear input box after adding task
                inputBox.Focus(); // Bring focus back to input box for a better UX
            }
            else
            {
                MessageBox.Show("Please enter a task before adding.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            alltaskBox.Items.Clear();
        }
        private void setInputText(object sender, EventArgs e)
        {
            inputBox.Focus();
            inputBox.Text = "Enter your task...";
        }
        private void clearInputText(object sender, EventArgs e)
        {
            inputBox.Focus();
            inputBox.Text = "Enter your task...";
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void addButton_Click_1(object sender, EventArgs e)
        {

        }
    }
}


