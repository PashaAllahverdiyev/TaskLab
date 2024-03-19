//Task1
internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("eded yaz: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int num2;
        Console.Write("Ters yazilisi: ");
        while (num >0)
        {
            num2 = num % 10;
            Console.Write(num2);
            num /= 10;
        }
        
    }
}
