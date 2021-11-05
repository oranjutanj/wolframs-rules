using System;
using System.Diagnostics;
using WolframsRules.Common;
using Xunit;

namespace WolframsRules.Tests
{
    public class RulesTests
    {
        [Fact]
        public void NumberingSystem_Patterns_ReturnsExpectedValues()
        {
            var rules = new Rules(10, Rules.EdgeCase.WhiteBorder);
            var cl = new Cell(0);
            var cc = new Cell(1);
            var cr = new Cell(0);

            var patternIndex = rules.GetPatternIndex(cl, cc, cr);
            Assert.Equal<int>(2, patternIndex);

            rules = new Rules(10, Rules.EdgeCase.WhiteBorder);
            cl = new Cell(1);
            cc = new Cell(1);
            cr = new Cell(1);

            patternIndex = rules.GetPatternIndex(cl, cc, cr);
            Assert.Equal<int>(7, patternIndex);
        }

        [Fact]
        public void Rules_ReturnsCorrectState()
        {
            foreach (var test in RuleDefinitionsHelper.GetTestDefinitions())
            {
                Debug.WriteLine("Testing Rule " + test.RuleNumber + " ; " + test.States.ToString());
                for (int i = 0; i < test.States.Length; i++)
                {
                    Debug.Write(i + " ");
                    int predictedState = GetNewState(test.RuleNumber, (i & 4) / 4, (i & 2) / 2, i & 1);
                    Assert.Equal<int>(test.States[i], predictedState);
                }
            }
        }

        //[Fact]
        //public void Rules_ReturnsInvalidState()
        //{
        //    foreach (var test in RuleDefinitionsHelper.GetInvalidDefinitions())
        //    {
        //        Debug.WriteLine("Testing Rule " + test.RuleNumber + " ; " + test.States.ToString());
        //        for (int i = 0; i < test.States.Length; i++)
        //        {
        //            Debug.Write(i + " ");
        //            int predictedState = GetNewState(test.RuleNumber, (i & 4) / 4, (i & 2) / 2, i & 1);
        //            Assert.NotEqual<int>(test.States[i], predictedState);
        //        }
        //    }
        //}

        // Helpers
        private int GetNewState(int ruleNumber, int leftCellState, int centreCellState, int rightCellState)
        {
            var rules = new Rules(ruleNumber, Rules.EdgeCase.WhiteBorder);
            var cl = new Cell(leftCellState);
            var cc = new Cell(centreCellState);
            var cr = new Cell(rightCellState);

            return rules.GetNewState(cl, cc, cr);
        }

    }
}
