using System;

namespace _07装饰模式
{
    class Program
    {
        /// <summary>
        /// 组合优于继承
        /// 装饰模式 是组合➕继承  ZUHEJIAJICHENG 类中体现
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            #region 练习 比较三种哪种好
            //FreeAndVIp free = new Free()
            //{
            //    ID = 123,
            //    Name = "张三"
            //};
            //free.Show();
            //free.Study();//1.修改类
            //FreeAndVIPVideoCombination FreeVideoCombination = new FreeAndVIPVideoCombination(free);
            //FreeVideoCombination.Study();//2.组合
            //FreeAndVIp free1 = new FreeVideoInherit()
            //{
            //    ID = 123,
            //    Name = "张三"
            //};
            //free1.Study();//3.继承
            //FreeAndVIp VIP = new VIP()
            //{
            //    ID = 456,
            //    Name = "李四"
            //};
            //VIP.Show();
            //VIP.Study();
            #endregion
            FreeAndVIp vip = new VIP()
            {
                ID = 1333,
                Name = "李四"
            };

            #region 升级
            //ZUHEJIAJICHENG ZUHEJIAJICHENG = new ZUHEJIAJICHENG(vip);//升级  升级就是父类转子类 转到最上层 或者 转到父类一样的时候统一一下
            //FreeAndVIp ZUHEJIAJICHENG = new ZUHEJIAJICHENG(vip);//升级
            //vip.Study();

            //vip = new ZUHEJIAJICHENG(vip);//可以不要 里面是空的

            //ZUHEJIAJICHENGJUTI ZUHEJIAJICHENGJUTI = new ZUHEJIAJICHENGJUTI(vip);//升级
            //ZUHEJIAJICHENG ZUHEJIAJICHENGJUTI = new ZUHEJIAJICHENG(vip);//升级
            //FreeAndVIp ZUHEJIAJICHENGJUTI = new ZUHEJIAJICHENGJUTI(vip);//升级
            #endregion

            //任意扩展功能 任意调整顺序 修饰多种对象
            vip = new ZUHEJIAJICHENGJUTI(vip);
            vip = new ZUHEJIAJICHENGJUTIAYI(vip);
            vip = new ZUHEJIAJICHENGJUTILIANXI(vip);
            vip.Study();

            Console.WriteLine("*****************************");
            FreeAndVIp free = new Free()
            {
                ID = 123,
                Name = "张三"
            };
            free = new ZUHEJIAJICHENGJUTI(free);
            free = new ZUHEJIAJICHENGJUTIAYI(free);
            free = new ZUHEJIAJICHENGJUTILIANXI(free);
            free.Study();
        }
    }









}
