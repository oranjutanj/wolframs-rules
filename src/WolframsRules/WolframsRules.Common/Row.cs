using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolframsRules.Common
{
    public class Row
    {
        public Row(List<Cell> cells)
        {
            Cells = cells;
        }

        public int Width { get { return Cells.Count; } }
        public List<Cell> Cells { get; private set; }
    }
}
