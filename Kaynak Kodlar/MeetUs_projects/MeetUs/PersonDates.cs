using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeetUs
{
    public partial class PersonDates : Form
    {
        public DateTime dt_start_buse = new DateTime(2023, 12, 6);
        public DateTime dt_end_buse = new DateTime(2023, 12, 12);

        public DateTime dt_start_mehmet = new DateTime(2023, 12, 5);
        public DateTime dt_end_mehmet = new DateTime(2023, 12, 10);

        public DateTime dt_start_sude = new DateTime(2023, 12, 8);
        public DateTime dt_end_sude = new DateTime(2023, 12, 11);
        public PersonDates()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            monthCalendar1.SetSelectionRange(dt_start_buse, dt_end_buse);
        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            monthCalendar2.SetSelectionRange(dt_start_sude, dt_end_sude);
        }

        private void PersonDates_Load(object sender, EventArgs e)
        {

            monthCalendar1.SetSelectionRange(dt_start_buse, dt_end_buse);
            monthCalendar3.SetSelectionRange(dt_start_mehmet, dt_end_mehmet);
            monthCalendar2.SetSelectionRange(dt_start_sude, dt_end_sude);

            lbl_startBuse.Text = $"{dt_start_buse.Day} {CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(dt_start_buse.Month)} {dt_start_buse.Year}";
            lbl_endBuse.Text = $"{dt_end_buse.Day} {CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(dt_end_buse.Month)} {dt_end_buse.Year}";

            lbl_startMehmet.Text = $"{dt_start_mehmet.Day} {CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(dt_start_mehmet.Month)} {dt_start_mehmet.Year}";
            lbl_endMehmet.Text = $"{dt_end_mehmet.Day} {CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(dt_end_mehmet.Month)} {dt_end_mehmet.Year}";

            lbl_startSude.Text = $"{dt_start_sude.Day} {CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(dt_start_sude.Month)} {dt_start_sude.Year}";
            lbl_endSude.Text = $"{dt_end_sude.Day} {CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(dt_end_sude.Month)} {dt_end_sude.Year}";
        }

        private void monthCalendar3_DateChanged(object sender, DateRangeEventArgs e)
        {
            monthCalendar3.SetSelectionRange(dt_start_mehmet, dt_end_mehmet);
        }
    }
}
