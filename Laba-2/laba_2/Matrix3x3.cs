namespace laba_2
{
    public class Matrix3x3
    {
        private int[,] matrix;

        
        public Matrix3x3(int[,] matrix)
        {
            if (matrix.GetLength(0) != 3 || matrix.GetLength(1) != 3)
                throw new ArgumentException("Матрица должна быть размером 3х3.");

            this.matrix = matrix;
        }


        //public static Matrix3x3 Add(Matrix3x3 m1, Matrix3x3 m2)
        //{
        //    int[,] result = new int[3, 3];
        //    for (int i = 0; i < 3; i++)
        //    {
        //        for (int j = 0; j < 3; j++)
        //        {
        //            result[i, j] = m1.matrix[i, j] + m2.matrix[i, j];
        //        }
        //    }
        //    return new Matrix3x3(result);
        //}

        public static Matrix3x3 operator +(Matrix3x3 m1, Matrix3x3 m2)
        {
            int[,] result = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    result[i, j] = m1.matrix[i, j] + m2.matrix[i, j];
                }
            }
            return new Matrix3x3(result);
        }


        //public static Matrix3x3 Multiply(Matrix3x3 m1, Matrix3x3 m2)
        //{
        //    int[,] result = new int[3, 3];
        //    for (int i = 0; i < 3; i++)
        //    {
        //        for (int j = 0; j < 3; j++)
        //        {
        //            result[i, j] = 0;
        //            for (int k = 0; k < 3; k++)
        //            {
        //                result[i, j] += m1.matrix[i, k] * m2.matrix[k, j];
        //            }
        //        }
        //    }
        //    return new Matrix3x3(result);
        //}

        public static Matrix3x3 operator *(Matrix3x3 m1, Matrix3x3 m2) 
        {
            int[,] result = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    result[i, j] = 0;
                    for (int k = 0; k < 3; k++)
                    {
                        result[i, j] += m1.matrix[i, k] * m2.matrix[k, j];
                    }
                }
            }
            return new Matrix3x3(result);
        }


        public int Determinant()
        {
            return matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1]) -
                   matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0]) +
                   matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);
        }


        public int MainDiagonalSum()
        {
            return matrix[0, 0] + matrix[1, 1] + matrix[2, 2];
        }

        
        public int SecondaryDiagonalSum()
        {
            return matrix[0, 2] + matrix[1, 1] + matrix[2, 0];
        }

        
        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    result += matrix[i, j] + "\t";
                }
                result += "\n";
            }
            return result;
        }
    }
}