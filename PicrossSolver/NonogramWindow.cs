using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicrossSolver
{
    public partial class NonogramWindow : Form
    {
        private PictureBox[,] cells;
        private TextBox[,] columnClues;
        private TextBox[,] rowClues;
        private int cellSize = 20;

        public NonogramWindow()
        {
            InitializeComponent();
        }

        private void NonogramWindow_Load(object sender, EventArgs e)
        {
            int numColumns = Program.mainPuzzle.numColumns;
            int numRows = Program.mainPuzzle.numRows;
            int numColumnClues = numColumns / 2 + 1;
            int numRowClues = numRows / 2 + 1;

            mainPuzzlePanel.Width = numColumns * cellSize + 5;
            mainPuzzlePanel.Height = numRows * cellSize + 5;
            mainPuzzlePanel.Location = new Point(numRowClues * cellSize + 5, numColumnClues * cellSize + 5);

            topRightPanel.Width = numColumns * cellSize + 5;
            topRightPanel.Height = numColumnClues * cellSize;
            topRightPanel.Location = new Point(numRowClues * cellSize, 5);

            bottomLeftPanel.Width = numRowClues * cellSize;
            bottomLeftPanel.Height = numRows * cellSize + 5;
            bottomLeftPanel.Location = new Point(5, numColumnClues * cellSize);

            // Add text boxes for column clues
            columnClues = new TextBox[numColumns, numColumnClues];
            for(int i = 0; i < numRows; ++i)
                for(int j = 0; j < numColumnClues; ++j)
                {
                    columnClues[i, j] = new TextBox();
                    topRightPanel.Controls.Add(columnClues[i, j]);
                    columnClues[i, j].Width = cellSize - 1;
                    columnClues[i, j].BorderStyle = BorderStyle.Fixed3D;
                    columnClues[i, j].Location = new Point(i * cellSize, j * cellSize);
                    columnClues[i, j].Text = "0";
                    columnClues[i, j].TextAlign = HorizontalAlignment.Center;
                }

            // Add text boxes for row clues
            rowClues = new TextBox[numRowClues, numColumns];
            for(int i = 0; i < numRowClues; ++i)
                for(int j = 0; j < numColumns; ++j)
                {
                    rowClues[i, j] = new TextBox();
                    bottomLeftPanel.Controls.Add(rowClues[i, j]);
                    rowClues[i, j].Width = cellSize - 1;
                    rowClues[i, j].BorderStyle = BorderStyle.Fixed3D;
                    rowClues[i, j].Location = new Point(i * cellSize, j * cellSize);
                    rowClues[i, j].Text = "0";
                    rowClues[i, j].TextAlign = HorizontalAlignment.Center;
                }

            // Add cells to main puzzle panel
            cells = new PictureBox[numColumns, numRows];
            for (int i = 0; i < numColumns; ++i)
                for(int j = 0; j < numColumns; ++j)
                {
                    cells[i, j] = new PictureBox();
                    mainPuzzlePanel.Controls.Add(cells[i, j]);
                    cells[i, j].Width = cellSize - 1;
                    cells[i, j].Height = cellSize - 1;
                    cells[i, j].BackColor = Color.AntiqueWhite;
                    cells[i, j].BorderStyle = BorderStyle.Fixed3D;
                    cells[i, j].Location = new Point(i * cellSize, j * cellSize);
                }
        }
    }
}
