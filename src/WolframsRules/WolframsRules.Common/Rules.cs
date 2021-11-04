using System;

namespace WolframsRules.Common
{
    public class Rules
    {
        // Will define how we define the literal edge cases of a grid
        public enum EdgeCase
        {
            WhiteBorder = 1
        }

        int _ruleNumber;
        public Rules(int ruleNumber, EdgeCase edgeCase)
        {
            ruleNumber = _ruleNumber;
        }
    }
}
