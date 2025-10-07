using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console1007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入正整數 N：");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("請輸入大於 0 的正整數。");
                return;
            }

            // 直角三角形：第 i 列印 i 個 *
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(new string('*', i));
            }
            Console.Read();
        }
    }
}
