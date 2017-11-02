using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// 应用场景:
/// 1、要求生产唯一序列号。 
/// 2、WEB 中的计数器，不用每次刷新都在数据库里加一次，用单例先缓存起来。 
/// 3、创建的一个对象需要消耗的资源过多，比如 I/O 与数据库的连接等
/// </summary>

namespace DesignPattern.CreationalPattern.SingletonAddition
{
    /// <summary>
    /// 单例模式
    /// </summary>
    class SingletonPattern
    {
        //内部创建一个私有的且只可以读的实例
        private static readonly SingletonPattern instance = new SingletonPattern();

        //私有构造方法,这样该类就不会被实例化
        private SingletonPattern()
        {

        }

        internal static SingletonPattern GetInstance()
        {
            return instance;
        }

        public void ShowMessage()
        {
            Console.WriteLine("SingletonPattern!");
        }
    }
}
