using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8
{
    public class OrderItem
    {
        public string Name { get; set; }
        public int Prize { get; set; }
        public int Num { get; set; }
        public OrderItem(string name, int num, int prize)
        {
            Name = name;
            Num = num;
            Prize = prize;
        }
        public OrderItem() {
            Name = "";
            Prize = new int()   ;
            Num = new int();
        }


        public override string ToString()
        {
            return "\n" + Name + "               " + Prize + "              " + Num;
        }

        public override bool Equals(object obj)
        {
            var item = obj as OrderItem;
            return item != null &&
                   Name == item.Name &&
                   Prize == item.Prize &&
                   Num == item.Num;
        }

        public override int GetHashCode()
        {
            var hashCode = -1280830752;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + Prize.GetHashCode();
            hashCode = hashCode * -1521134295 + Num.GetHashCode();
            return hashCode;
        }
    }
}
