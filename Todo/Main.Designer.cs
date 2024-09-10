namespace Todo
{
    partial class Main
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
            button_Add_Todo = new Button();
            textBox_Title_Input = new TextBox();
            textBox_Description_Input = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            SuspendLayout();
            // 
            // button_Add_Todo
            // 
            button_Add_Todo.Location = new Point(422, 76);
            button_Add_Todo.Name = "button_Add_Todo";
            button_Add_Todo.Size = new Size(131, 40);
            button_Add_Todo.TabIndex = 0;
            button_Add_Todo.Text = "Add";
            button_Add_Todo.UseVisualStyleBackColor = true;
            button_Add_Todo.Click += button_Add_Todo_Click;
            // 
            // textBox_Title_Input
            // 
            textBox_Title_Input.Location = new Point(12, 76);
            textBox_Title_Input.Name = "textBox_Title_Input";
            textBox_Title_Input.Size = new Size(175, 35);
            textBox_Title_Input.TabIndex = 1;
            // 
            // textBox_Description_Input
            // 
            textBox_Description_Input.Location = new Point(216, 76);
            textBox_Description_Input.Name = "textBox_Description_Input";
            textBox_Description_Input.Size = new Size(175, 35);
            textBox_Description_Input.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 31);
            label1.Name = "label1";
            label1.Size = new Size(52, 30);
            label1.TabIndex = 3;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(249, 31);
            label2.Name = "label2";
            label2.Size = new Size(118, 30);
            label2.TabIndex = 4;
            label2.Text = "Description";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Location = new Point(12, 135);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(776, 293);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_Description_Input);
            Controls.Add(textBox_Title_Input);
            Controls.Add(button_Add_Todo);
            Name = "Main";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Add_Todo;
        private TextBox textBox_Title_Input;
        private TextBox textBox_Description_Input;
        private Label label1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
