using System;
using System.Collections.Generic;
using System.Text;

namespace 简单工厂模式
{
    class Lamborghini : WhatCar
    {
        public override void Car()
        {
            Console.WriteLine("给您兰博基尼");
        }
    }
}
