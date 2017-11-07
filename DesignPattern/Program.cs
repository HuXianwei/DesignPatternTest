using DesignPattern.TestDemo;
using System;

namespace DesignPattern
{
    /// <summary>
    /// 设计模式测试类
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            /********************创建型模式测试*******************/
            //测试工厂模式
            //ShapeFactoryPatternDemo.Test();
            //测试抽象工厂模式
            //AbstractFactoryPatternDemo.Test();
            //测试单例模式
            //SingletonPatternDemo.Test();
            //测试建造者模式
            BuilderPatternDemo.Test();
            Console.ReadKey();
        }
    }
}