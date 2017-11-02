using DesignPattern.CreationalPattern.SingletonAddition;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.TestDemo
{
    static class SingletonPatternDemo
    {
        internal static void Test()
        {
            //不合法的构造函数
            //编译时错误：构造函数 SingleObject() 是不可见的
            //SingletonPattern singleton = new SingletonPattern();

            SingletonPattern single = SingletonPattern.GetInstance();
            single.ShowMessage();
        }
    }
}
