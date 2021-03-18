using System;
using System.Collections.Generic;
using System.Text;

namespace _03建造者模式
{
    //提供满足客户需求的任务的构造函数 客户要什么就给什么（父类）—— 主函数里面里式替换
    class GreatePerson
    {
        private GameBuilder _gb;
        public GreatePerson(GameBuilder gb)
        {
            this._gb = gb;
        }
        public void GivePerson()
        {
            _gb.HP();
            _gb.MP();
            _gb.ATK();
            _gb.DEF();
        }
    }
}
