using DesignPattern.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CreationalPattern.PrototypeAddtition
{
    /// <summary>
    /// 创建者模式(抽象原型类)
    /// </summary>
    abstract class PrototypePattern
    {
        /// <summary>
        /// 克隆接口
        /// </summary>
        /// <returns></returns>
        internal abstract LogoProduct Clone();

        /// <summary>
        /// 深度克隆接口（克隆对象类型数据）
        /// </summary>
        /// <returns></returns>
        internal abstract LogoProduct DepthClone();
    }
}
