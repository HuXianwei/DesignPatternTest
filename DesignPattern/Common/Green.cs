using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Common
{
    /// <summary>
    /// 绿色
    /// </summary>
    class Green : IColor
    {
        public void Fill()
        {
            Console.WriteLine("Fill Green!");
        }
    }
}
