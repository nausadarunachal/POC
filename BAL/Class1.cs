using System;

namespace BAL
{
    public class GenericBO
    {
        public static T Add<T>(
          T model,
          bool useWriteDb = false)
          where T : BaseModel
        {
            return DBGeneric.Add(model, useWriteDb);
        }
    }
}
