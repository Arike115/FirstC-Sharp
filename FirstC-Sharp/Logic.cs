using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Sharp
{
    /// <summary>
    /// this class is all about calculations
    /// it contains two methods with different parameters.
    /// </summary>
    
    public class Logic
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="FirstValue"></param>
        /// <param name="SecondValue"></param>
        /// <returns></returns>

        [Obsolete("use AddNum method that has 3 parameter value")]
        public static int AddNum(int FirstValue, int SecondValue)
        {
            return FirstValue + SecondValue;
        }

        #region to be reconstruct later

        /// <summary>
        /// AddNum method sum data together
        /// </summary>
        /// <param name="FirstValue"></param>
        /// <param name="SecondValue"></param>
        /// <param name="ThirdValue"></param>
        /// <returns>returns and interger value</returns>
        public static int AddNum(int FirstValue, int SecondValue, int ThirdValue)
        {
            return FirstValue + SecondValue + ThirdValue;
        }
        #endregion

    }
}
