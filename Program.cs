using System.Text;

namespace Homework;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        //Завдання 2

        Console.WriteLine("Введіть число:");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(Cirakuz(number));

        int Cirakuz(int number)
        {
            if (number % 2 == 0)
            {
                return Cirakuz(number / 2);
            }
            else if(number % 2 == 1 && number > 1)
            {
                return Cirakuz(number * 3 + 1);
            }
            return number;
        }
    }
}