/********************************************************************************

** 类名称： GlobalData

** 描述：存放全局使用的变量、函数等

*********************************************************************************/

using log4net;

namespace ProgrammeFrameCLI.Common
{
    class GlobalData
    {
        public static readonly ILog logger = new Utils.Log(0).GetLogger("CLI");
    }
}
