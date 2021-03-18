using System;
using System.Collections.Generic;
using System.Text;


namespace 深度复制
{
    interface IColor
    {
        IColor Clone();
        int Red { get; set; }
        int Green { get; set; }
        int Blue { get; set; }
        Factroy f { get; set; }

    }
    public class Factroy
    {
        public string name { get; set; }
    }

}
