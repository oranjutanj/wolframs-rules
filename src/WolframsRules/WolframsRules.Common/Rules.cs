using System;
using System.Collections.Generic;

namespace WolframsRules.Common
{
    public class Rules
    {
        private int[] _states = new int[8];
        int _ruleNumber;

        // Will define how we define the literal edge cases of a grid
        public enum EdgeCase
        {
            WhiteBorder = 1
        }

        public Rules(int ruleNumber, EdgeCase edgeCase)
        {
            _ruleNumber = ruleNumber;
            PopulateStates();
        }

        /// <summary>
        /// Gets the pattern index, using the table defined in Wolfram's numbering system, 0 based starting from the right as in binary format
        /// </summary>
        /// <remarks>
        /// e.g. 
        /// 111 110 101 100 011 010 001 000
        /// [7] [6] [5] [4] [3] [2] [1] [0]
        /// </remarks>
        /// <param name="left"></param>
        /// <param name="centre"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public int GetPatternIndex(Cell left, Cell centre, Cell right)
        {
            return (left.State * 4) + (centre.State * 2) + (right.State * 1);
        }

        public int GetNewState(Cell left, Cell centre, Cell right)
        {
            int index = GetPatternIndex(left, centre, right);
            return _states[index];
        }

        private void PopulateStates()
        {
            //There's probably a better way to do this
            _states[0] = (_ruleNumber & 1) / 1;
            _states[1] = (_ruleNumber & 2) / 2;
            _states[2] = (_ruleNumber & 4) / 4;
            _states[3] = (_ruleNumber & 8) / 8;
            _states[4] = (_ruleNumber & 16) / 16;
            _states[5] = (_ruleNumber & 32) / 32;
            _states[6] = (_ruleNumber & 64) / 64;
            _states[7] = (_ruleNumber & 128) / 128;
        }
    }
}
