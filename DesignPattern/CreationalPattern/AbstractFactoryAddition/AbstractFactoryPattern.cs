using DesignPattern.Common;
using DesignPattern.Enum;
using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// 应用场景：QQ 换皮肤，颜色和形状等一整套一起换
/// </summary>

namespace DesignPattern.AbstractFactoryAddition
{
    /// <summary>
    /// 抽象工厂模式
    /// </summary>
    abstract class AbstractFactoryPattern
    {
        internal abstract LogoProduct CreateRedLogo();

        internal abstract LogoProduct CreateGreenLogo();
    }
}
