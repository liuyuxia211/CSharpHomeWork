using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape1
{
    //矩形类定义，继承Ijudge接口
    class Rectangle : IJudge
    {
        public double Width { get; set; }
        public double Length { get; set; }

        public double Area//面积属性
        {
            get
            {
                return Width * Length;//返回面积
            }
        }
        public bool Judge()//判断函数
        {
            if (Width > 0 && Length > 0)
            {
                Console.WriteLine($"Width:{Width},Length:{Length},this is a rectangle");
                return true;
            }
            else
            {
                Console.WriteLine($"Width:{Width},Length:{Length},this is not a rectangle");
                return false;
            }
        }
    }

}
