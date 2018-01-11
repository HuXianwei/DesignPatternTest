using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.Common;
using DesignPattern.Enum;
using DesignPattern.AbstractFactoryAddition;
using DesignPattern.CreationalPattern.FactoryAddtion;

namespace DesignPattern.CreationalPattern.AbstractFactoryAddition
{
    /// <summary>
    /// 正方形logo工厂
    /// </summary>
    class SquareFactory : AbstractFactoryPattern
    {
        /// <summary>
        /// 创建红色正方形logo
        /// </summary>
        /// <returns></returns>
        internal override LogoProduct CreateRedLogo()
        {
            LogoProduct logo = new LogoProduct
            {
                Shape = (new ShapeFactoryPattern()).GetShape(EShapeType.Square),
                Color = (new ColorFactoryPattern()).GetColor(EColorType.Red),
                Size = 10
            };
            return logo;
        }

        /// <summary>
        /// 创建绿色正方形logo
        /// </summary>
        /// <returns></returns>
        internal override LogoProduct CreateGreenLogo()
        {
            LogoProduct logo = new LogoProduct
            {
                Shape = (new ShapeFactoryPattern()).GetShape(EShapeType.Square),
                Color = (new ColorFactoryPattern()).GetColor(EColorType.Green),
                Size = 10
            };
            return logo;
        }
    }
}
