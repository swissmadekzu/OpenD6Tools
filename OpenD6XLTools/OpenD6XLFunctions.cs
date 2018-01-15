using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelDna.Integration;

namespace OpenD6XLTools
{
    public static class OpenD6XLFunctions
    {
        [ExcelFunction(Description = "Returns dice value for a given pip amount")]
        public static String DSixValue(int pipValue)
        {
            int diceValue = pipValue / 3;
            int remainingPips = pipValue - diceValue * 3;

            if (remainingPips == 0)
            {
                return String.Format("{0}D", diceValue);
            }
            else
            {
                return String.Format("{0}D+{1}", diceValue, remainingPips);
            }
        }
    }
}
