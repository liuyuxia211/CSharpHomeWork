using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    public class CLOCK                  //CLOCK类
    {
        public int interval              //interval 属性，代表每次alarm的间隔时间
        {
            get;set;
        }
        public int currentTime { get; set; }   //属性currentTime，代表clock的当前时间

        public int maxtime { get; set; }

        public delegate void TimeEvent();
        public event TimeEvent clockevent;    //创建事件ClockEvent


        public CLOCK(int interval, int currentTime, int maxtime) //构造函数，maxtime代表最大时间
        {
            this.interval = interval;
            this.currentTime = currentTime;
            this.maxtime = maxtime;
        }
        public void runtime()                   //此处用于调用clockevent事件
        {
            for (; this.currentTime < this.maxtime; this.currentTime++)        
            {
                clockevent();
            }
        }
    }

    public class ClockEvent             //  ClcokEvent类
    {
        public CLOCK clock;             //声明clock类实例 clock，修饰符为public

        public ClockEvent(int interval,int currentTime,int maxtime)// ClcokEvent 的构造函数
        {
            clock = new CLOCK(interval, currentTime, maxtime);      //创建clock实例
            clock.clockevent += DoTick;                             //向clockevent中添加函数DoTick和DoAlarm
            clock.clockevent += DoAlarm;
        }
        public void DoTick()            //函数DoTick
        {
            if (clock.currentTime % clock.interval != 0)      //当currentTime为interval的倍数时不发出tick声，其他时候发出tick声
            {
                Console.WriteLine("tick!tick!tick!");
            }
        }
        public void DoAlarm()           //函数DoAlarm
        {
            if (clock.currentTime % clock.interval == 0)      //当currentTime为interval的倍数时发出Alarm声
            {
                Console.WriteLine("Alarm!skr!skr!skr!");
            }
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
             ClockEvent test = new ClockEvent(12, 2, 25);
            test.clock.runtime();//调用runtime函数，使用事件clockevent
         
        }
    }

}
