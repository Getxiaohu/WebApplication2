using System;
using System.Collections.Generic;
using System.Text;

namespace Medical.System.Model.ZHQ_Model
{
    /// <summary>
    /// 收费表
    /// </summary>
    public class Charge1
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int ChargeId	 { get; set; }
        /// <summary>
        /// 收费商品名称
        /// </summary>
        public string ChargeName	 { get; set; }
        /// <summary>
        /// 商品单价
        /// </summary>
        public float ChargePrice { get; set; }
        /// <summary>
        /// 收费数量
        /// </summary>
        public int ChargeNum	 { get; set; }
        /// <summary>
        /// 应收金额
        /// </summary>
        public float ChargeYSJE { get; set; }
    }
}
