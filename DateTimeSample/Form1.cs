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

namespace DateTimeSample
{
    public partial class Form1 : Form
    {
        //現在日時
        private DateTime _now;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btNow_Click(object sender, EventArgs e)
        {
            //現在日時
            _now = DateTime.Now;
            tbNowDisp.Text = _now.ToString("D") + _now.ToString(" ddd曜日");
        }

        private void btBefore_Click(object sender, EventArgs e)
        {
            _now = DateTime.Now;
            var outputday = (_now.AddDays(-(double)nudDayBeforeAfter.Value)).AddMonths(-(int)nudMonthsBeforeAfter.Value);
            //日付表示
            tbBeforeAfterDisp.Text = outputday.ToString("D") + outputday.ToString(" ddd曜日");
            //閏年判定(三項演算子)
            tbLeapYear.Text = DateTime.IsLeapYear(outputday.Year) ? "閏年です" : "平年です";
        }

        private void btAfter_Click(object sender, EventArgs e)
        {
            _now = DateTime.Now;
            var outputday = (_now.AddDays((double)nudDayBeforeAfter.Value)).AddMonths((int)nudMonthsBeforeAfter.Value);
            //日付表示
            tbBeforeAfterDisp.Text = outputday.ToString("D") + outputday.ToString(" ddd曜日");
            //閏年判定(三項演算子)
            tbLeapYear.Text = DateTime.IsLeapYear(outputday.Year) ? "閏年です" : "平年です";
        }

        private void btCountDay_Click(object sender, EventArgs e)
        {
            _now = DateTime.Now;
            DateTime birthday = new DateTime(mcBirthday.SelectionStart.Year,
                                             mcBirthday.SelectionStart.Month,
                                             mcBirthday.SelectionStart.Day);
            ////日数計算の結果を取得
            TimeSpan countdays = _now - birthday;
            //日数計算の結果を表示
            tbCountDay.Text = countdays.Days.ToString();
        }

        private void btFileWrite_Click(object sender, EventArgs e)
        {
            var lines = new string[]
            {
                "祇園精舎の鐘の声、諸行無常の響きあり。",
                "娑羅双樹の花の色、盛者必衰の理をあらはす。",
                "奢れる人も久しからず、ただ春の夜の夢のごとし。",
                "猛き者もつひにはほろびぬ、ひとへに風の前の塵に同じ。"
            };
            if (sfdFileSave.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllLines(sfdFileSave.FileName, lines);
            }
        }

        private void btFileRead_Click(object sender, EventArgs e)
        {
            if (ofdFileOpen.ShowDialog() == DialogResult.OK)
            {
                var lines = File.ReadAllLines(ofdFileOpen.FileName);
                foreach (var line in lines)
                {
                    //1行ずつリストボックスへ格納
                    lbTextList.Items.Add(line);
                }
            }
        }
    }
}