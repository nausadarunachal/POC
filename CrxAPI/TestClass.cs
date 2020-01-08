using CrxAPI.Logging;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrxAPI
{
    public   class TestClass
    {
        //private static INLogging _logger;
        //public TestClass(INLogging logger)
        //{
        //     _logger = logger;
        //}
        private static INLogging _logger;
       // private static IKernel _diContainer;
          static   TestClass( )
        {

            _logger = new NLogging();
        }
        public static string Get(int a)
        {
            try
            {
                var b = (a / 0).ToString();
                return b;
            }
            catch (Exception ex)
            {
                _logger.Error(ex);
                return null;
            }
        }
           
        }
    
}
