using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinChartPrintReflection
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void 프린트미리보기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //System.IO   TextReader / TextWriter  상위추상클래스
            //Stream => Byte[]  
            //한국어, 일본어 한문자가 1바이트이상, Encoding 문자가 짤릴수도 있다
            //StreamReader / StreamWriter
            //Stream => 바이너리 기반
            //BinaryReader / BinaryWriter
            //Stream => 텍스트 기반
            //StringReader / StringWriter

            try
            {
                StringReader text = new StringReader(textBox1.Text);
                TextPrintDocument document1 = new TextPrintDocument(text, textBox1.Font);

                PrintPreviewDialog dlg = new PrintPreviewDialog();
                dlg.Document = document1;
                dlg.ShowDialog();
            }
            catch(Exception err)
            {
                MessageBox.Show("인쇄할 파일을 미리보기하는 동안 오류발생:" + err.Message);
            }
        }
    }
}
