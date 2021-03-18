using System;
using System.Collections.Generic;
using System.Text;

namespace 简单工厂模式
{
    class RollsRoyce : WhatCar 
    {
        public override void Car()
        {
            Console.WriteLine("给您劳斯莱斯");
        }
    }
}
