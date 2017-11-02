using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Common
{
    /// <summary>
    /// 红色
    /// </summary>
    class Red : IColor
    {
        public void Fill()
        {
            Console.WriteLine("Fill Red!");
        }
    }
}
