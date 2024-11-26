namespace SortedListExample
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
            btnAdd = new Button();
            btnMax = new Button();
            label2 = new Label();
            lblCount = new Label();
            btnMin = new Button();
            btnGet = new Button();
            lblList = new Label();
            txtInput = new TextBox();
            label3 = new Label();
            lblelement = new Label();
            label4 = new Label();
            txtIndex = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(22, 373);
            label1.Name = "label1";
            label1.Size = new Size(313, 59);
            label1.TabIndex = 2;
            label1.Text = "Count element:";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(176, 125);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 64);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnMax
            // 
            btnMax.Location = new Point(31, 270);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(150, 65);
            btnMax.TabIndex = 4;
            btnMax.Text = "Max";
            btnMax.UseVisualStyleBackColor = true;
            btnMax.Click += btnMax_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(542, 340);
            label2.Name = "label2";
            label2.Size = new Size(0, 32);
            label2.TabIndex = 5;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Segoe UI", 16F);
            lblCount.Location = new Point(341, 373);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(48, 59);
            lblCount.TabIndex = 6;
            lblCount.Text = "0";
            // 
            // btnMin
            // 
            btnMin.Location = new Point(239, 270);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(150, 65);
            btnMin.TabIndex = 7;
            btnMin.Text = "Min";
            btnMin.UseVisualStyleBackColor = true;
            btnMin.Click += btnMin_Click;
            // 
            // btnGet
            // 
            btnGet.Location = new Point(514, 271);
            btnGet.Name = "btnGet";
            btnGet.Size = new Size(150, 64);
            btnGet.TabIndex = 8;
            btnGet.Text = "Get";
            btnGet.UseVisualStyleBackColor = true;
            btnGet.Click += btnGet_Click;
            // 
            // lblList
            // 
            lblList.AutoSize = true;
            lblList.Font = new Font("Segoe UI", 16F);
            lblList.Location = new Point(485, 30);
            lblList.Name = "lblList";
            lblList.Size = new Size(48, 59);
            lblList.TabIndex = 9;
            lblList.Text = "0";
            // 
            // txtInput
            // 
            txtInput.Font = new Font("Segoe UI", 15F);
            txtInput.Location = new Point(399, 125);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(265, 61);
            txtInput.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(229, 21);
            label3.Name = "label3";
            label3.Size = new Size(97, 59);
            label3.TabIndex = 11;
            label3.Text = "List:";
            // 
            // lblelement
            // 
            lblelement.AutoSize = true;
            lblelement.Font = new Font("Segoe UI", 16F);
            lblelement.Location = new Point(714, 360);
            lblelement.Name = "lblelement";
            lblelement.Size = new Size(48, 59);
            lblelement.TabIndex = 12;
            lblelement.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F);
            label4.Location = new Point(505, 360);
            label4.Name = "label4";
            label4.Size = new Size(186, 59);
            label4.TabIndex = 13;
            label4.Text = "element:";
            // 
            // txtIndex
            // 
            txtIndex.Font = new Font("Segoe UI", 9F);
            txtIndex.Location = new Point(690, 283);
            txtIndex.Name = "txtIndex";
            txtIndex.PlaceholderText = "Index";
            txtIndex.Size = new Size(72, 39);
            txtIndex.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtIndex);
            Controls.Add(label4);
            Controls.Add(lblelement);
            Controls.Add(label3);
            Controls.Add(txtInput);
            Controls.Add(lblList);
            Controls.Add(btnGet);
            Controls.Add(btnMin);
            Controls.Add(lblCount);
            Controls.Add(label2);
            Controls.Add(btnMax);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnMax_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TextBox txtInput;
        private ListBox listBox1;
        private Label label1;
        private Button btnAdd;
        private Button btnMax;
        private Label label2;
        private Label lblCount;
        private Button btnMin;
        private Button btnGet;
        private Label lblList;
        private Label label3;
        private Label lblelement;
        private Label label4;
        private TextBox txtIndex;
    }
}
