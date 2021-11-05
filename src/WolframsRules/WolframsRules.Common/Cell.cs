using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolframsRules.Common
{
    public class Cell
    {
        public Cell(int state)
        {
            if (state < 0 || state > 1)
                throw new ArgumentException("Cell flag must be 0 or 1");
            State = state;
        }

        public int State { get; private set; }
        public string GetFlagCharacter(char character)
        {
            return State == 1 ? character.ToString() : " ";
        }
    }
}
