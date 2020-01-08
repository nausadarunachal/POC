namespace BAL
{
    using DB.DAL.CORE;
    using DGDean.Models.Base;
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using System.Text;
    using System.Threading.Tasks;
    public class GenericBAL
    {
        public static T Add<T>(
            T model,
            bool useWriteDb = false)
            where T : BaseModel
        {
            return CRUDGeneric.Add(model, useWriteDb);
        }

        public static Task<T> AddAsync<T>(T model) where T : BaseModel
        {
            return CRUDGeneric.AddAsync(model);
        }

        public static List<T> AddRange<T>(List<T> models) where T : BaseModel
        {
            return CRUDGeneric.AddRange(models);
        }

        public static T Update<T>(
            T model,
            bool useWriteDb = false)
            where T : BaseModel
        {
            return CRUDGeneric.Update(model, useWriteDb);
        }

        public static Task<T> UpdateAsync<T>(T model) where T : BaseModel
        {
            return CRUDGeneric.UpdateAsync(model);
        }

        public static T AddOrUpdate<T>(
            T model,
            bool useWriteDb = false)
            where T : BaseModel
        {
            return CRUDGeneric.AddOrUpdate(model, useWriteDb);
        }

        public static Task<T> AddOrUpdateAsync<T>(T model) where T : BaseModel
        {
            return CRUDGeneric.AddOrUpdateAsync(model);
        }

        public static T Get<T>(int id) where T : BaseModel
        {
            return CRUDGeneric.Get<T>(id);
        }

        public static async Task<T> GetAsync<T>(int id) where T : BaseModel
        {
            return await CRUDGeneric.GetAsync<T>(id);
        }

        public static T Get<T>(
            Expression<Func<T, bool>> predicate,
            bool useWriteDb = false,
            params Expression<Func<T, object>>[] includes) where T : BaseModel
        {
            return CRUDGeneric.Get(predicate, useWriteDb, includes);
        }

        public static Task<T> GetAsync<T>(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes) where T : BaseModel
        {
            return CRUDGeneric.GetAsync(predicate, includes);
        }

        public static List<T> GetAll<T>() where T : BaseModel
        {
            return CRUDGeneric.GetAll<T>();
        }

        public static List<T> Query<T>(
            Expression<Func<T, bool>> predicate,
            bool useWriteDb = false,
            params Expression<Func<T, object>>[] includes)
            where T : BaseModel
        {
            return CRUDGeneric.Query(predicate, useWriteDb, includes);
        }

        public static int Count<T>(
            Expression<Func<T, bool>> predicate,
            bool useWriteDb = false) where T : BaseModel
        {
            return CRUDGeneric.Count(predicate, useWriteDb);
        }

        public static bool Contains<T>(Func<T, string> property, string value) where T : BaseModel
        {
            return CRUDGeneric.Contains(property, value);
        }

        public static bool Contains(string fieldName, string idName, string tableName, string valueToCheck, int idValue)
        {
            return CRUDGeneric.Contains(fieldName, idName, tableName, valueToCheck, idValue);
        }
        public static string PadMonthAndDaywithZero(string oldFormat)
        {
            string[] dateparts = oldFormat.Split('/');

            if (dateparts.Length != 3)
                return oldFormat;

            string month = dateparts[0];
            string day = dateparts[1];
            string year = dateparts[2];

            if (month.Length == 1)
            {
                month = $"0{month}";
            }

            if (day.Length == 1)
            {
                day = $"0{day}";
            }

            return $"{month}/{day}/{year}";
        }

        public class GenericSet<t>
        {
            public t model { get; set; }
            public int EntityTypeId { get; set; }
            public int? EntityId { get; set; }

        }

    }
}
