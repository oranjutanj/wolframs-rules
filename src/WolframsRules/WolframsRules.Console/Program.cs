using System;
using WolframsRules.Common;

namespace WolframsRules.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var currentRow = WolframsRules.Common.RowFactory.CreateFirst(50);
            WriteRow(currentRow);
          
            
            var rules = new Rules(90, Rules.EdgeCase.WhiteBorder);
            for (int i = 0; i < 40; i++)
            {
                Console.WriteLine();
                var newRow = RowFactory.GenerateNext(rules, currentRow);
                currentRow = newRow;
                WriteRow(newRow);
            }
        }

        static void WriteRow(Row row)
        {
            foreach (var item in row.Cells)
            {
                Console.Write(item.GetFlagCharacter('$') + " ");
            }
        }
    }
}
