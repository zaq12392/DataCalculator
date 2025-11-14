using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCalculator
{
    public class CostEventData
    {
        /// <summary>
        /// 流水號
        /// </summary>
        public int ID;
        /// <summary>
        /// 名稱
        /// </summary>
        public string Name;
        /// <summary>
        /// 目前計數器
        /// </summary>
        public int Count = 0;
        /// <summary>
        /// 價值
        /// </summary>
        public int Cost;
        /// <summary>
        /// 當前價值
        /// </summary>
        public int NowPoint = 0;
    }
}
