

using Matrix.Application.Models;

namespace Matrix.Application;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Do you want create square matrix? (y/n)");
        bool isSquare = Console.ReadLine().ToLower().Equals("y");

        Matrix<int> matrix;

        if (isSquare)
        {
            Console.WriteLine("Set square size: ");
            int size = int.Parse(Console.ReadLine());
            matrix = new Matrix<int>(size);
        }
        else
        {
            Console.WriteLine("Set rows quantity: ");
            int rows = int.Parse(Console.ReadLine());
        
            Console.WriteLine("Set columns quantity: ");
            int column = int.Parse(Console.ReadLine());
            
            matrix = new Matrix<int>(rows, column);
        }
        
        MatrixPrinter printer = new();
        printer.PrintMatrix(matrix);

        int result = matrix.GetTrace();
        Console.WriteLine($"Matrix trace - {result}");
    }
}
