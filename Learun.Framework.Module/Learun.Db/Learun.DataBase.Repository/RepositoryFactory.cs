
namespace Learun.DataBase.Repository
{
    /// <summary>
    /// 版 本V2.3 辰星软件开发框架
    /// Copyright (c) 2013-2018 山西辰星昇软件科技有限公司
    /// 创建人：辰星科技 软件开发部
    /// 日 期：2017.03.04
    /// 描 述：定义仓储模型工厂
    /// </summary>
    public class RepositoryFactory
    {
        /// <summary>
        /// 定义仓储
        /// </summary>
        /// <param name="connString">连接字符串</param>
        /// <param name="type">数据库类型</param>
        /// <returns></returns>
        public IRepository BaseRepository(string connString, DatabaseType type)
        {
            return new Repository(DbFactory.GetIDatabase(connString, type));
        }
        /// <summary>
        /// 定义仓储
        /// </summary>
        /// <param name="connString">连接字符串</param>
        /// <param name="type">数据库类型</param>
        /// <returns></returns>
        public IRepository BaseRepository(string connString, string type)
        {
            return new Repository(DbFactory.GetIDatabase(connString, type));
        }
        /// <summary>
        /// 定义仓储
        /// </summary>
        /// <param name="name">连接配置名称</param>
        /// <returns></returns>
        public IRepository BaseRepository(string name)
        {
            return new Repository(DbFactory.GetIDatabase(name));
        }
        /// <summary>
        /// 定义仓储（基础库）
        /// </summary>
        /// <returns></returns>
        public IRepository BaseRepository()
        {
            return new Repository(DbFactory.GetIDatabase());
        }

    }
}
