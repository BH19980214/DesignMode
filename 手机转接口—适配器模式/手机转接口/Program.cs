using System;

namespace 手机转接口
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone p = new Three();//想转成四个口的就直接把 Three改成Four即可
            p.Use();
        }
    }

    #region 三口转换器
    /// <summary>
    /// 转三口
    /// </summary>
    interface TypeThree
    {
        void TwoToThree();
    }
    class ChangeThree : TypeThree
    {
        public void TwoToThree()
        {
            Console.WriteLine("我给你转成三口");
        }
    }
    #endregion
    #region 四口转换器
    /// <summary>
    /// 转四口
    /// </summary>
    interface TypeFour
    {
        void TwoToFour();
    }
    class ChangeFour : TypeFour
    {
        public void TwoToFour()
        {
            Console.WriteLine("我给你转成四口");
        }
    }
    #endregion

    /// <summary>
    /// 手机 默认只能是两口
    /// </summary>
    abstract class Phone
    {
        public abstract void Use();//默认两口
    }
    /// <summary>
    /// 原来的手机只有两个口 在这里重写 用转成三个口的方法 转成三个口
    /// </summary>
    class Three : Phone
    {
        private TypeThree t = new ChangeThree();
        public override void Use()
        {
            t.TwoToThree();
        }
    }
    /// <summary>
    /// 原来的手机只有两个口 在这里重写 用转成四个口的方法 转成四个口
    /// </summary>
    class Four : Phone
    {
        private TypeFour t = new ChangeFour();
        public override void Use()
        {
            t.TwoToFour();
        }
    }

}
