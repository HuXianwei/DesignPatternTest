using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Common
{
    /// <summary>
    /// 正方形
    /// </summary>
    class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Draw Square!");
        }
    }
}
