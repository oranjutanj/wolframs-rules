using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolframsRules.Common
{
    public static class RowFactory
    {
        public static Row CreateFirst(int rowWidth)
        {
            if (rowWidth < 10)
                throw new ArgumentException("row width should be more than 10 to give adequate output");

            // Defaults to middle square is 1 / 'on', could customise first row generation later
            int median = (int)(rowWidth / 2);
            List<Cell> cells = new List<Cell>();
            for (int i = 0; i < rowWidth; i++)
            {
                if (i != median)
                    cells.Add(new Cell(0));
                else
                    cells.Add(new Cell(1));
            }

            var firstRow = new Row(cells);
            return firstRow;
        }

        public static Row GenerateNext(Rules rules, Row previousRow)
        {
            var cells = new List<Cell>();
            foreach (var item in previousRow.Cells)
            {
                cells.Add(new Cell(item.Flag == 1 ? 0 : 1));
            }
            var row = new Row(cells);
            return row;
        }
    }
}
