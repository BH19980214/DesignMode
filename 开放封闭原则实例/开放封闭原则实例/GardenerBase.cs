using System;
using System.Collections.Generic;
using System.Text;

namespace 开放封闭原则实例
{
    //依赖倒置原则   面向接口编程
    interface GardenerBase
    {
        Fruit GetFruit();//返回值是fruit的一个方法
    }
}
