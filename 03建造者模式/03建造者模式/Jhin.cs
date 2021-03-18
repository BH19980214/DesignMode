using System;
using System.Collections.Generic;
using System.Text;

namespace _03建造者模式
{
    //戏命师烬的属性
    class Jhin : GameBuilder
    {
        public override void HP()
        {
            Console.WriteLine("戏命师烬生命值为585");
        }
        public override void MP()
        {
            Console.WriteLine("戏命师烬法力值为300");
        }
        public override void ATK()
        {
            Console.WriteLine("戏命师烬攻击力为59");
        }
        public override void DEF()
        {
            Console.WriteLine("戏命师烬防御力为24");
        }
    }
}
