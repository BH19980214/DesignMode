using System;

namespace 原型模式
{
    class Program
    {
        static void Main(string[] args)
        {
            IColor color = new RedColor();
            color.Red = 255;
            Console.WriteLine("color -red " + color.Red); //255
            IColor color1 = color.Clone();
            color1.Red = 224;
            Console.WriteLine("color1-red " + color1.Red);//224
            Console.WriteLine("color -red " + color.Red); //255
        }
    }
}
