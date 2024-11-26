namespace WinFormsApp1
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(85, 84);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "a";
            textBox1.Size = new Size(62, 39);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(243, 84);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "b";
            textBox2.Size = new Size(62, 39);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(372, 84);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "c";
            textBox3.Size = new Size(62, 39);
            textBox3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(153, 87);
            label1.Name = "label1";
            label1.Size = new Size(84, 32);
            label1.TabIndex = 3;
            label1.Text = "x^2  +";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(311, 91);
            label2.Name = "label2";
            label2.Size = new Size(55, 32);
            label2.TabIndex = 4;
            label2.Text = "x  +";
            // 
            // button1
            // 
            button1.Location = new Point(117, 157);
            button1.Name = "button1";
            button1.Size = new Size(249, 86);
            button1.TabIndex = 5;
            button1.Text = "Result";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonSolve_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 264);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}
