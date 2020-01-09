using NLog;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Logging
{
    //https://www.c-sharpcorner.com/article/net-core-web-api-logging-using-nlog-in-text-file/
    //https://www.c-sharpcorner.com/article/how-to-implement-nlog-in-webapi/
    public class NLogging : INLogging
    {
        private ILogger logger = LogManager.GetCurrentClassLogger();

        public NLogging()
        {
        }

        public void Information(string message)
        {

            var Reflection = new StackTrace().GetFrame(1).GetMethod();
            var ClassName = Reflection.ReflectedType.Name;
            var MethodName = Reflection.Name;
            logger.Info("Class: " + ClassName + "; Method: " + MethodName + "; Message: " + message);
        }

        public void Warning(string message)
        {
            logger.Warn(message);
        }

        public void Debug(string message)
        {
            logger.Debug(message);
        }

        public void CustomError(string message)
        {
            logger.Error(message);
        }
        public void Error(Exception ex)
        {

            var Reflection = new StackTrace().GetFrame(1).GetMethod();
            var ClassName = Reflection.ReflectedType.Name;
            var MethodName = Reflection.Name;
            logger.Error("Class: " + ClassName  + "; Method: " + MethodName + "; LineNo: " + LineNumber(ex) + "; Message: " + ex.Message);

        }
        private int LineNumber(Exception ex)
        {
            var lineNumber = 0;
            const string lineSearch = ":line ";
            var index = ex.StackTrace.LastIndexOf(lineSearch);
            if (index != -1)
            {
                var lineNumberText = ex.StackTrace.Substring(index + lineSearch.Length);
                if (int.TryParse(lineNumberText, out lineNumber))
                {
                }
            }
            return lineNumber;
        }
    }
}
