using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape1
{   //三角形类定义，继承Ijudge接口
    class Triangle : IJudge
    {
        public double EdgeA { get; set; }
        public double EdgeB { get; set; }
        public double EdgeC { get; set; }

        public double CosA//余弦属性
        {
            get
            {
                return (EdgeB * EdgeB + EdgeC * EdgeC - EdgeA * EdgeA) / (2 * EdgeB * EdgeC);
            }
        }
        public double Area//面积属性
        {
            get
            {
                return Math.Sqrt(1 - CosA * CosA) * EdgeB * EdgeC / 2;  //返回面积
            }
        }
        public bool Judge()//判断函数
        {
            if (CosA > -1 && CosA < 1)
            {
                Console.WriteLine($"EdgeA:{EdgeA},EdgeB:{EdgeB},EdgeC;{EdgeC},this is a triangle");
                return true;
            }
            else
            {
                Console.WriteLine($"EdgeA:{EdgeA},EdgeB:{EdgeB},EdgeC;{EdgeC},this is not a triangle");
                return false;
            }
        }
    }
}
