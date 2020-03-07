using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape1
{
    interface IJudge//判断图形接口
    {
        bool Judge();//判断函数
        double Area { get; }//面积属性
    }
    class JudgeShape//图形判断类，专门用于调用各个图形的判断函数
    {
        public static bool IsShape(IJudge shape)//静态函数，用于调用判断函数
        {
            return shape.Judge();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            double sumArea = 0;
            Random random = new Random();//随机数
            for (int i = 1; i <= 10;)
            {
                num = random.Next(1, 4);
                IJudge shape = ShapeFactory.CreateShape(num);
                if (JudgeShape.IsShape(shape))//当生成的图形满足条件时，才输出到总面积，否则不输出
                {
                    Console.WriteLine("Area is :" + shape.Area);
                    sumArea += shape.Area;
                    i++;
                }
            }
            Console.WriteLine("总面积:" + sumArea);
        }
    }
}

