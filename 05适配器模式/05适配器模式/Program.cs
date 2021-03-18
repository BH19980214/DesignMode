using System;

namespace _05适配器模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Adapter ad = new Adapter();
            ad.TypeC();
        }

    }
    /// <summary>
    /// 目标对象需要的方法   就是Lightning 转 TypeC
    /// </summary>
    interface Target
    {
        void TypeC();
    }
    /// <summary>
    /// 适配器对象  就是充电头
    /// </summary>
    class Adapter : Target
    {
        private Adaptee transition = new Adaptee();
        public void TypeC()//转换的方法
        {
            transition.Lightning();
        }
    }
    /// <summary>
    /// 被适配对象  手写笔
    /// </summary>
    class Adaptee
    {
        public void Lightning()
        {
            Console.WriteLine("我是手写笔，我只能插Lightning接口");
        }
    }



}
