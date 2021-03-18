using System;
using System.Collections.Generic;
using System.Text;

namespace 开放封闭原则实例
{
    class Peer : Fruit
    {
        public Peer()
        {
            //this.Plant();
            //this.Blossom();
            //this.Outcome();
        }
        public void Plant()
        {
            Console.WriteLine("种梨");
        }
        public void Blossom()
        {
            Console.WriteLine("梨开花");
        }
        public void Outcome()
        {
            Console.WriteLine("梨结果了");
        }
    }
}
