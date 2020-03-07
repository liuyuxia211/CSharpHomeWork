using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape1
{
    class ShapeFactory
    {
        public static IJudge CreateShape(int tpye)
        {
            Random random = new Random();

            switch (tpye)
            {
                case 1:
                    return new Rectangle() { Width = random.Next(0, 100), Length = random.Next(0, 100) };
                //创建返回一个矩形，random.Next函数返回的是非负值，不用进一步判断

                case 2:
                    return new Square() { Side = random.Next(0, 100) };
                //创建返回一个正方形，random.Next函数返回的是非负值，不用进一步判断

                case 3:
                    //需要判断三角形是否成立，不成立需要重新生成
                    return new Triangle() { EdgeA = random.Next(1, 100), EdgeB = random.Next(1, 100), EdgeC = random.Next(1, 100) };

                default:
                    return new Rectangle() { Width = 1, Length = 1 };
                    //其他情况默认创建一个矩形
            }
        }
    }
}
