using DesignPattern.AbstractFactoryAddition;
using DesignPattern.CreationalPattern;
using DesignPattern.CreationalPattern.AbstractFactoryAddition;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.TestDemo
{
    static class AbstractFactoryPatternDemo
    {
        internal static void Test()
        {
            //颜色、形状工厂
            AbstractFactoryPattern factory = new BlueSquareFactory();
            factory.GetColor(0).Fill();
            factory.GetShape(0).Draw();
            factory = new RedCircleFactory();
            factory.GetColor(0).Fill();
            factory.GetShape(0).Draw();
            //自由配置颜色和形状
            factory = new ColorShapeFactory();
            factory.GetColor(Enum.EColorType.Green).Fill();
            factory.GetShape(Enum.EShapeType.Rectangle).Draw();
        }
    }
}
