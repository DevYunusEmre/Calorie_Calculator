using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using NES_Core_CalorieCalculator.DAL.Context;
using NES_Core_CalorieCalculator.DAL.Interfaces;
using NES_Core_CalorieCalculator.DataCore.Abstracts;
using NES_Core_CalorieCalculator.DataCore.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NES_Core_CalorieCalculator.DAL.Concretes
{
    public class RepoBase<T> : IRepoBase<T> where T : Base, IBase
    {
        private readonly AppDbContext context;
        private readonly DbSet<T> table;

        public RepoBase(AppDbContext _context)
        {
            this.context = _context;
            this.table = context.Set<T>();
        }

        public int Create(T entity)
        {
            table.Add(entity);
            return context.SaveChanges();
        }
        public int Update(T entity)
        {
            table.Update(entity);
            return context.SaveChanges();
        }

        public int Delete(T entity)
        {
            entity.Status = Status.Dropped;
            entity.DropDate = DateTime.Now;
            return context.SaveChanges();
        }
        public T GetById(int id) => table.Find(id);

        public bool GetAny(Expression<Func<T, bool>> expression) => table.Any(expression);
        public IList<T> GetAll() => table.ToList();


        public IList<TResult> GetFilteredList<TResult>(Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> join = null)
        {
            IQueryable<T> query = table;
            if (join != null)
                query = join(query);
            if (where != null)
                query = query.Where(where);
            if (orderBy != null)
                return orderBy(query).Select(select).ToList();
            else
                return query.Select(select).ToList();
        }

        public TResult GetFilteredListFirstOrDefault<TResult>(Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> join = null)
        {
            IQueryable<T> query = table;
            if (join != null)
                query = join(query);
            if (where != null)
                query = query.Where(where);
            if (orderBy != null)
                return orderBy(query).Select(select).FirstOrDefault();
            else
                return query.Select(select).FirstOrDefault();
        }
    }
}
