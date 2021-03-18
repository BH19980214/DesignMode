using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01单例模式
{
    
    class Class_single
    {
        private Class_single()//类私有化
        {

        }
        int num = 0;
        static Class_single g_cs = null;
        static object g_locker = new object();
        public static Class_single GetInstance()
        {
            if (g_cs == null)
            {
                lock (g_locker)//锁，为了避免多个线程同时实例化
                {
                    g_cs = new Class_single();
                }
            }
            return g_cs;
        }
        public int AddNum()
        {
            return num++;
        }
    }
}
