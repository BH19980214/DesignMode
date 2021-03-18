using System;
using System.Collections.Generic;
using System.Text;

namespace _07装饰模式
{
    class ZUHEJIAJICHENG : FreeAndVIp
    {
        /// <summary>
        /// 演示装饰器
        /// </summary>
        private FreeAndVIp _student = null;
        public ZUHEJIAJICHENG(FreeAndVIp student)
        {
            this._student = student;
        }
        public override void Study()
        {
            this._student.Study();
        }
    }
}
