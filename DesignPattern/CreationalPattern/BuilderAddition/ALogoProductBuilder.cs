using DesignPattern.CreationalPattern.FactoryAddtion;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CreationalPattern.BuilderAddition
{
    /// <summary>
    /// A型号logo制造者
    /// </summary>
    class ALogoProductBuilder : BuilderPattern
    {
        internal override void SetColor()
        {
            Product.Color = (new ColorFactoryPattern()).GetColor(Enum.EColorType.Blue);
        }

        internal override void SetShape()
        {
            Product.Shape = (new ShapeFactoryPattern()).GetShape(Enum.EShapeType.Circle);
        }

        internal override void SetSize()
        {
            Product.Size = 10;
        }
    }
}
