using System;
using System.Collections.Generic;
using System.Text;

namespace _07装饰模式
{
    class Free : FreeAndVIp
    {
        public override void Study()
        {
            Console.WriteLine("白天上课");
            Console.WriteLine("免费学生视频回放");
            //1.修改类  直接简单 破坏稳定性 尤其是逻辑复杂的时候 面向对象的语言追求稳定性
        }

    }
}
