namespace ToDoListApp
{
    partial class Form1
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
            label1 = new Label();
            inputBox = new TextBox();
            addButton = new Button();
            label2 = new Label();
            alltaskBox = new ListBox();
            deleteBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(365, 32);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 0;
            label1.Text = "To Do App";
            label1.Click += label1_Click;
            // 
            // inputBox
            // 
            inputBox.Location = new Point(52, 84);
            inputBox.Name = "inputBox";
            inputBox.Size = new Size(524, 27);
            inputBox.TabIndex = 1;
            inputBox.Text = "Enter you tasks...";
            // 
            // addButton
            // 
            addButton.Location = new Point(582, 84);
            addButton.Name = "addButton";
            addButton.Size = new Size(94, 29);
            addButton.TabIndex = 2;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 135);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 3;
            label2.Text = "Tasks";
            label2.Click += label2_Click;
            // 
            // alltaskBox
            // 
            alltaskBox.FormattingEnabled = true;
            alltaskBox.Location = new Point(52, 171);
            alltaskBox.Name = "alltaskBox";
            alltaskBox.Size = new Size(660, 164);
            alltaskBox.TabIndex = 4;
            alltaskBox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(682, 84);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(94, 29);
            deleteBtn.TabIndex = 5;
            deleteBtn.Text = "Delete Task";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(deleteBtn);
            Controls.Add(alltaskBox);
            Controls.Add(label2);
            Controls.Add(addButton);
            Controls.Add(inputBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "ToDoApplication";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox inputBox;
        private Button addButton;
        private Label label2;
        private ListBox alltaskBox;
        private Button deleteBtn;
    }
}
