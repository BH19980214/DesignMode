using System;
using System.Reflection;

namespace 工厂模式
{
    class Program
    {
        static void Main(string[] args)
        {
            ImagerFactory If = new GifImgFactory();
            Imager im = If.GetImagelist();
            im.GetImages();
        }
    }
    /// <summary>
    /// 图片处理接口 
    /// 抽象产品：它是定义产品的接口，是工厂方法模式所创建对象的超类型，也就是产品对象的公共父类。
    /// </summary>
    interface Imager
    {
        void GetImages();
    }
    /// <summary>
    /// 工厂
    /// </summary>
    interface ImagerFactory
    {
        Imager GetImagelist(); //抽象产品工厂类
    }
    /// <summary>
    /// GIF继承图片接口
    /// </summary>
    class GifImg : Imager
    {
        public void GetImages()
        {
            Console.WriteLine("读取GIF图片。");
        }
    }
    /// <summary>
    /// JPG继承图片接口
    /// </summary>
    class JpgImg : Imager
    {
        public void GetImages()
        {
            Console.WriteLine("读取Jpg图片。");
        }
    }


    class GifImgFactory : ImagerFactory  //继承自抽象产品类
    {
        public Imager GetImagelist()
        {
            Imager im = new GifImg();
            return im;
        }
    }



    class JpgImgFactory : ImagerFactory
    {
        public Imager GetImagelist()
        {
            Imager im = new JpgImg();
            return im;
        }
    }






}
