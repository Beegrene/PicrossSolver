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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void createNonogramButton_Click(object sender, EventArgs e)
        {
            int numRows = Convert.ToInt32(rowUpDown.Value);
            int numColumns = Convert.ToInt32(columnUpDown.Value);
            {
                //good input
                Program.mainPuzzle = new Nonogram(numRows, numColumns);
                Form puzzleWindow = new NonogramWindow();
                puzzleWindow.Show();
                //Hide();
            }
            
        }
    }
}
