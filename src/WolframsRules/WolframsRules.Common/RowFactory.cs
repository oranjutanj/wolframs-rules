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
            int newState = 0;
            for (int i = 0; i < previousRow.Cells.Count; i++)
            {
                // Assuming whitespace edges
                // TODO can cope with this differently depending on edgcase enum
                if (i > 0 && i < previousRow.Cells.Count - 1)
                {
                    newState = rules.GetNewState(previousRow.Cells.ElementAt(i - 1), previousRow.Cells.ElementAt(i), previousRow.Cells.ElementAt(i + 1));
                }
                cells.Add(new Cell(newState));
            }

            var row = new Row(cells);
            return row;
        }
    }
}
