using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01单例模式
{
    class Class1
    {
        public string AddNumString()
        {
            Class_single cs = Class_single.GetInstance();//单例
            //Class_single cs = new Class_single();//未单例
            return cs.AddNum().ToString();
        }
    }
}
