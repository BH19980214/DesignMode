using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace 深度复制
{/// <summary>
/// 序列化和反序列化的辅助类
/// </summary>
    class SerializableHelper
    {
        public string Serializable(object target)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                new BinaryFormatter().Serialize(stream, target);

                return Convert.ToBase64String(stream.ToArray());
            }
        }

        public object Derializable(string target)
        {
            byte[] targetArray = Convert.FromBase64String(target);

            using (MemoryStream stream = new MemoryStream(targetArray))
            {
                return new BinaryFormatter().Deserialize(stream);
            }
        }

        public T Derializable<T>(string target)
        {
            return (T)Derializable(target);
        }
    }
}
