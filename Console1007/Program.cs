using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console1007
{
    internal class Program
    {
       static void RightTriangle()
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

      static  void LsoscelesTriangle()
        {
            Console.Write("請輸入底邊星號個數 N（建議輸入奇數）：");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("請輸入大於 0 的整數。");
                return;
            }

            // 以 N 為底，建立等腰三角形
            int height = (n + 1) / 2;  // 高度 = (N+1)/2，保證底為 N
            for (int i = 1; i <= height; i++)
            {
                int starCount = 2 * i - 1;               // 每列的星號數
                int spaceCount = (n - starCount) / 2;    // 左右空白數
                Console.WriteLine(new string(' ', spaceCount) + new string('*', starCount));
            }
            Console.Read();
        }

        static void Main(string[] args)
        {
            //LsoscelesTriangle();
            RightTriangle();
            //testing version rollback
        }
    }
}
