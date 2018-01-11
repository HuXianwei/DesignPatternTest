using DesignPattern.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CreationalPattern.BuilderAddition
{
    /// <summary>
    /// 建造指导者
    /// </summary>
    class BuilderDirector
    {
        internal LogoProduct Construct(BuilderPattern builder)
        {
            //首先设置logo的形状
            builder.SetShape();

            //然后设置logo的尺寸
            builder.SetSize();

            //最后设置logo的颜色
            builder.SetColor();

            return builder.GetProcuct();
        }
    }
}
