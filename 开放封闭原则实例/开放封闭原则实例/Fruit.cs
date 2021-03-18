using System;
using System.Collections.Generic;
using System.Text;

namespace 开放封闭原则实例
{
    interface Fruit//对扩展开放 对修改封闭
        //对扩展开放就是 再写一个void 不会影响子类的调用 并且可以在子类中添加新的方法
        //对修改封闭就是 修改这里或者修改勒种的任何一个方法 都会对程序造成影响
        //比如多一个void Eat  就是扩展开放 在类中可以添加eat的新功能
        //比如去掉 void Plant 就会对整个继承接口的子类产生影响
    {
        void Plant();
        void Blossom();
        void Outcome();
    }
}
