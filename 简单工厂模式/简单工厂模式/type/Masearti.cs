using System;
using System.Collections.Generic;
using System.Text;

namespace 简单工厂模式
{
    class Masearti : WhatCar
    {
        public override void Car()
        {
            Console.WriteLine("给您玛莎拉蒂");
        }
    }
}
