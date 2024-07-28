using Microsoft.EntityFrameworkCore.Query;
using NES_Core_CalorieCalculator.DataCore.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NES_Core_CalorieCalculator.DAL.Interfaces
{
    /// <summary>
    /// Bu generic interface sadece IBase interface'ine sahip sınıflar kullanabilmesi için "where T : IBase" dedim.
    /// Oluşturulacak Repo'lar için kalıtım alınan sınıflarda implement edilmek üzere kullanılması zorunlu metotları belirtiyorum  
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepoBase<T> where T : IBase
    {
        int Create(T entity);
        int Update(T entity);
        int Delete(T entity);   
        T GetById(int id);
        bool GetAny(Expression<Func<T, bool>> expression);
        IList<T> GetAll(); 

        IList<TResult> GetFilteredList<TResult>
            (
            Expression<Func<T, TResult>> select,//Iquerble oldu için expression kullanıyoruz.
            Expression<Func<T, bool>> where = null,//default parametreli yapmış olduk eğer vermezse null geçer istemez
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>> join = null
            );

        TResult GetFilteredListFirstOrDefault<TResult>
            (
            Expression<Func<T, TResult>> select,//Iquerble oldu için expression kullanıyoruz.
            Expression<Func<T, bool>> where = null,//default parametreli yapmış olduk eğer vermezse null geçer istemez
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>> join = null
            );



    }
}
