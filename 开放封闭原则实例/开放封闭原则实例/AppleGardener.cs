using System;
using System.Collections.Generic;
using System.Text;

namespace 开放封闭原则实例
{
    //单一职责原则  一个类只能干一样活儿
    class AppleGardener : GardenerBase
    {
        private static AppleGardener AppleGardenerSingleton;
        private AppleGardener()
        {

        }
        static object o = new object();
        public static AppleGardener GetGardener()
        {
            if(AppleGardenerSingleton == null)
            {
                lock (o)
                {
                    AppleGardenerSingleton = new AppleGardener();
                }
            }
            return AppleGardenerSingleton;
        }
        //干这个活  转成苹果   如果要转成peer的话 就要新建一个类写转成peer的方法
        public Fruit GetFruit()
        {
            return new Apple();
        }
    }
}
