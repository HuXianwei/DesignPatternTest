using DesignPattern.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CreationalPattern.BuilderAddition
{
    /// <summary>
    /// logo产品
    /// </summary>
    public class LogoProduct
    {
        /// <summary>
        /// 颜色
        /// </summary>
        internal IColor Color { get; set; }

        /// <summary>
        /// 形状
        /// </summary>
        internal IShape Shape { get; set; }

        /// <summary>
        /// 尺寸
        /// </summary>
        internal int Size { get; set; }
    }
}
