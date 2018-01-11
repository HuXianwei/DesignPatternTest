using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Common
{
    /// <summary>
    /// 圆形
    /// </summary>
    internal class Circle : IShape
    {
        public Circle()
        {
            Remark = "Draw Circle!";
        }
        public string Remark { get; set; }

        public IShape Clone()
        {
            return (Circle)MemberwiseClone();
        }

        public void Draw() 
        {
            Console.WriteLine(Remark);
        }
    }
}
