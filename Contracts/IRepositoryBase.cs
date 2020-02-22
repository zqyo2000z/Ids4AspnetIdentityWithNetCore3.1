using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Contracts
{
   public  interface IRepositoryBase<T>
    {
        IQueryable<T> FindAll();
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);
       // void Create(T entity);
        void Update(T entity);
        void Delete(T entity);

        #region 插入数据
        /// <summary>
        /// 插入数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        void Insert(T t);
        #endregion

        #region 批量插入数据
        /// <summary>
        /// 批量插入数据
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        void Insert(IList<T> t);
        #endregion

      

        #region 根据编号删除数据
        /// <summary>
        /// 根据编号删除数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        void Delete<Value>(int id);
        #endregion

        #region 根据Lambda表达式删除
        /// <summary>
        /// 根据Lambda表达式删除
        /// </summary>
        /// <param name="whereLambda"></param>
        /// <returns></returns>
        void Delete(Expression<Func<T, bool>> whereLambda);
        #endregion

      

        #region 批量修改
        /// <summary>
        /// 批量修改
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        void Update(IList<T> entities);
        #endregion

       

        #region 根据主键进行查询
        /// <summary>
        /// 根据主键进行查询
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        T FindByID(int Id);
        #endregion

        #region 默认查询选择第一条数据，没有那么返回null
        /// <summary>
        /// 默认查询选择第一条数据，没有那么返回null
        /// </summary>
        /// <param name="whereLambda"></param>
        /// <returns></returns>
        T GetFirstDefault(Expression<Func<T, bool>> whereLambda = null);
        #endregion

        #region 查询所有的数据
        /// <summary>
        /// 查询所有的数据
        /// </summary>
        /// <param name="whereLambda"></param>
        /// <returns></returns>
        IQueryable<T> GetAll(string whereLambda = null);
        #endregion

       

        #region  获取数量
        /// <summary>
        /// 获取数量
        /// </summary>
        /// <param name="whereLambda"></param>
        /// <returns></returns>
        int GetCount(Expression<Func<T, bool>> whereLambda = null);
        #endregion



        #region 执行sql
        /// <summary>
        /// 执行sql
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="dyParmaters"></param>
        /// <returns></returns>
        void ExecuteSQL(string sql, object dyParmaters = null);
        #endregion

        #region 执行查询自定义对象集合
        /// <summary>
        /// 执行查询自定义对象集合
        /// </summary>
        /// <typeparam name="Value"></typeparam>
        /// <param name="sql"></param>
        /// <param name="dyParmaters"></param>
        /// <returns></returns>
        IQueryable<Value> Reader<Value>(string sql, object dyParmaters = null);
        #endregion
         
        IQueryable<Value> ReaderSingle<Value>(string sql, object dyParmaters = null);

       
       

        #region 执行SQL 语句返回一行一列值
        /// <summary>
        /// 执行SQL 语句返回一行一列值
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="dyParmaters"></param>
        /// <returns></returns>
        Value ExecuteScalar<Value>(string sql, object dyParmaters = null);
        #endregion
    }
}
