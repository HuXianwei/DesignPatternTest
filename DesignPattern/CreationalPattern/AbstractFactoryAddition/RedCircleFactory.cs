using DesignPattern.Enum;
using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.Common;
using DesignPattern.AbstractFactoryAddition;

namespace DesignPattern.CreationalPattern.AbstractFactoryAddition
{
    /// <summary>
    /// 红色、圆形工厂
    /// </summary>
    class RedCircleFactory : AbstractFactoryPattern
    {
        internal override IColor GetColor(EColorType colorType)
        {
            return new Red();
        }

        internal override IShape GetShape(EShapeType shapeType)
        {
            return new ShapeFactoryPattern().GetShape(EShapeType.Circle);
        }
    }
}
