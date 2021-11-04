using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolframsRules.Common
{
    public class Cell
    {
        public Cell(int flag)
        {
            if (flag < 0 || flag > 1)
                throw new ArgumentException("Cell flag must be 0 or 1");
            Flag = flag;
        }

        public int Flag { get; private set; }
    }
}
