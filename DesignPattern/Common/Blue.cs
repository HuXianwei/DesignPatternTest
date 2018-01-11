using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Common
{
    class Blue : IColor
    {
        public IColor Clone()
        {
            return MemberwiseClone() as Blue;
        }
        public void Fill()
        {
            Console.WriteLine("Fill Blue");
        }
    }
}
