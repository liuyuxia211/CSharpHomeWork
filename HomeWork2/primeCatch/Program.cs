using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[101];
            for (int i = 2; i < num.Length-1; i++)
            {
                num[i] = i;//给数组赋值，数组下标等于对应数组元素的值
            }
            for (int i = 2; i <= 10; i++)//遍历从2到10的倍数
            {
                for (int j = 1; i*j<=num.Length-1; j++)//将为i的倍数的数组元素置零
                {
                    num[i * j] = 0;
                }
               
            }
            Console.WriteLine("2-100之间的素数有:");

            for (int i = 0; i < num.Length-1; i++)//输出不为0的数组元素即为素数
            {
                if (num[i]!=0)
                {
                     Console.WriteLine(num[i]);
                }
               
            }
            
            
        }
    }
}
