namespace laba_2
{
    partial class Form1
    {
        private System.Windows.Forms.TextBox textBoxMatrix1;
        private System.Windows.Forms.TextBox textBoxMatrix2;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.RadioButton radioButtonAdd;
        private System.Windows.Forms.RadioButton radioButtonMultiply;
        private System.Windows.Forms.RadioButton radioButtonDeterminant;
        private System.Windows.Forms.RadioButton radioButtonDiagonalSums;
        private System.Windows.Forms.GroupBox groupBoxOperations;

        private void InitializeComponent()
        {
            textBoxMatrix1 = new TextBox();
            textBoxMatrix2 = new TextBox();
            textBoxResult = new TextBox();
            buttonExecute = new Button();
            radioButtonAdd = new RadioButton();
            radioButtonMultiply = new RadioButton();
            radioButtonDeterminant = new RadioButton();
            radioButtonDiagonalSums = new RadioButton();
            groupBoxOperations = new GroupBox();
            groupBoxOperations.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxMatrix1
            // 
            textBoxMatrix1.Location = new Point(43, 49);
            textBoxMatrix1.Margin = new Padding(6, 7, 6, 7);
            textBoxMatrix1.Multiline = true;
            textBoxMatrix1.Name = "textBoxMatrix1";
            textBoxMatrix1.Size = new Size(429, 240);
            textBoxMatrix1.TabIndex = 0;
            textBoxMatrix1.Text = "Введите первую матрицу";
            // 
            // textBoxMatrix2
            // 
            textBoxMatrix2.Location = new Point(722, 49);
            textBoxMatrix2.Margin = new Padding(6, 7, 6, 7);
            textBoxMatrix2.Multiline = true;
            textBoxMatrix2.Name = "textBoxMatrix2";
            textBoxMatrix2.Size = new Size(429, 240);
            textBoxMatrix2.TabIndex = 1;
            textBoxMatrix2.Text = "Введите вторую матрицу";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(43, 615);
            textBoxResult.Margin = new Padding(6, 7, 6, 7);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(1108, 240);
            textBoxResult.TabIndex = 2;
            textBoxResult.Text = "Результат";
            // 
            // buttonExecute
            // 
            buttonExecute.Location = new Point(467, 510);
            buttonExecute.Margin = new Padding(6, 7, 6, 7);
            buttonExecute.Name = "buttonExecute";
            buttonExecute.Size = new Size(260, 74);
            buttonExecute.TabIndex = 3;
            buttonExecute.Text = "Выполнить";
            buttonExecute.UseVisualStyleBackColor = true;
            buttonExecute.Click += buttonExecute_Click;
            // 
            // radioButtonAdd
            // 
            radioButtonAdd.Location = new Point(22, 49);
            radioButtonAdd.Margin = new Padding(6, 7, 6, 7);
            radioButtonAdd.Name = "radioButtonAdd";
            radioButtonAdd.Size = new Size(260, 59);
            radioButtonAdd.TabIndex = 5;
            radioButtonAdd.TabStop = true;
            radioButtonAdd.Text = "Сложение";
            radioButtonAdd.UseVisualStyleBackColor = true;
            // 
            // radioButtonMultiply
            // 
            radioButtonMultiply.Location = new Point(303, 49);
            radioButtonMultiply.Margin = new Padding(6, 7, 6, 7);
            radioButtonMultiply.Name = "radioButtonMultiply";
            radioButtonMultiply.Size = new Size(260, 59);
            radioButtonMultiply.TabIndex = 6;
            radioButtonMultiply.TabStop = true;
            radioButtonMultiply.Text = "Умножение";
            radioButtonMultiply.UseVisualStyleBackColor = true;
            // 
            // radioButtonDeterminant
            // 
            radioButtonDeterminant.Location = new Point(585, 49);
            radioButtonDeterminant.Margin = new Padding(6, 7, 6, 7);
            radioButtonDeterminant.Name = "radioButtonDeterminant";
            radioButtonDeterminant.Size = new Size(260, 59);
            radioButtonDeterminant.TabIndex = 7;
            radioButtonDeterminant.TabStop = true;
            radioButtonDeterminant.Text = "Определитель";
            radioButtonDeterminant.UseVisualStyleBackColor = true;
            // 
            // radioButtonDiagonalSums
            // 
            radioButtonDiagonalSums.Location = new Point(845, 49);
            radioButtonDiagonalSums.Margin = new Padding(6, 7, 6, 7);
            radioButtonDiagonalSums.Name = "radioButtonDiagonalSums";
            radioButtonDiagonalSums.Size = new Size(325, 59);
            radioButtonDiagonalSums.TabIndex = 8;
            radioButtonDiagonalSums.TabStop = true;
            radioButtonDiagonalSums.Text = "Сумма диагоналей";
            radioButtonDiagonalSums.UseVisualStyleBackColor = true;
            // 
            // groupBoxOperations
            // 
            groupBoxOperations.Controls.Add(radioButtonAdd);
            groupBoxOperations.Controls.Add(radioButtonMultiply);
            groupBoxOperations.Controls.Add(radioButtonDeterminant);
            groupBoxOperations.Controls.Add(radioButtonDiagonalSums);
            groupBoxOperations.Location = new Point(43, 345);
            groupBoxOperations.Margin = new Padding(6, 7, 6, 7);
            groupBoxOperations.Name = "groupBoxOperations";
            groupBoxOperations.Padding = new Padding(6, 7, 6, 7);
            groupBoxOperations.Size = new Size(1108, 123);
            groupBoxOperations.TabIndex = 4;
            groupBoxOperations.TabStop = false;
            groupBoxOperations.Text = "Операции";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1202, 985);
            Controls.Add(textBoxMatrix1);
            Controls.Add(textBoxMatrix2);
            Controls.Add(textBoxResult);
            Controls.Add(buttonExecute);
            Controls.Add(groupBoxOperations);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Form1";
            Text = "Операции с матрицами 3x3";
            groupBoxOperations.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}