﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity.Infrastructure.Interception;
using System.Text;

namespace DB.DAL.CORE
{
    public class DbInterceptor : IDbCommandInterceptor
    {
        public void NonQueryExecuting(DbCommand command, DbCommandInterceptionContext<int> interceptionContext)
        {
            //throw new NotImplementedException("NonQueryExecuting");
            Console.WriteLine("NonQueryExecuting");
        }

        public void NonQueryExecuted(DbCommand command, DbCommandInterceptionContext<int> interceptionContext)
        {
            //throw new NotImplementedException("NonQueryExecuted");
            Console.WriteLine("NonQueryExecuted");
        }

        public void ReaderExecuting(DbCommand command, DbCommandInterceptionContext<DbDataReader> interceptionContext)
        {
            //throw new NotImplementedException("ReaderExecuting");
            Console.WriteLine("ReaderExecuting");
        }

        public void ReaderExecuted(DbCommand command, DbCommandInterceptionContext<DbDataReader> interceptionContext)
        {
            //throw new NotImplementedException("ReaderExecuted");
            Console.WriteLine("ReaderExecuted");
        }

        public void ScalarExecuting(DbCommand command, DbCommandInterceptionContext<object> interceptionContext)
        {
            //throw new NotImplementedException("ScalarExecuting");
            Console.WriteLine("ScalarExecuting");
        }

        public void ScalarExecuted(DbCommand command, DbCommandInterceptionContext<object> interceptionContext)
        {
            //throw new NotImplementedException("ScalarExecuted");
            Console.WriteLine("ScalarExecuted");
        }
    }
}
