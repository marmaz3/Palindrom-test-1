internal class Program
{
    private static void Main(string[] args)
    {
        string slowo;
            bool isPalindrom = true;
        slowo = Console.ReadLine().Replace(" ", string.Empty).ToLower();
        for (int i = 0; i < slowo.Length / 2; i++)
        {
            if (slowo[i] != slowo[slowo.Length - 1 - i])
            {
                isPalindrom = false;
                break;
            }
        }
        if (isPalindrom)
        {
            Console.WriteLine("Tak");
        }
        else
        {
            Console.WriteLine("Nie");
        }

    }
} 
    
