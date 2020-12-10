using System;
using System.Collections.Generic;
using System.Text;

namespace Medical.System.Model.ZHQ_Model
{
    /// <summary>
    /// 生产厂家表
    /// </summary>
    public class Manufacturer
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int ManufacturerId { get; set; }
        /// <summary>
        /// 生产厂家名称
        /// </summary>
        public string ManufacturerName { get; set; }
    }
}
