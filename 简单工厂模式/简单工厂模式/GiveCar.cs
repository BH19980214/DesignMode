using System;
using System.Collections.Generic;
using System.Text;

namespace 简单工厂模式
{
    class GiveCar
    {
        private static GiveCar GiveCarSingleton;
        private GiveCar()
        {

        }
        static object o = new object();
        public static GiveCar GetCar()
        {
            if(GiveCarSingleton == null)
            {
                lock (o)
                {
                    GiveCarSingleton = new GiveCar();
                }
            }
            return GiveCarSingleton;
        }
        public WhatCar GiveYouCar(string str)
        {
            WhatCar whatCar = null;
            switch (str)
            {
                case "保时捷": whatCar = new Porsche(); break;
                case "玛莎拉蒂": whatCar = new Masearti(); break;
                case "兰博基尼": whatCar = new Lamborghini(); break;
                case "劳斯莱斯": whatCar = new RollsRoyce(); break;
            }
            return whatCar;
        }
    }
}
