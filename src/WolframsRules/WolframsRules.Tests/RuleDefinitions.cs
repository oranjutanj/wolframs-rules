using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolframsRules.Tests
{
    public static class RuleDefinitionsHelper
    {
        public static List<RuleDefinition> GetTestDefinitions()
        {
            List<RuleDefinition> ruleDefinitions = new List<RuleDefinition>();
            ruleDefinitions.Add(new RuleDefinition()
            {
                RuleNumber = 110,
                States = new int[8] { 0, 1, 1, 1, 0, 1, 1, 0 }
            }
            );
            ruleDefinitions.Add(new RuleDefinition()
            {
                RuleNumber = 30,
                States = new int[8] { 0, 1, 1, 1, 1, 0, 0, 0 }
            }
            );
            ruleDefinitions.Add(new RuleDefinition()
            {
                RuleNumber = 126,
                States = new int[8] { 0, 1, 1, 1, 1, 1, 1, 0 }
            }
            );

            return ruleDefinitions;
        }

        //        public static List<RuleDefinition> GetInvalidDefinitions()
        //        {
        //            List<RuleDefinition> ruleDefinitions = new List<RuleDefinition>();
        //            ruleDefinitions.Add(new RuleDefinition()
        //            {
        //                RuleNumber = 111,
        //                States = new int[8] { 0, 1, 1, 1, 1, 1, 1, 0 }
        //            }
        //            );
        //            ruleDefinitions.Add(new RuleDefinition()
        //            {
        //                RuleNumber = 114,
        //                States = new int[8] { 1, 1, 1, 1, 0, 1, 1, 0 }
        //            }
        //);
        //            ruleDefinitions.Add(new RuleDefinition()
        //            {
        //                RuleNumber = 110,
        //                States = new int[8] { 0, 1, 1, 1, 0, 1, 0, 1 }
        //            }
        //);
        //            return ruleDefinitions;
        //        }

        public static int GetLeftCell(int statePosition)
        {
            return statePosition & 4;
        }
    }

    public class RuleDefinition
    {
        public int RuleNumber { get; set; }
        public int[] States { get; set; } = new int[8];
    }
}
