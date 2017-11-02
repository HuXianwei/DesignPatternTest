using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Common
{
    /// <summary>
    /// 圆形
    /// </summary>
    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Draw Circle!");
        }
    }
}
