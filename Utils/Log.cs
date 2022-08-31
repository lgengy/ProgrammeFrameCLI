/********************************************************************
*
* 类  名：Log
*
* 作  者：lgengy
*
* 描  述：通过编程的方式实现log4net配置。GetLogger方法实现参见
*         https://stackoverflow.com/questions/52912682/cant-configure-log4net-logger-programmatically
*
********************************************************************/

using log4net;
using log4net.Appender;
using log4net.Core;
using log4net.Layout;
using log4net.Repository.Hierarchy;
using System.Collections.Generic;

namespace ProgrammeFrameCLI.Utils
{
    public class Log
    {
        private Hierarchy hierarchy = (Hierarchy)LogManager.GetRepository();
        private List<RollingFileAppender> listRollingFileAppender = new List<RollingFileAppender>(2);

        /// <summary>
        /// 日志类构造函数
        /// </summary>
        /// <param name="type">0-所有日志实体都记录到一个文件 1-日志实体记录到各自的文件</param>
        /// <remarks>
        /// type=0时调用单参的GetLogger获取logger实例
        /// type=1时调用多参的GetLogger获取logger实例
        /// </remarks>
        public Log(int type = 0)
        {
            if (type == 0 && listRollingFileAppender.Count == 0)
            {
                listRollingFileAppender = CreateRollingFileAppender("ProgrammeFrameCLI", "ProgrammeFrameCLIErr", @"D:\ProgrammeFrameCLI\", "10MB", 50, true);
                foreach (RollingFileAppender rollingFileAppender in listRollingFileAppender)
                {
                    hierarchy.Root.AddAppender(rollingFileAppender);
                }
            }
        }

        private List<RollingFileAppender> CreateRollingFileAppender(string logName, string logNameError, string logPath, string maxFileSize, int maxLogCount, bool enableErrorLog)
        {
            var patternLayout = new PatternLayout("%date [%2thread] %-5level %method - %message%newline");
            patternLayout.ActivateOptions();

            List<RollingFileAppender> rollingFileAppender = new List<RollingFileAppender>(2);
            rollingFileAppender.Add(new RollingFileAppender
            {
                Name = logName,
                File = logPath + logName + ".log",
                AppendToFile = true,
                PreserveLogFileNameExtension = true,
                MaximumFileSize = maxFileSize,
                MaxSizeRollBackups = maxLogCount,
                StaticLogFileName = true,
                Layout = patternLayout,
            });
            rollingFileAppender[0].ActivateOptions();

            log4net.Filter.IFilter filter, filterEx;
            if (enableErrorLog)
            {
                rollingFileAppender.Add(new RollingFileAppender
                {
                    Name = logNameError,
                    File = logPath + logNameError + ".log",
                    AppendToFile = true,
                    PreserveLogFileNameExtension = true,
                    MaximumFileSize = maxFileSize,
                    MaxSizeRollBackups = maxLogCount,
                    StaticLogFileName = true,
                    Layout = patternLayout,
                });
                rollingFileAppender[1].ActivateOptions();

                filter = new log4net.Filter.LevelRangeFilter() { LevelMin = Level.Debug, LevelMax = Level.Warn };
                filterEx = new log4net.Filter.LevelRangeFilter() { LevelMin = Level.Error, LevelMax = Level.Fatal };
                filter.ActivateOptions();
                filterEx.ActivateOptions();

                rollingFileAppender[0].AddFilter(filter);
                rollingFileAppender[1].AddFilter(filterEx);
            }

            return rollingFileAppender;
        }

        /// <summary>
        /// 获取ILog实例
        /// </summary>
        /// <param name="name">实例名，重复的话则使用已有的实例</param>
        /// <param name="enableErrorLog">是否单独记录错误日志</param>
        /// <param name="additivity">日志是否同时写入父实例的appender</param>
        /// <param name="logName">日志名，不能重复</param>
        /// <param name="logNameError">错误日志名，不能重复</param>
        /// <param name="logPath">日志路径，默认D:\Fiscan\Log\</param>
        /// <param name="maxFileSize">日志最大容量,单位KB、MB、GB，默认10MB</param>
        /// <param name="maxLogCount">日志最大保存数，默认50</param>
        /// <remarks>
        /// 根据传入的信息的为每一个logger实例都创建自己的appender
        /// </remarks>
        public ILog GetLogger(string name, bool enableErrorLog, bool additivity, string logName, string logNameError, string logPath = "", string maxFileSize = "10MB", int maxLogCount = 50)
        {
            var logger = hierarchy.GetLogger(name, hierarchy.LoggerFactory);
            logger.Hierarchy = hierarchy;
            foreach (RollingFileAppender rollingFileAppender in CreateRollingFileAppender(logName, logNameError, logPath, maxFileSize, maxLogCount, enableErrorLog))
            {
                if (rollingFileAppender != null) logger.AddAppender(rollingFileAppender);
            }
            logger.Repository.Configured = true;
            logger.Level = Level.Debug;
            logger.Additivity = additivity;

            //var x = hierarchy.GetCurrentLoggers();//测试用

            return LogManager.GetLogger(name);
        }

        /// <summary>
        /// 获取ILog实例
        /// </summary>
        /// <param name="name">实例名</param>
        /// <remarks>所有日志都记录在同一个文件里</remarks>
        public ILog GetLogger(string name)
        {
            var logger = hierarchy.GetLogger(name, hierarchy.LoggerFactory);
            logger.Hierarchy = hierarchy;
            logger.Repository.Configured = true;
            logger.Level = Level.Debug;

            return LogManager.GetLogger(name);
        }
    }
}
