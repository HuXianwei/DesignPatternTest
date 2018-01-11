using System;

namespace DesignPattern.Common
{
    /// <summary>
    /// 长方形
    /// </summary>
    internal class Rectangle : IShape
    {
        public Rectangle()
        {
            Remark = "Draw Rectangle!";
        }
        public string Remark { get; set; }

        public IShape Clone()
        {
            return (Rectangle)MemberwiseClone();
        }

        public void Draw()
        {
            Console.WriteLine(Remark);
        }
    }
}
