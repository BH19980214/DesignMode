using System;

namespace 开放封闭原则实例
{
    class Program
    {
        static void Main(string[] args)
        {
            //面对接口编程
            GardenerBase applegadener = AppleGardener.GetGardener();//G子类继承接口，通过接口创建一个G子类
            Fruit F1 = applegadener.GetFruit();//G子类在调用里面的方法返回一个F父类类型，并且这个父类类型已经在子类里面转化成F的子类了
            F1.Plant();//通过F父类类型实例化的一个F子类来调用F子类的方法  这里的F1是父类类型  但是里面装着 子类
            F1.Blossom();
            F1.Outcome();
            GardenerBase peergadener = PeerGardener.GetGardener();
            Fruit F2 = peergadener.GetFruit();
            F2.Plant();
            F2.Blossom();
            F2.Outcome();
        }
    }
}
