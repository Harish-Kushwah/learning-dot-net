﻿using System;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hospital_OPD_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new string[] { "General", "Cardiology", "Orthopedics", "Neurology" });
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) || comboBox1.SelectedIndex == -1 ||
                comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string gender = radioButton1.Checked ? "Male" : radioButton2.Checked ? "Female" : "Other";
            string details = $"Patient Name: {textBox1.Text}\nAge: {textBox2.Text}\nGender: {gender}\n" +
                             $"Contact: {textBox3.Text}\nDepartment: {comboBox1.SelectedItem}\n" +
                             $"Doctor: {comboBox2.SelectedItem}\nAppointment Date: {dateTimePicker1.Value.ToShortDateString()}\n"
                             ;

            label11.Text = "Registration Successful!";
            MessageBox.Show(details, "Registration Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            radioButton1.Checked = radioButton2.Checked = radioButton3.Checked = false;
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Today;
            label11.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            switch (comboBox1.SelectedItem.ToString())
            {
                case "General":
                    comboBox2.Items.AddRange(new string[] { "Dr. Sharma", "Dr. Patel" });
                    break;
                case "Cardiology":
                    comboBox2.Items.AddRange(new string[] { "Dr. Mehta", "Dr. Verma" });
                    break;
                case "Orthopedics":
                    comboBox2.Items.AddRange(new string[] { "Dr. Reddy", "Dr. Bansal" });
                    break;
                case "Neurology":
                    comboBox2.Items.AddRange(new string[] { "Dr. Ahuja", "Dr. Desai" });
                    break;
            }
            comboBox2.SelectedIndex = 0;
        }


    }
}