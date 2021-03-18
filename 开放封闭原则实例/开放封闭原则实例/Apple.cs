using System;
using System.Collections.Generic;
using System.Text;

namespace 开放封闭原则实例
{
    class Apple : Fruit
    {
        public Apple()
        {
            //this.Plant();
            //this.Blossom();
            //this.Outcome();
        }
        public void Plant()
        {
            Console.WriteLine("种苹果");
        }
        public void Blossom()
        {
            Console.WriteLine("苹果开花");
        }
        public void Outcome()
        {
            Console.WriteLine("苹果结果了");
        }
    }
}
