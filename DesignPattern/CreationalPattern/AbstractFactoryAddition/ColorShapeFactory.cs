using DesignPattern.AbstractFactoryAddition;
using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.Common;
using DesignPattern.Enum;
using DesignPattern.CreationalPattern.FactoryAddtion;

namespace DesignPattern.CreationalPattern.AbstractFactoryAddition
{
    /// <summary>
    /// 颜色、形状工厂(通过配置实现自由配置)
    /// </summary>
    class ColorShapeFactory : AbstractFactoryPattern
    {
        internal override IColor GetColor(EColorType colorType)
        {
            return new ColorFactoryPattern().GetColor(colorType);   //使用工厂模式进行创建
        }

        internal override IShape GetShape(EShapeType shapeType)
        {
            return new ShapeFactoryPattern().GetShape(shapeType);  //使用工厂模式进行创建
        }
    }
}
