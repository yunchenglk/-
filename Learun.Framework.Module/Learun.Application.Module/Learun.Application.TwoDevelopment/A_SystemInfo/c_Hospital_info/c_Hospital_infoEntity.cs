using Learun.Util;
using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace Learun.Application.TwoDevelopment.A_SystemInfo

{
    /// <summary> 
    /// 版 本V2.3 辰星软件开发框架 
    /// Copyright (c) 2013-2018 山西辰星昇软件科技有限公司 
    /// 创 建：超级管理员 
    /// 日 期：2018-10-10 02:09 
    /// 描 述：医院信息管理 
    /// </summary> 
    public class c_Hospital_infoEntity
    {
        #region 实体成员 
        /// <summary> 
        /// 主键 
        /// </summary> 
        /// <returns></returns> 
        [Column("ID")]
        public string ID { get; set; }
        /// <summary> 
        /// 医院分类 
        /// </summary> 
        /// <returns></returns> 
        [Column("CATEGORY")]
        public string Category { get; set; }
        /// <summary> 
        /// 医院代码 
        /// </summary> 
        /// <returns></returns> 
        [Column("ENCODE")]
        public string EnCode { get; set; }
        /// <summary> 
        /// 医院简称 
        /// </summary> 
        /// <returns></returns> 
        [Column("SHORTNAME")]
        public string ShortName { get; set; }
        /// <summary> 
        /// 医院名称 
        /// </summary> 
        /// <returns></returns> 
        [Column("FULLNAME")]
        public string FullName { get; set; }
        /// <summary> 
        /// 医院性质 
        /// </summary> 
        /// <returns></returns> 
        [Column("NATURE")]
        public string Nature { get; set; }
        /// <summary> 
        /// 外线电话 
        /// </summary> 
        /// <returns></returns> 
        [Column("OUTERPHONE")]
        public string OuterPhone { get; set; }
        /// <summary> 
        /// 内线电话 
        /// </summary> 
        /// <returns></returns> 
        [Column("INNERPHONE")]
        public string InnerPhone { get; set; }
        /// <summary> 
        /// 传真 
        /// </summary> 
        /// <returns></returns> 
        [Column("FAX")]
        public string Fax { get; set; }
        /// <summary> 
        /// 邮编 
        /// </summary> 
        /// <returns></returns> 
        [Column("POSTALCODE")]
        public string Postalcode { get; set; }
        /// <summary> 
        /// 电子邮箱 
        /// </summary> 
        /// <returns></returns> 
        [Column("EMAIL")]
        public string Email { get; set; }
        /// <summary> 
        /// 负责人 
        /// </summary> 
        /// <returns></returns> 
        [Column("MANAGER")]
        public string Manager { get; set; }
        /// <summary> 
        /// 省主键 
        /// </summary> 
        /// <returns></returns> 
        [Column("PROVINCEID")]
        public string ProvinceId { get; set; }
        /// <summary> 
        /// 市主键 
        /// </summary> 
        /// <returns></returns> 
        [Column("CITYID")]
        public string CityId { get; set; }
        /// <summary> 
        /// 县/区主键 
        /// </summary> 
        /// <returns></returns> 
        [Column("COUNTYID")]
        public string CountyId { get; set; }
        /// <summary> 
        /// 详细地址 
        /// </summary> 
        /// <returns></returns> 
        [Column("ADDRESS")]
        public string Address { get; set; }
        /// <summary> 
        /// 公司主页 
        /// </summary> 
        /// <returns></returns> 
        [Column("WEBADDRESS")]
        public string WebAddress { get; set; }
        /// <summary> 
        /// 成立时间 
        /// </summary> 
        /// <returns></returns> 
        [Column("FOUNDEDTIME")]
        public DateTime? FoundedTime { get; set; }
        /// <summary> 
        /// 经营范围 
        /// </summary> 
        /// <returns></returns> 
        [Column("BUSINESSSCOPE")]
        public string BusinessScope { get; set; }
        /// <summary> 
        /// 排序码 
        /// </summary> 
        /// <returns></returns> 
        [Column("SORTCODE")]
        public int? SortCode { get; set; }
        /// <summary> 
        /// 删除标记 
        /// </summary> 
        /// <returns></returns> 
        [Column("F_DELETEMARK")]
        public int? F_DeleteMark { get; set; }
        /// <summary> 
        /// 有效标志 
        /// </summary> 
        /// <returns></returns> 
        [Column("F_ENABLEDMARK")]
        public int? F_EnabledMark { get; set; }
        /// <summary> 
        /// 备注 
        /// </summary> 
        /// <returns></returns> 
        [Column("F_DESCRIPTION")]
        public int? F_Description { get; set; }
        /// <summary> 
        /// 创建日期 
        /// </summary> 
        /// <returns></returns> 
        [Column("F_CREATEDATE")]
        public DateTime? F_CreateDate { get; set; }
        /// <summary> 
        /// 创建用户主键 
        /// </summary> 
        /// <returns></returns> 
        [Column("F_CREATEUSERID")]
        public string F_CreateUserId { get; set; }
        /// <summary> 
        /// 创建用户 
        /// </summary> 
        /// <returns></returns> 
        [Column("F_CREATEUSERNAME")]
        public string F_CreateUserName { get; set; }
        /// <summary> 
        /// 修改日期 
        /// </summary> 
        /// <returns></returns> 
        [Column("F_MODIFYDATE")]
        public DateTime? F_ModifyDate { get; set; }
        /// <summary> 
        /// 修改用户主键 
        /// </summary> 
        /// <returns></returns> 
        [Column("F_MODIFYUSERID")]
        public string F_ModifyUserId { get; set; }
        /// <summary> 
        /// 修改用户 
        /// </summary> 
        /// <returns></returns> 
        [Column("F_MODIFYUSERNAME")]
        public string F_ModifyUserName { get; set; }
        #endregion

        #region 扩展操作 
        /// <summary> 
        /// 新增调用 
        /// </summary> 
        public void Create()
        { 
            this.F_CreateDate = DateTime.Now;
            UserInfo userInfo = LoginUserInfo.Get();
            this.F_CreateUserId = userInfo.userId;
            this.F_CreateUserName = userInfo.realName;
        }
        /// <summary> 
        /// 编辑调用 
        /// </summary> 
        /// <param name="keyValue"></param> 
        public void Modify(string keyValue)
        {
            this.ID = keyValue;
            this.F_ModifyDate = DateTime.Now;
            UserInfo userInfo = LoginUserInfo.Get();
            this.F_ModifyUserId = userInfo.userId;
            this.F_ModifyUserName = userInfo.realName;
        }
        #endregion
    }
}