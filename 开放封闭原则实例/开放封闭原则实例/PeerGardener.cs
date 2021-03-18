using System;
using System.Collections.Generic;
using System.Text;

namespace 开放封闭原则实例
{
    class PeerGardener : GardenerBase
    {
        private static PeerGardener PeerGardenerSingleton;
        private PeerGardener()
        {

        }
        static object o = new object();
        public static PeerGardener GetGardener()
        {
            if (PeerGardenerSingleton == null)
            {
                lock (o)
                {
                    PeerGardenerSingleton = new PeerGardener();
                }
            }
            return PeerGardenerSingleton;
        }
        public Fruit GetFruit()
        {
            return new Peer();
        }
    }
}
