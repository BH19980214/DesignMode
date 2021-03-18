using System;
using System.Collections.Generic;
using System.Text;

namespace 原型模式
{
    class RedColor : IColor
    {
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }
        public IColor Clone()
        {
            return (IColor)this.MemberwiseClone();
        }

    }
}
