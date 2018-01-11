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
        public Square()
        {
            Remark = "Draw Square!";
        }
        public string Remark { get; set; }

        public IShape Clone()
        {
            return (Square)MemberwiseClone();
        }

        public void Draw()
        {
            Console.WriteLine(Remark);
        }
    }
}
