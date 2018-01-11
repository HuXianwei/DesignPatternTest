using System;

namespace DesignPattern.Common
{
    /// <summary>
    /// 形状
    /// </summary>
    public interface IShape
    {
        /// <summary>
        /// 绘画
        /// </summary>
        void Draw();

        /// <summary>
        /// 备注
        /// </summary>
        string Remark { get; set; }

        /// <summary>
        /// 克隆方法
        /// </summary>
        IShape Clone();
    }
}