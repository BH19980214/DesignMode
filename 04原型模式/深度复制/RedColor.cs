using System;
using System.Collections.Generic;
using System.Text;

namespace 深度复制
{
    class RedColor : IColor
    {
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }
        public Factroy f { get; set; }

        public IColor Clone()
        {
            SerializableHelper s = new SerializableHelper();
            string target = s.Serializable(this);
            return s.Derializable<IColor>(target);
        } 
    }
}
