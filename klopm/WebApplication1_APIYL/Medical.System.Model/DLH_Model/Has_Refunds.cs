﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Medical.System.Model.DLH_Model
{
    /// <summary>
    /// 订单退费
    /// </summary>
    public class Has_Refunds
    {
        /// <summary>
        /// 订单退费Id
        /// </summary>
        public int Id				 { get; set; }
        /// <summary>
        /// 收费名称
        /// </summary>
        public string ChargeName		 { get; set; }
        /// <summary>
        /// 单价
        /// </summary>
        public double Price			 { get; set; }
        /// <summary>
        /// 总量
        /// </summary>
        public int Sums			 { get; set; }
        /// <summary>
        /// 单位
        /// </summary>
        public string Unit			 { get; set; }
        /// <summary>
        /// 零售金额
        /// </summary>
        public double RetMoney		 { get; set; }
        /// <summary>
        /// 折扣
        /// </summary>
        public float Discount		 { get; set; }
        /// <summary>
        /// 折后金额
        /// </summary>
        public double AfterDisPrice	 { get; set; }
        /// <summary>
        /// 可退数量
        /// </summary>
        public int BackNum			 { get; set; }
        /// <summary>
        /// 已退数量
        /// </summary>
        public int InBake			 { get; set; }
        /// <summary>
        /// 退费数量
        /// </summary>
        public int BakeNum			 { get; set; }
        /// <summary>
        /// 退款金额
        /// </summary>
        public double BakePrice { get; set; }
    }
}
