using System;
using System.Collections.Generic;
using System.Text;

namespace _03建造者模式
{
    //先创建 游戏人物的共有属性 抽象类
    abstract class GameBuilder
    {
       public abstract void HP();
       public abstract void MP();
       public abstract void ATK();
       public abstract void DEF();
    }
}
