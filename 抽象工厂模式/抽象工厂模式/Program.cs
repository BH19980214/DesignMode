using System;

namespace 抽象工厂模式
{
    class Program
    {
        static void Main(string[] args)
        {
            GameFactory gf = new B_InterfaceController();
            Apple ad = gf.CanRunonApple();
            ad.Description();
        }
    }
    //抽象产品类
    interface Android
    {
        void Description();
    }

    interface Apple
    {
        void Description();
    }

    interface ASymbian
    {
        void Description();
    }


    //抽象工厂类
    /// <summary>
    /// 游戏支持系统抽象工厂
    /// </summary>
    interface GameFactory
    {
        ASymbian CanRunonSymbian();
        Android CanRunonAndroid();
        Apple CanRunonApple();
    }


    /// <summary>
    /// 具体产品类 安卓系统支持InterfaceControllerOnAndroid
    /// </summary>
    class InterfaceControllerOnAndroid : Android
    {
        public void Description()
        {
            Console.WriteLine("安卓系统支持InterfaceControllerOnAndroid游戏操作控制");
        }
    }

    class InterfaceControllerOnApple : Apple
    {
        public void Description()
        {
            Console.WriteLine("苹果支持 InterfaceController游戏操作控制");
        }
    }

    class InterfaceControllerOnSymbian : ASymbian
    {
        public void Description()
        {
            Console.WriteLine("塞班系统支持InterfaceController游戏操作控制");
        }
    }
    /// <summary>
    /// 具体产品类  支持OperationController
    /// </summary>
    class OperationControllerOnAndroid : Android
    {
        public void Description()
        {
            Console.WriteLine("安卓系统支持OperationControllerOnAndroid游戏操作控制");
        }
    }

    class OperationControllerOnApple : Apple
    {
        public void Description()
        {
            Console.WriteLine("苹果系统支持OperationController游戏操作控制");
        }
    }

    class OperationControllerOnSymbian : ASymbian
    {
        public void Description()
        {
            Console.WriteLine("塞班系统支持OperationController游戏操作控制");
        }
    }

    /// <summary>
    /// 具体工厂类
    /// </summary>
    class B_InterfaceController : GameFactory
    {
        public Android CanRunonAndroid()
        {
            return new InterfaceControllerOnAndroid();
        }

        public Apple CanRunonApple()
        {
            return new InterfaceControllerOnApple();
        }

        public ASymbian CanRunonSymbian()
        {
            return new InterfaceControllerOnSymbian();
        }

    }

    /// <summary>
    /// 具体工厂类
    /// </summary>
    class B_OperationController : GameFactory
    {
        public Android CanRunonAndroid()
        {
            return new OperationControllerOnAndroid();
        }

        public Apple CanRunonApple()
        {
            return new OperationControllerOnApple();
        }

        public ASymbian CanRunonSymbian()
        {
            return new OperationControllerOnSymbian();
        }
    }

}
