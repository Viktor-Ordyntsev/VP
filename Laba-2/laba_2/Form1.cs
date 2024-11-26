namespace laba_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            
            textBoxResult.Clear();
            try
            {
                
                int[,] matrix1 = GetMatrixFromInput(textBoxMatrix1.Text);
                int[,] matrix2 = GetMatrixFromInput(textBoxMatrix2.Text);

                Matrix3x3 m1 = new Matrix3x3(matrix1);
                Matrix3x3 m2 = new Matrix3x3(matrix2);

                
                if (radioButtonAdd.Checked)
                {
                    //Matrix3x3 result = Matrix3x3.Add(m1, m2);
                    Matrix3x3 result = m1 + m2;
                    DisplayMatrix(result);
                }
                else if (radioButtonMultiply.Checked)
                {
                    //Matrix3x3 result = Matrix3x3.Multiply(m1, m2);
                    Matrix3x3 result = m1 * m2;
                    DisplayMatrix(result);
                }
                else if (radioButtonDeterminant.Checked)
                {
                    int determinant1 = m1.Determinant();
                    int determinant2 = m2.Determinant();
                    textBoxResult.Text = $"Определитель матрицы 1: {determinant1}\r\nОпределитель матрицы 2: {determinant2}";
                }
                else if (radioButtonDiagonalSums.Checked)
                {
                    int mainDiagonalSum1 = m1.MainDiagonalSum();
                    int mainDiagonalSum2 = m2.MainDiagonalSum();
                    int secondaryDiagonalSum1 = m1.SecondaryDiagonalSum();
                    int secondaryDiagonalSum2 = m2.SecondaryDiagonalSum();

                    textBoxResult.Text = $"Сумма главной диагонали матрицы 1: {mainDiagonalSum1}\r\nСумма побочной диагонали матрицы 1: {secondaryDiagonalSum1}\r\n" +
                                         $"Сумма главной диагонали матрицы 2: {mainDiagonalSum2}\r\nСумма побочной диагонали матрицы 2: {secondaryDiagonalSum2}";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка: Проверьте правильность ввода матриц. Вводите только целые числа.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int[,] GetMatrixFromInput(string input)
        {
            var lines = input.Trim().Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            if (lines.Length != 3)
                throw new FormatException("Матрица должна содержать 3 строки.");

            int[,] matrix = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                var numbers = lines[i].Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (numbers.Length != 3)
                    throw new FormatException("Каждая строка матрицы должна содержать 3 числа.");

                for (int j = 0; j < 3; j++)
                {
                    matrix[i, j] = int.Parse(numbers[j]);
                }
            }
            return matrix;
        }
        
        private void DisplayMatrix(Matrix3x3 matrix)
        {
            textBoxResult.Clear();
            for (int i = 0; i < 3; i++)
            {
                textBoxResult.AppendText(string.Join(" ", matrix.ToString().Split(new[] { '\n' })[i]) + Environment.NewLine);
            }
        }
    }
}