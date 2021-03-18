using System;

namespace 简单工厂模式
{
    class Program
    {

        //客户要什么样的车 
        //实现 给什么样的车 并告诉这个车多少钱
        static void Main(string[] args)
        {
            Console.WriteLine("您想要什么车");
            string car = Console.ReadLine();
            GiveCar givecar = GiveCar.GetCar();//子类赋值给父类
            WhatCar whatCar = givecar.GiveYouCar(car);//抽象类父类
            whatCar.Car();
            GiveMoney givemoney = GiveMoney.GetMoney();//子类赋值给父类   依赖倒置 面对接口（大的方面）
            Money money = givemoney.Givemoney(car);//接口父类
            money.money();
        }
    }
}
