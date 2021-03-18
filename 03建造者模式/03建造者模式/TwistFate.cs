using System;
using System.Collections.Generic;
using System.Text;

namespace _03建造者模式
{
    //卡牌大师的属性
    class TwistFate : GameBuilder
    {
        public override void HP()
        {
            Console.WriteLine("卡牌大师生命值为534");
        }
        public override void MP()
        {
            Console.WriteLine("卡牌大师法力值为333");
        }
        public override void ATK()
        {
            Console.WriteLine("卡牌大师攻击力为52");
        }
        public override void DEF()
        {
            Console.WriteLine("卡牌大师防御力为21");
        }
    }
}
