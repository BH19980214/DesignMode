using System;
using System.Collections.Generic;
using System.Text;

namespace 原型模式
{
    
    public interface IColor
    {
        IColor Clone();
        int Red { get; set; }
        int Green { get; set; }
        int Blue { get; set; }
    }
}
