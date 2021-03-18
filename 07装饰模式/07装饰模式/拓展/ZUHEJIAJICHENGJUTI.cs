using System;
using System.Collections.Generic;
using System.Text;

namespace _07装饰模式
{
    /// <summary>
    /// 具体装饰器
    /// </summary>
    class ZUHEJIAJICHENGJUTI : ZUHEJIAJICHENG
    {
        public ZUHEJIAJICHENGJUTI(FreeAndVIp student):base(student)
        {
        }
        public override void Study()
        {
            base.Study();
            //增加自己的行为
            Console.WriteLine("获取音频");
        }
    }
}
