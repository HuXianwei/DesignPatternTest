using System;

namespace DesignPattern.Common
{
    /// <summary>
    /// 长方形
    /// </summary>
    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Draw Rectangle!");
        }
    }
}
