using System.Collections.Generic;

namespace GameFramework.Data
{
    /// <summary>
    /// 数据管理器接口。
    /// </summary>
    public interface IDataManager
    {
        /// <summary>
        /// 获取数据数量。
        /// </summary>
        int DataCount { get; }

        /// <summary>
        /// 获取指定类型的数据。
        /// </summary>
        /// <typeparam name="T">数据类型。</typeparam>
        /// <returns>指定类型的数据。</returns>
        T GetData<T>() where T : Data;

        /// <summary>
        /// 获取指定名称的数据。
        /// </summary>
        /// <param name="name">数据名称。</param>
        /// <returns>指定名称的数据。</returns>
        Data GetData(string name);

        /// <summary>
        /// 判断是否存在指定类型的数据。
        /// </summary>
        /// <typeparam name="T">数据类型。</typeparam>
        /// <returns>是否存在指定类型的数据。</returns>
        bool HasData<T>() where T : Data;

        /// <summary>
        /// 判断是否存在指定名称的数据。
        /// </summary>
        /// <param name="name">数据名称。</param>
        /// <returns>是否存在指定名称的数据。</returns>
        bool HasData(string name);

        /// <summary>
        /// 获取所有数据。
        /// </summary>
        /// <returns>所有数据的数组。</returns>
        Data[] GetAllData();

        /// <summary>
        /// 获取所有数据。
        /// </summary>
        /// <param name="result">存储所有数据的列表。</param>
        void GetAllData(List<Data> result);

        /// <summary>
        /// 添加指定类型的数据。
        /// </summary>
        /// <typeparam name="T">数据类型。</typeparam>
        void AddData<T>() where T : Data;

        /// <summary>
        /// 添加数据。
        /// </summary>
        /// <param name="Data">要添加的数据。</param>
        void AddData(Data Data);

        /// <summary>
        /// 移除指定类型的数据。
        /// </summary>
        /// <typeparam name="T">数据类型。</typeparam>
        void RemoveData<T>() where T : Data;

        /// <summary>
        /// 移除数据。
        /// </summary>
        /// <param name="Data">要移除的数据。</param>
        void RemoveData(Data Data);

        /// <summary>
        /// 初始化所有数据。
        /// </summary>
        void InitAllData();

        /// <summary>
        /// 预加载所有数据。
        /// </summary>
        void PreLoadAllData();

        /// <summary>
        /// 加载所有数据。
        /// </summary>
        void LoadAllData();

        /// <summary>
        /// 卸载所有数据。
        /// </summary>
        void UnLoadAllData();
    }
}


