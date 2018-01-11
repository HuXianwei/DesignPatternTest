using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Common
{
    /// <summary>
    /// 颜色
    /// </summary>
    public interface IColor
    {
        /// <summary>
        /// 涂色方法
        /// </summary>
        void Fill();

        /// <summary>
        /// 克隆方法
        /// </summary>
        IColor Clone();
    }
}
