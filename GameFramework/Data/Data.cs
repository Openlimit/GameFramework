
namespace GameFramework.Data
{
    /// <summary>
    /// 抽象类 Data，实现 IData 接口。
    /// </summary>
    public abstract class Data : IData
    {
        /// <summary>
        /// 获取数据名称。
        /// </summary>
        public virtual string Name
        {
            get
            {
                return this.GetType().ToString();
            }
        }

        /// <summary>
        /// 初始化数据。
        /// </summary>
        public abstract void Init();

        /// <summary>
        /// 预加载数据。
        /// </summary>
        public abstract void Preload();

        /// <summary>
        /// 加载数据。
        /// </summary>
        public abstract void Load();

        /// <summary>
        /// 卸载数据。
        /// </summary>
        public abstract void Unload();

        /// <summary>
        /// 关闭数据。
        /// </summary>
        public abstract void Shutdown();
    }
}

