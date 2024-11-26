using System.Drawing.Drawing2D;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void buttonSolve_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = 0;

            // Проверяем заполнено ли поле A
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                // Если поле A заполнено, пытаемся преобразовать его в число
                if (!double.TryParse(textBox1.Text, out a))
                {
                    MessageBox.Show("Некорректное значение для коэффициента A.");
                    return;
                }
            }

            // Проверяем и преобразуем значения для B и C
            if (!double.TryParse(textBox2.Text, out b) || !double.TryParse(textBox3.Text, out c))
            {
                MessageBox.Show("Введите правильные числовые значения для коэффициентов B и C.");
                return;
            }
            
          

            Equation equation;

            // Если a = 0, решаем как линейное уравнение bx + c = 0
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                equation = new Linear(b, c);
            }
            // Иначе решаем как квадратное уравнение ax^2 + bx + c = 0
            else
            {
                
                equation = new Square(a, b, c);
            }

            equation.CalculateRoots();
            equation.DisplayResult();
        }
    }
}