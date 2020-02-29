using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum
{
    class Program
    {
        static double[] outNum(int[] inNum)
        {
            double [] outnum =new double [4];//outnum用于保存结果
            outnum[0] = double.NegativeInfinity;//用来比较保存最大值，初始值设为最小
            outnum[1] = double.PositiveInfinity;//用来比较保存最小值，初始值设为最大
            for (int i = 0; i <= inNum.Length-1; i++)
            {
                outnum[0] = inNum[i] > outnum[0] ? inNum[i] : outnum[0];//计算数组中的最大值
                outnum[1] = inNum[i] < outnum[1] ? inNum[i] : outnum[1];//计算数组中的最小值
                outnum[2] += inNum[i];//计算数组值的和
                outnum[3] += inNum[i];

            }
            outnum[3] = outnum[3] / inNum.Length;//计算平均值
            return outnum;//返回结果
        }
        static  int[] jugde(int n)//用于输入数据
        {
            int[] number = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"请输入第{i+1}个数字");
                while (!int.TryParse(Console.ReadLine(), out number[i]))
                {
                    Console.WriteLine("Please try again!");//输入错误时报错
                }
            }
            return number;//返回数组

            
        }

        static void Main(string[] args)
        {
            int inputNum = 0;
            double [] result;
            Console.WriteLine("请输入你需要计算的数据个数：");
            while (!int.TryParse(Console.ReadLine(),out inputNum)||inputNum<0)
            {
                Console.WriteLine("输入错误，请重试");
            }
            result=outNum(jugde(inputNum));
            Console.WriteLine($"最大值：{ result[0]},最小值：{result[1]},和：{result[2]},平均值：{result[3]}");

            
        }
    }
}
