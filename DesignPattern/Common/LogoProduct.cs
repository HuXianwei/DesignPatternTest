using DesignPattern.Common;
using DesignPattern.CreationalPattern.PrototypeAddtition;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.Text;

namespace DesignPattern.Common
{
    /// <summary>
    /// logo产品
    /// </summary>
    class LogoProduct : PrototypePattern
    {
        /// <summary>
        /// 颜色
        /// </summary>
        public IColor Color { get; set; }

        /// <summary>
        /// 形状
        /// </summary>
        public IShape Shape { get; set; }

        /// <summary>
        /// 尺寸
        /// </summary>
        public int Size { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }

        internal override LogoProduct Clone()
        {
            //return (LogoProduct)MemberwiseClone();
            return MemberwiseClone() as LogoProduct;
        }

        internal override LogoProduct DepthClone()
        {
            //赋值克隆
            //var newLogo = (LogoProduct)MemberwiseClone();
            //newLogo.Shape = Shape.Clone();
            //newLogo.Color = Color.Clone();
            //return newLogo;
            //序列化克隆
            DataContractJsonSerializer deseralizer = new DataContractJsonSerializer(typeof(LogoProduct));
            MemoryStream stream = new MemoryStream();
            deseralizer.WriteObject(stream, this);
            stream.Position = 0;
            StreamReader sr = new StreamReader(stream, Encoding.UTF8);
            string jsonStr = sr.ReadToEnd();
            Console.WriteLine(jsonStr);
            using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonStr)))
            {
                LogoProduct model = (LogoProduct)deseralizer.ReadObject(ms);// //反序列化ReadObject
                return model;
            }
        }
    }
}
