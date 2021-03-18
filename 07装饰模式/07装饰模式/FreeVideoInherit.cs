using System;
using System.Collections.Generic;
using System.Text;

namespace _07装饰模式
{
    class FreeVideoInherit : Free
    {
        public override void Study()
        {
            base.Study();
            Console.WriteLine("免费学生视频回放");
            //继承  代码优雅 强侵入 写死的  只能为 free服务
        }
    }
}
