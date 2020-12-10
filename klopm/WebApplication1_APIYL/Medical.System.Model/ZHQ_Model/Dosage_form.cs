using System;
using System.Collections.Generic;
using System.Text;

namespace Medical.System.Model.ZHQ_Model
{
    /// <summary>
    /// 药品剂型
    /// </summary>
    public class Dosage_form
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int Dosage_formId  { get; set; }
        /// <summary>
        /// 药品剂型名称
        /// </summary>
        public string Dosage_formName { get; set; }
    }
}
