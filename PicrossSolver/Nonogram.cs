using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicrossSolver
{
    class Nonogram
    {
        private int p_numRows;
        private int p_numColumns;

        public int numRows { get { return p_numRows; } set { p_numRows = value; } }
        public int numColumns { get { return p_numColumns; } set { p_numColumns = value; } }

        public Cell[,] cellTable;

        public Nonogram(int rows, int columns)
        {
            p_numRows = rows;
            p_numColumns = columns;
            cellTable = new Cell[rows, columns];
            for (int i = 0; i < rows; ++i)
                for (int j = 0; j < columns; ++j)
                    cellTable[i, j] = new Cell(Cell.State.Empty);
        }
    }
}
