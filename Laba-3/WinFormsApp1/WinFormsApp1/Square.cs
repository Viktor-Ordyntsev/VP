using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Square : Equation
    {
        private double a, b, c;
        private double? root1, root2;

        public Square(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override void CalculateRoots()
        {
            double discriminant = b * b - 4 * a * c;

            if (discriminant > 0)
            {
                root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            }
            else if (discriminant == 0)
            {
                root1 = root2 = -b / (2 * a);
            }
            else
            {
                root1 = root2 = null;
            }
        }

        public override void DisplayResult()
        {
            if (root1.HasValue && root2.HasValue)
            {
                if (root1 == root2)
                    MessageBox.Show($"Корень квадратного уравнения: x = {root1.Value}");
                else
                    MessageBox.Show($"Корни квадратного уравнения: x1 = {root1.Value}, x2 = {root2.Value}");
            }
            else
            {
                MessageBox.Show("Уравнение не имеет действительных корней");
            }
        }
    }
}
