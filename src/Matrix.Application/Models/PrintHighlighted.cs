namespace Matrix.Application.Models
{
    public class PrintHighlighted
    {
        public void Printext(string text)
        {
            var initColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(text);
            Console.ForegroundColor = initColor;
        }
    }
}