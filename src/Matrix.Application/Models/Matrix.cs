using System.Numerics;

namespace Matrix.Application.Models
{
    public class Matrix<T> where T : struct, INumber<T>
    {
        private readonly T[,] _matrixArray;
        private T? _sum;

        public int Rows {get;}
        public int Columns {get;}
        
        public Matrix(int rows, int columns)
        {
            if (rows <= 0 || columns <= 0)
            {
                string dimension = (rows <= 0 && columns <= 0) ? "Rows and columns" : rows <= 0 ? "Rows" : "Columns";
                throw new ArgumentException($"{dimension} should be more than 0.");
            }
            
            Rows = rows;
            Columns = columns;
            _matrixArray = new T[rows, Columns];
            FillMatrix();
        }

        public Matrix(int size): this(size, size){}

        private void FillMatrix()
        {
            Random random = new Random();
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    _matrixArray[i, j] = T.CreateChecked(random.Next(0, 101));
                }
            }
        }

        public T GetTrace()
        {
            if (_sum != null)
            {
                return (T)_sum;
            }

            _sum = T.Zero;
            int size = Math.Min(Rows, Columns);

            for (int i = 0; i < size; i++)
            {
                _sum += _matrixArray[i, i];
            }

            return (T)_sum;
        }
        
        public T GetValue(int row, int columns) => _matrixArray[row, columns];
    }
}