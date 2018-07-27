﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bing.ElasticSearch
{
    /// <summary>
    /// ElasticSearch 管理器
    /// </summary>
    public interface IElasticSearchManager
    {
        /// <summary>
        /// 创建索引。不映射
        /// </summary>
        /// <param name="indexName">索引名</param>
        /// <returns></returns>
        Task CreateIndexAsync(string indexName);

        /// <summary>
        /// 创建索引。自动映射实体属性
        /// </summary>
        /// <typeparam name="T">实体类型</typeparam>
        /// <param name="indexName">索引名</param>
        /// <returns></returns>
        Task CreateIndexAsync<T>(string indexName) where T : class;

        /// <summary>
        /// 重置索引
        /// </summary>
        /// <typeparam name="T">实体类型</typeparam>
        /// <param name="indexName">索引名</param>
        /// <returns></returns>
        Task ResetIndexAsync<T>(string indexName) where T : class;

        /// <summary>
        /// 删除索引
        /// </summary>
        /// <param name="indexName">索引名</param>
        /// <returns></returns>
        Task DeleteIndexAsync(string indexName);

        /// <summary>
        /// 重新构建索引
        /// </summary>
        /// <typeparam name="T">实体类型</typeparam>
        /// <param name="indexName">索引名</param>
        /// <returns></returns>
        Task ReBuild<T>(string indexName) where T:class;

        /// <summary>
        /// 保存
        /// </summary>
        /// <typeparam name="T">实体类型</typeparam>
        /// <param name="indexName">索引名</param>
        /// <param name="entity">实体</param>
        /// <returns></returns>
        Task SaveAsync<T>(string indexName, T entity) where T : class;

        /// <summary>
        /// 批量保存
        /// </summary>
        /// <typeparam name="T">实体类型</typeparam>
        /// <param name="indexName">索引名</param>
        /// <param name="entities">实体集合</param>
        /// <param name="bulkNum">批量操作数</param>
        /// <returns></returns>
        Task BulkSaveAsync<T>(string indexName, List<T> entities, int bulkNum = 1000) where T : class;

        /// <summary>
        /// 删除
        /// </summary>
        /// <typeparam name="T">实体类型</typeparam>
        /// <param name="indexName">索引名</param>
        /// <param name="typeName">类型名</param>
        /// <param name="entity">实体</param>
        /// <returns></returns>
        Task DeleteAsync<T>(string indexName, string typeName, T entity) where T : class;

        /// <summary>
        /// 批量删除
        /// </summary>
        /// <typeparam name="T">实体类型</typeparam>
        /// <param name="indexName">索引名</param>
        /// <param name="entities">实体集合</param>
        /// <param name="bulkNum">批量操作数</param>
        /// <returns></returns>
        Task BulkDeleteAsync<T>(string indexName, List<T> entities, int bulkNum = 1000) where T : class;
    }
}
