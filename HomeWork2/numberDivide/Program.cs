using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evenNumber
{
    class Program
    {
         static int jugde(string input, int num) //判断输入是否正确
        {
            if (int.TryParse(input, out num))
            {
               
                return num;
            }
            else
            {
                Console.WriteLine("Input erorr, please try again! ");
                return 0;
            }
        }

        static void Main(string[] args)//主函数    
        {
            int inputNum = 0;
            string str = "";
            Console.WriteLine("Please input your number:");
            str = Console.ReadLine();
                while (jugde(str,inputNum)==0)//调用judge函数判断输入直到输入正确退出循环
                {
                str = Console.ReadLine();
                }
            int.TryParse(str,out inputNum);
            Console.WriteLine("该数字的因数有：");

            for (int i = 2; i <= inputNum;)//遍历输出因数
            {
                if (inputNum % i == 0)
                {
                    Console.WriteLine(i);
                    inputNum /= i;
                }
                else i++;
            }
        }
    }
}
