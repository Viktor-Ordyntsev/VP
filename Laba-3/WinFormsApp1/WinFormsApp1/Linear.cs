using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Linear : Equation
    {
        private double b, c;
        private double? root;

        public Linear(double b, double c)
        {
            this.b = b;
            this.c = c;
        }

        public override void CalculateRoots()
        {
            if (b != 0)
                root = -c / b;
            else
                root = null;
        }

        public override void DisplayResult()
        {
            if (root.HasValue)
                MessageBox.Show($"Корень линейного уравнения: x = {root.Value}");
            else
                MessageBox.Show("Уравнение не имеет корней (b = 0)");
        }
    }
}
