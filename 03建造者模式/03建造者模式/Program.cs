using System;

namespace _03建造者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            GreatePerson gp1 = new GreatePerson(new TwistFate());//玩家想要什么角色就建造什么角色 在括号中里式转换 把子类赋值给父类
            gp1.GivePerson();
            GreatePerson gp2 = new GreatePerson(new Jhin());
            gp2.GivePerson();
        }
    }
}
