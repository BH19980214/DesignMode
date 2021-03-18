using System;

namespace 深度复制
{
    class Program
    {
        static void Main(string[] args)
        {
            IColor color = new RedColor();
            color.Red = 255;
            color.f = new Factroy() { name = "湖北工厂" };
            Console.WriteLine("color - Factroy:" + color.f.name);  //湖北工厂

            IColor color1 = color.Clone();
            color1.Red = 234;
            color1.f.name = "北京工厂";
            Console.WriteLine("color1- Factroy:" + color1.f.name); //北京工厂
            Console.WriteLine("color - Factroy:" + color.f.name);  //湖北工厂
            Console.Read();
        }
    }
}
