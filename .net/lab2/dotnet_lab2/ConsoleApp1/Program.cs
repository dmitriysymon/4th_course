using System;
using System.Text;

namespace lab2
{
    public static class Program
    {
        public static void task1()
        {
            string example = "Доброго ранку,світ";
            char x = 'о';
            Console.WriteLine($"{example}\nК-сть символів '{x}' у рядку: {dll_lab2.Class1.Count_string(x,example)}\n\n");
        }
        public static void task2()
        {
            int []arr = {1,2,3,4};
            Console.WriteLine($"a={arr[0]},b={arr[1]},c={arr[2]},d={arr[3]}");
            dll_lab2.Class1.Swap(ref arr[0], ref arr[1], ref arr[2],ref arr[3]);
            Console.WriteLine($"a={arr[0]},b={arr[1]},c={arr[2]},d={arr[3]}");
        }
        public static void Main()
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;
            task1();
            task2();
        }
    }
}