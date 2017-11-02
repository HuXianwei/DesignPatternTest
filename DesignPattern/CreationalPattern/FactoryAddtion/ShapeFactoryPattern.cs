using DesignPattern.Common;
using DesignPattern.Enum;
using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// 应用场景： 设计数据库连接时不知道具体连接哪一种数据库，根据具体实施选择连接数据库的类型
/// </summary>

namespace DesignPattern.CreationalPattern
{
    /// <summary>
    /// 工厂模式
    /// </summary>
    class ShapeFactoryPattern
    {
        public IShape GetShape(EShapeType shapeType)
        {
            switch (shapeType)
            {
                case EShapeType.Rectangle: return new Rectangle();
                case EShapeType.Circle: return new Circle();
                case EShapeType.Square: return new Square();
            }
            return null;
        }
    }
}
