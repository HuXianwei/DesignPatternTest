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
            /********生成圆形logo*********/
            Console.WriteLine("生成圆形logo");
            //圆形工厂
            AbstractFactoryPattern factory = new CircleFactory();
            //生成圆形绿色logo
            Console.WriteLine("生成圆形绿色logo");
            var logo = factory.CreateGreenLogo();
            logo.Color.Fill();
            logo.Shape.Draw();
            //生成圆形红色logo
            Console.WriteLine("生成圆形红色logo");
            logo = factory.CreateRedLogo();
            logo.Color.Fill();
            logo.Shape.Draw();
            /********生成正方形logo*********/
            Console.WriteLine("生成正方形logo");
            //正方形工厂
            factory = new SquareFactory();
            //生成正方形绿色logo
            Console.WriteLine("生成正方形绿色logo");
            logo = factory.CreateGreenLogo();
            logo.Color.Fill();
            logo.Shape.Draw();
            //生成正方形红色logo
            Console.WriteLine("生成正方形红色logo");
            logo = factory.CreateRedLogo();
            logo.Color.Fill();
            logo.Shape.Draw();
        }
    }
}
