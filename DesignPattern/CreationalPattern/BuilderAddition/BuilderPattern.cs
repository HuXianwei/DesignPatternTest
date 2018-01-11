using DesignPattern.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CreationalPattern.BuilderAddition
{
    /// <summary>
    /// 建造者模式建造者
    /// </summary>
    abstract class BuilderPattern
    {
        protected LogoProduct Product = new LogoProduct();

        //1.建造零部件方法
        /// <summary>
        /// 设置颜色
        /// </summary>
        internal abstract void SetColor();

        /// <summary>
        /// 设置形状
        /// </summary>
        internal abstract void SetShape();

        /// <summary>
        /// 设置尺寸
        /// </summary>
        internal abstract void SetSize();

        //2.返回产品方法
        internal LogoProduct GetProcuct()
        {
            return Product;
        }
    }
}
