using DGDean.Models.Base;
using DGDean.Utils.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DB.DAL.CORE
{
    public class CRUDGeneric
   
    {
       
        public static T Add<T>(
            T model,
            bool useWriteDb = false)
            where T : BaseModel
        {
            using (var db = new ContextDb(useWriteDb))
            {
                db.Set<T>().Add(model);

                db.SaveChanges();

                return model;
            }
        }

        public static async Task<T> AddAsync<T>(
            T model) where T : BaseModel
        {
            using (var db = new ContextDb())
            {
                db.Set<T>().Add(model);
                await db.SaveChangesAsync();
                return model;
            }
        }

        public static List<T> AddRange<T>(List<T> models) where T : BaseModel
        {
            if (models?.Count > 0)
            {
                using (var db = new ContextDb())
                {
                    db.Set<T>().AddRange(models);
                    db.SaveChanges();
                }
            }
            return models;
        }

        public static T Update<T>(
            T model,
            bool useWriteDb = false)
            where T : BaseModel
        {
            using (var db = new ContextDb(useWriteDb))
            {
                db.Set<T>().Attach(model);
                db.Entry(model).State = EntityState.Modified;

                db.SaveChanges();

                return model;
            }
        }

        public static async Task<T> UpdateAsync<T>(T model) where T : BaseModel
        {
            using (var db = new ContextDb())
            {
                db.Set<T>().Attach(model);
                db.Entry(model).State = EntityState.Modified;

                await db.SaveChangesAsync();

                return model;
            }
        }

        public static T AddOrUpdate<T>
            (T model,
            bool useWriteDb = false)
            where T : BaseModel
        {
            using (var db = new ContextDb(useWriteDb))
            {
                db.Set<T>().AddOrUpdate(model);

                db.SaveChanges();

                return model;
            }
        }

        public static async Task<T> AddOrUpdateAsync<T>(T model, bool useWritedb = true) where T : BaseModel
        {
            using (var db = new ContextDb(useWritedb))
            {
                db.Set<T>().AddOrUpdate(model);

                await db.SaveChangesAsync();

                return model;
            }
        }

        public static T Get<T>(int id) where T : BaseModel
        {
            using (var db = new ContextDb())
            {
                var item = db.Set<T>().Find(id);

                return item;
            }
        }

        public static async Task<T> GetAsync<T>(int id) where T : BaseModel
        {
            using (var db = new ContextDb())
            {
                var item = await db.Set<T>().FindAsync(id);

                return item;
            }
        }

        public static T Get<T>(
            Expression<Func<T, bool>> predicate,
            bool useWriteDb = false,
            params Expression<Func<T, object>>[] includes)
            where T : BaseModel
        {
            using (var db = new ContextDb(useWriteDb))
            {
                var dbSet = db.Set<T>().AsQueryable();

                foreach (var property in includes)
                {
                    dbSet = dbSet.Include(property);
                }

                return dbSet.Where(predicate).SingleOrDefault();
            }
        }

        public static async Task<T> GetAsync<T>(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes) where T : BaseModel
        {
            using (var db = new ContextDb())
            {
                var dbSet = db.Set<T>().AsQueryable();

                foreach (var property in includes)
                {
                    dbSet = dbSet.Include(property);
                }

                var result = await dbSet.SingleOrDefaultAsync(predicate);

                return result;
            }
        }

        public static List<T> GetAll<T>() where T : BaseModel
        {
            using (var db = new ContextDb())
            {
                var results = db.Set<T>().ToList();

                return results;
            }
        }

        public static List<T> Query<T>(
            Expression<Func<T, bool>> predicate,
            bool useWriteDb = false,
            params Expression<Func<T, object>>[] includes)
            where T : BaseModel
        {
            using (var db = new ContextDb(useWriteDb))
            {
                var dbSet = db.Set<T>().AsQueryable();

                foreach (var property in includes)
                {
                    dbSet = dbSet.Include(property);
                }

                return dbSet.Where(predicate).ToList();
            }
        }

        public static int Count<T>(
            Expression<Func<T, bool>> predicate,
            bool useWriteDb = false)
            where T : BaseModel
        {
            using (var db = new ContextDb(useWriteDb))
            {
                var dbSet = db.Set<T>().AsQueryable();
                return dbSet.Where(predicate).Count();
            }
        }

        public static bool Contains<T>(Func<T, string> property, string value) where T : BaseModel
        {
            using (var db = new ContextDb())
            {
                var items = db.Set<T>().Select(property);

                return items.Contains(value, StringComparer.OrdinalIgnoreCase);
            }
        }

        public static bool Contains(string fieldName, string idName, string tableName, string valueToCheck, int idValue)
        {
            using (var db = new ContextDb())
            {
                var exists = db.Database.SqlQuery<int>(@"CheckUniqueness @FieldName,
                                                                         @IdField,
                                                                         @TableName,
                                                                         @ValueToCheck,
                                                                         @IdBeingUpdated",
                                   new SqlParameter("@FieldName", fieldName),
                                   new SqlParameter("@IdField", idName),
                                   new SqlParameter("@TableName", tableName),
                                   new SqlParameter("@ValueToCheck", valueToCheck),
                                   new SqlParameter("@IdBeingUpdated", idValue)).Single();

                return exists == 1;
            }
        }

    }
}
