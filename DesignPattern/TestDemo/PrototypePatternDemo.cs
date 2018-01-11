using DesignPattern.Common;
using DesignPattern.CreationalPattern.FactoryAddtion;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.TestDemo
{
    class PrototypePatternDemo
    {
        internal static void Test()
        {
            LogoProduct logo = new LogoProduct();
            logo.Color = (new ColorFactoryPattern()).GetColor(Enum.EColorType.Green);
            logo.Shape = (new ShapeFactoryPattern()).GetShape(Enum.EShapeType.Circle);
            logo.Size = 100;
            logo.Description = "prototypepattern";
            //浅复制(只复制值类型成员)
            Console.WriteLine("浅复制(只复制值类型成员)");
            var newLogo = logo.Clone();
            logo.Shape.Remark = "Draw big Circle!";
            newLogo.Shape.Draw();
            Console.WriteLine("Size:" + newLogo.Size + ";Description:" + newLogo.Description);
            //深复制(复制对象类型成员)
            Console.WriteLine("深复制(复制对象类型成员)");
            newLogo = logo.DepthClone();
            logo.Shape.Remark = "Draw Circle!";
            newLogo.Shape.Draw();
            Console.WriteLine("Size:" + newLogo.Size + ";Description:" + newLogo.Description);
        }
    }
}
