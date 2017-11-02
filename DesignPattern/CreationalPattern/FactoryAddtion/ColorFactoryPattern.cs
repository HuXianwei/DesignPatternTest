using DesignPattern.Common;
using DesignPattern.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CreationalPattern.FactoryAddtion
{
    class ColorFactoryPattern
    {
        public IColor GetColor(EColorType colorType)
        {
            switch (colorType)
            {
                case EColorType.Blue: return new Blue();
                case EColorType.Red: return new Red();
                case EColorType.Green: return new Green();
            }
            return null;
        }
    }
}
