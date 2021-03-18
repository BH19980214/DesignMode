using System;
using System.Collections.Generic;
using System.Text;

namespace _07装饰模式
{
    class VIP: FreeAndVIp
    {
        public override void Study()
        {
            Console.WriteLine("晚上上课");
        }
    }
}
