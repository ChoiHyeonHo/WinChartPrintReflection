using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinChartPrintReflection
{
    public partial class Form2 : Form
    {
        int pageNum = 1;

        public Form2()
        {
            InitializeComponent();
        }

        private void 프린터선택ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void 프린트용지설정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        private void 인쇄ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void 프린트미리보기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //MessageBox.Show("Begin Print");
        }

        private void printDocument1_EndPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //MessageBox.Show("end Print");
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString($"Hello Page #{pageNum}", new Font("Arial", 70), Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top); 

            if (pageNum < 3)
            {
                e.HasMorePages = true;
                pageNum++;
            }
            else
            {
                e.HasMorePages = false;
                pageNum = 1;
            }
        }
    }
}
