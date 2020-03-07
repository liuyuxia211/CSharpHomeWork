using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape1
{   //正方形定义，继承Ijudge接口
    class Square : IJudge
    {
        public double Side { get; set; }

        public double Area//面积属性
        {
            get
            {
                return Side * Side;//返回面积

            }
        }
        public bool Judge()//judge函数，判断图形是否合法
        {
            if (Side > 0)
            {
                Console.WriteLine($"Side:{Side},this is a square");
                return true;
            }
            else
            {
                Console.WriteLine($"Side:{Side},this is not a squre!");
                return false;
            }
        }
    }
}
