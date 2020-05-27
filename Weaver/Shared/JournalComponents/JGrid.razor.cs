using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Weaver.Shared.JournalComponents
{
    public partial class JGrid
    {
        const int MAX_WIDTH = 12;
        public int Rows { get => Component.Children.Max(c => c.Row); }
        public int Cols { get => Component.Children.Max(c => c.Col); }

        private static (int row, int col) GetNextPoint(int row, int col, int maxCols)
        {
            var nextRow = row;
            var nextCol = col + 1;
            if (nextCol > maxCols) {
                nextCol = 1;
                nextRow += 1;
            }
            return (nextRow, nextCol);
        }
    }
}
