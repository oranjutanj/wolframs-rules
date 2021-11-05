using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WolframsRules.Common;

namespace WolframsRules.App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int rowIndex = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, RoutedEventArgs e)
        {
            Rules rules = new Rules(30, Rules.EdgeCase.WhiteBorder);
            Row currentRow = RowFactory.CreateFirst(100);
            DrawRow(currentRow, 0);
            for (int i = 0; i < 100; i++)
            {
                currentRow = RowFactory.GenerateNext(rules, currentRow);
                DrawRow(currentRow, i + 1);
            }
        }

        private void DrawRow(Row row, int rowIndex)
        {
            double gridWidth = canvas.ActualWidth;
            int column = 0;
            foreach (var cell in row.Cells)
            {
                Rectangle rect = new Rectangle() { Width = gridWidth / row.Cells.Count };
                rect.Height = rect.Width;
                rect.HorizontalAlignment = HorizontalAlignment.Left;
                if (cell.State == 1)
                    rect.Fill = new SolidColorBrush(Colors.Black);
                
                rect.Margin = new Thickness(column * rect.Width, rowIndex * rect.Height, 0, 0);
                canvas.Children.Add(rect);
                column += 1;
            }

        }
    }
}
