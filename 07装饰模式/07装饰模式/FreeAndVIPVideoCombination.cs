using System;
using System.Collections.Generic;
using System.Text;

namespace _07装饰模式
{
    class FreeAndVIPVideoCombination
    {
        private FreeAndVIp _freeAndVIp = null;
        public FreeAndVIPVideoCombination(FreeAndVIp student)
        {
            this._freeAndVIp = student;
        }
        public void Study()
        {
            this._freeAndVIp.Study();
            Console.WriteLine("免费学生视频回放");
            //2.组合  灵活  但是需要全新的类型 上端需要切换
        }
    }
}
