namespace Person;

public class Hello
{
    public static void HelloH() => Console.WriteLine("Hello");
    public static void HelloHowAreYu() => Console.WriteLine("Hello How R U");
    public void Display() => Console.WriteLine("Привевт");

    public int Add(int x, int y) => x + y;
    public int Subtract(int x, int y) => x - y;
    public int Multiply(int x, int y) => x * y;
}