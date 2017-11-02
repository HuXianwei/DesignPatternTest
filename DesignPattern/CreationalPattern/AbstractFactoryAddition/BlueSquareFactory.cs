using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.Common;
using DesignPattern.Enum;
using DesignPattern.AbstractFactoryAddition;

namespace DesignPattern.CreationalPattern.AbstractFactoryAddition
{
    /// <summary>
    /// 蓝色正方形工厂
    /// </summary>
    class BlueSquareFactory : AbstractFactoryPattern
    {
        internal override IColor GetColor(EColorType colorType)
        {
            return new Blue();
        }

        internal override IShape GetShape(EShapeType shapeType)
        {
            return new ShapeFactoryPattern().GetShape(EShapeType.Square);
        }
    }
}
