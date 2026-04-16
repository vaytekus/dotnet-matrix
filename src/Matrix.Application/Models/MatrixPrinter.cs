using System.Numerics;

namespace Matrix.Application.Models
{
    public class MatrixPrinter
    {
        private readonly PrintHighlighted _highlighted = new();

        public void PrintMatrix<T>(Matrix<T> matrix) where T : struct, INumber<T>
        {
            for (int i = 0; i < matrix.Rows; i++)
            {
                int counter = i;
                for (int j = 0; j < matrix.Columns; j++)
                {
                    if (counter == j)
                    {
                        _highlighted.Printext(matrix.GetValue(i, j) + "\t");
                    }
                    else
                    {
                        Console.Write(matrix.GetValue(i, j) + "\t"); 
                    }
                }
                Console.WriteLine();
            }
        }
    }
}