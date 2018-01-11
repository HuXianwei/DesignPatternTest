using DesignPattern.Enum;
using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.Common;
using DesignPattern.AbstractFactoryAddition;
using DesignPattern.CreationalPattern.FactoryAddtion;

namespace DesignPattern.CreationalPattern.AbstractFactoryAddition
{
    /// <summary>
    /// 圆形logo工厂
    /// </summary>
    class CircleFactory : AbstractFactoryPattern
    {
        /// <summary>
        /// 创建红色圆形logo
        /// </summary>
        /// <param name="colorType"></param>
        /// <returns></returns>
        internal override LogoProduct CreateRedLogo()
        {
            LogoProduct logo = new LogoProduct
            {
                Shape = (new ShapeFactoryPattern()).GetShape(EShapeType.Circle),
                Color = (new ColorFactoryPattern()).GetColor(EColorType.Red),
                Size = 10
            };
            return logo;
        }

        /// <summary>
        /// 创建绿色圆形logo
        /// </summary>
        /// <returns></returns>
        internal override LogoProduct CreateGreenLogo()
        {
            LogoProduct logo = new LogoProduct
            {
                Shape = (new ShapeFactoryPattern()).GetShape(EShapeType.Circle),
                Color = (new ColorFactoryPattern()).GetColor(EColorType.Green),
                Size = 10
            };
            return logo;
        }
    }
}
