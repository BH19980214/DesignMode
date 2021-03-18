using System;
using System.Collections.Generic;
using System.Text;

namespace 简单工厂模式
{
    class GiveMoney
    {
        private static GiveMoney GiveMoneySingleton;
        private GiveMoney()
        {

        }
        static object o = new object();
        public static GiveMoney GetMoney()
        {
            if (GiveMoneySingleton == null)
            {
                lock (o)
                {
                    GiveMoneySingleton = new GiveMoney();
                }
            }
            return GiveMoneySingleton;
        }
        public Money Givemoney(string str)
        {
            Money money = null;
            switch (str)
            {
                case "保时捷": money = new Mporsche(); break;
                case "劳斯莱斯":money = new Mpollsroyce(); break;
                case "玛莎拉蒂": money = new Mmasearti(); break;
                case "兰博基尼": money = new Mlamborghini(); break;
            }
            return money;
        }
    }
}
