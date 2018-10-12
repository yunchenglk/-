﻿using System.Collections.Generic;

namespace Learun.Application.AppMagager
{
    /// <summary> 
    /// 版 本V2.3 辰星软件开发框架 
    /// Copyright (c) 2013-2018 山西辰星昇软件科技有限公司 
    /// 创 建：超级管理员 
    /// 日 期：2018-06-26 10:32 
    /// 描 述：我的常用移动应用 
    /// </summary>
    public interface MyFunctionIBLL
    {
        #region 获取数据 

        /// <summary>
        /// 获取列表数据
        /// </summary>
        /// <param name="userId">用户主键ID</param>
        /// <returns></returns>
        IEnumerable<MyFunctionEntity> GetList(string userId);
        #endregion

        #region 提交数据
        /// <summary> 
        /// 保存实体数据（新增、修改） 
        /// <param name="keyValue">主键</param> 
        /// <summary> 
        /// <returns></returns> 
        void SaveEntity(string userId, string strFunctionId);
        #endregion
    }
}
