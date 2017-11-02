using DesignPattern.Common;
using DesignPattern.CreationalPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.TestDemo
{
    static class ShapeFactoryPatternDemo
    {
        internal static void Test()
        {
            //图形形状工厂
            ShapeFactoryPattern shapeFactory = new ShapeFactoryPattern();
            //画圆
            IShape shape = shapeFactory.GetShape(Enum.EShapeType.Circle);
            shape.Draw();
            //画长方形
            shape = shapeFactory.GetShape(Enum.EShapeType.Rectangle);
            shape.Draw();
            //画正方形
            shape = shapeFactory.GetShape(Enum.EShapeType.Square);
            shape.Draw();
        }
    }
}
