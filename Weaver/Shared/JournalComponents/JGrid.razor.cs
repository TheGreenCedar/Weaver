using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Weaver.Data.Models;

namespace Weaver.Shared.JournalComponents
{
    public partial class JGrid
    {
        const int MAX_WIDTH = 12;
        public int Rows { get => Component.Children.Max(c => c.Row); }
        public int Cols { get => Component.Children.Max(c => c.Col); }

        public static (int row, int col) GetNextPoint(int row, int col, int maxCols)
        {
            int nextRow = row;
            int nextCol = col + 1;
            if (nextCol > maxCols)
            {
                nextCol = 1;
                ++nextRow;
            }
            return (nextRow, nextCol);
        }

        public static IEnumerable<RenderFragment> FillWithEmpty(int rowStart, int colStart, int rowEnd, int colEnd, int maxCols, int maxWidth)
        {
            int colWidth = maxWidth / maxCols;
            int rowNum = rowEnd - rowStart - 1;
            int cellNum = rowNum * maxCols + (maxCols - colStart) + colEnd + -1;
            (int curRow, int curCol) = GetNextPoint(rowStart, colStart, maxCols);

            for (int i = 0; i < cellNum; ++i)
            {
                yield return EmptyCell(colWidth, curRow, curCol);
                (curRow, curCol) = GetNextPoint(curRow, curCol, maxCols);
            }
        }

        private static string IdFromRowCol(int row, int col) => $"cell{row}_{col}";

        private Task onchange<U, T>(U val, ref T item)
            where T : ValueComponent<U>
        {
            item.MappedValue = val;
            return ComponentChanged.InvokeAsync(Component);
        }
    }
}
