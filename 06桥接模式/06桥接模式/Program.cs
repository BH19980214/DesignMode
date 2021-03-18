using System;

namespace _06桥接模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Poersche();
            car.CarType();
            car = new Ferrari();
            car.CarType();
        }
    }

    /// <summary> 
    /// 发动机类型   发动机是汽车的一个引用
    /// </summary>
    interface Engine
    {
        void Type();
    }
    class V6 : Engine
    {
        public void Type()
        {
            Console.WriteLine("安装3.0L V6发动机");
        }
    }
    class V8 : Engine
    {
        public void Type()
        {
            Console.WriteLine("安装V8 3.9T发动机");
        }
    }
    /// <summary>
    /// 抽象类
    /// </summary>
    abstract class Car
    {
        protected Engine EngineType { get; set; }
        public abstract void CarType();
    }

    class Poersche : Car
    {
        public override void CarType()
        {
            EngineType = new V6();
            EngineType.Type();
        }
    }
    class Ferrari : Car
    {
        public override void CarType()
        {
            EngineType = new V8();
            EngineType.Type();
        }
    }








}
