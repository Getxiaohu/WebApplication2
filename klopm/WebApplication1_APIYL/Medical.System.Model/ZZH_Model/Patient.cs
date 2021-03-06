﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Medical.System.Model.ZZH_Model
{
    /// <summary>
    /// 患者管理
    /// </summary>
    public class Patient
    {
        /// <summary>
        /// 患者主键
        /// </summary>
        public int PatientId { get; set; }
        /// <summary>
        /// 患者编码
        /// </summary>
        public string PatientCode { get; set; }
        /// <summary>
        /// 患者姓名
        /// </summary>
        public string PatientName { get; set; }
        /// <summary>
        /// 患者卡号
        /// </summary>
        public string PatientCard { get; set; }
        /// <summary>
        /// 患者年龄
        /// </summary>
        public int PatientAge { get; set; }
        /// <summary>
        /// 患者出生日期
        /// </summary>
        public DateTime PatientDateBirth { get; set; }
        /// <summary>
        /// 性别外键
        /// </summary>
        public int PatientSexId { get; set; }
        /// <summary>
        /// 患者手机号码
        /// </summary>
        public string PatientPhone { get; set; }
        /// <summary>
        /// 患者证件号码
        /// </summary>
        public string Patientpapers { get; set; }
        /// <summary>
        /// 患者来源外键
        /// </summary>
        public int PatientSourceId { get; set; }
        /// <summary>
        /// 会员等级外键
        /// </summary>
        public int MemberId { get; set; }
        /// <summary>
        /// 到期时间
        /// </summary>
        public DateTime EndData { get; set; }
        /// <summary>
        /// 名族
        /// </summary>
        public string Nation { get; set; }
        /// <summary>
        /// 婚姻外键
        /// </summary>
        public int MaritalStatusId { get; set; }
        /// <summary>
        /// 学历外键
        /// </summary>
        public int EducationId { get; set; }
        /// <summary>
        /// 省外键
        /// </summary>
        public int ProvinceId { get; set; }
        /// <summary>
        /// 市外键
        /// </summary>
        public int CityId { get; set; }
        /// <summary>
        /// 详细地址
        /// </summary>
        public string PatientAddress { get; set; }
        /// <summary>
        /// 职位外键
        /// </summary>
        public int PositionId { get; set; }
        /// <summary>
        /// 工作单位
        /// </summary>
        public string WorkUnit { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
    }
}
