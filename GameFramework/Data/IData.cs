namespace GameFramework.Data
{
    /// <summary>
    /// 定义数据接口。
    /// </summary>
    public interface IData
    {
        /// <summary>
        /// 获取数据名称。
        /// </summary>
        string Name { get; }

        /// <summary>
        /// 初始化数据。
        /// </summary>
        void Init();

        /// <summary>
        /// 预加载数据。
        /// </summary>
        void Preload();

        /// <summary>
        /// 加载数据。
        /// </summary>
        void Load();

        /// <summary>
        /// 卸载数据。
        /// </summary>
        void Unload();

        /// <summary>
        /// 关闭数据。
        /// </summary>
        void Shutdown();
    }
}

