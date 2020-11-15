using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Drawing.Printing;

namespace WinChartPrintReflection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //chart1.Series[0].Points.Add(100);
            //chart1.Series[0].Points.Add(200);
            //chart1.Series[0].Points.Add(300);
            //chart1.Series[0].Points.Add(400);
            //chart1.Series[0].Points.Add(500);
            chart1.Series["Series1"].Points.AddXY(10, 300);
            chart1.Series["Series1"].Points.AddXY(20, 200);
            chart1.Series[0].Points.AddXY(30, 100);
            chart1.Series[0].Points.AddXY(40, 400);
            chart1.Series[0].Points.AddXY(50, 500);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chart1.Series[0].ChartType = SeriesChartType.Line;

            chart1.Series.Add(new Series("홈런볼"));
            chart1.Series[1].ChartType = SeriesChartType.Line;
            chart1.Series["홈런볼"].BorderWidth = 5;

            chart1.Series[0].Points.Add(100);
            chart1.Series[0].Points.Add(200);
            chart1.Series[0].Points.Add(300);

            chart1.Series[1].Points.Add(200);
            chart1.Series[1].Points.Add(300);
            chart1.Series[1].Points.Add(100);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //연봉의 추이변화
            //   => x축-년도, y축-salary, series-사번, legend-이름
            //   => 하나의 결과셋으로 나올 수 있도록 쿼리문

            using (MySqlConnection conn = new MySqlConnection())
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["myDB"].ConnectionString;

                DataTable dt = new DataTable();

                string sql = @"select s.emp_no, 
       concat(first_name, ' ', last_name) emp_name, 
       year(from_date) year, 
       avg(salary) salary
  from salaries s join employees e on s.emp_no = e.emp_no
 where s.emp_no in ('10001', '10004')
 group by s.emp_no, concat(first_name, ' ', last_name), year(from_date)
 order by 1, 3";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                conn.Open();
                da.Fill(dt);
                conn.Close();

                if (chart1.Series.Count == 1)
                {
                    chart1.Series.Add(new Series("Series2"));
                }
                //chart1.Series[0].ChartType = SeriesChartType.Bar
                //chart1.Series[1].ChartType = SeriesChartType.Line;
                //chart1.Series[1].BorderWidth = 5;

                DataView dv1 = new DataView(dt);
                dv1.RowFilter = "emp_no=10001";

                DataView dv2 = new DataView(dt);
                dv2.RowFilter = "emp_no=10004";

                chart1.Series[0].Points.DataBind(dv1, "year", "salary", "Tooltip=salary");

                chart1.Series[1].Points.DataBind(dv2, "year", "salary", "Tooltip=salary");

                chart1.Series[0].LegendText = dv1[0]["emp_name"].ToString();
                chart1.Series[1].LegendText = dv2[0]["emp_name"].ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<int> emplist = new List<int>();
            emplist.Add(10001);
            emplist.Add(10004);
            emplist.Add(10005);
            emplist.Add(10006);

            ChartBinding(emplist);
        }

        private void ChartBinding(List<int> list)
        {
            if (list.Count < 1) return;

            string empList = string.Join(",", list); // "10001,10004,10005"

            using (MySqlConnection conn = new MySqlConnection())
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["myDB"].ConnectionString;

                DataTable dt = new DataTable();

                string sql = @"select s.emp_no, 
       concat(first_name, ' ', last_name) emp_name, 
       year(from_date) year, 
       avg(salary) salary
  from salaries s join employees e on s.emp_no = e.emp_no
 where s.emp_no in (" + empList + @")
 group by s.emp_no, concat(first_name, ' ', last_name), year(from_date)
 order by 1, 3";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                conn.Open();
                da.Fill(dt);
                conn.Close();

                //시리즈 추가 (0은 기본으로 있으니깐, 1번째부터 추가)
                for (int i=1; i<list.Count; i++)
                {
                    chart1.Series.Add(new Series("Series" + (i+1).ToString()));
                }

                //각 시리즈별로 데이터를 바인딩
                for (int i = 0; i < list.Count; i++)
                {
                    DataView dv = new DataView(dt);
                    dv.RowFilter = "emp_no=" + list[i];

                    chart1.Series[i].Points.DataBind(dv, "year", "salary", "Tooltip=salary");
                    chart1.Series[i].LegendText = dv[0]["emp_name"].ToString();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PrintDocument document = new PrintDocument();
            document.PrintPage += Document_PrintPage;

            PrintPreviewDialog dlg = new PrintPreviewDialog();
            dlg.Document = document;
            dlg.ShowDialog();
        }

        private void Document_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(chart1.Width, chart1.Height);
            chart1.DrawToBitmap(bm, new Rectangle(0, 0, chart1.Width, chart1.Height));

            e.Graphics.DrawImage(bm, 0, 0);
        }
    }
}
