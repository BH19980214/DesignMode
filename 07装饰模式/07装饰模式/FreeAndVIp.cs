using System;
using System.Collections.Generic;
using System.Text;

namespace _07装饰模式
{
    abstract class FreeAndVIp
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public abstract void Study();
    }
}
