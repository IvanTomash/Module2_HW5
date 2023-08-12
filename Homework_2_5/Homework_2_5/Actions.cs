using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2_5
{
    internal class Actions
    {
        public void FirstMethod()
        {
            Logger.Instance.LogInfo(LogTypes.Info, "Start method");
        }

        public void SecondMethod()
        {
           throw new BusinessException("Skipped logic in method");
        }

        public void ThirdMethod()
        {
            throw new Exception("I broke a logic");
        }
    }
}
