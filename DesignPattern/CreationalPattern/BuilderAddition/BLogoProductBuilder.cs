using DesignPattern.CreationalPattern.FactoryAddtion;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CreationalPattern.BuilderAddition
{
    /// <summary>
    /// B型号logo制造者
    /// </summary>
    class BLogoProductBuilder : BuilderPattern
    {
        internal override void SetColor()
        {
            Product.Color = (new ColorFactoryPattern()).GetColor(Enum.EColorType.Green);
        }

        internal override void SetShape()
        {
            Product.Shape = (new ShapeFactoryPattern()).GetShape(Enum.EShapeType.Rectangle);
        }

        internal override void SetSize()
        {
            Product.Size = 20;
        }
    }
}
