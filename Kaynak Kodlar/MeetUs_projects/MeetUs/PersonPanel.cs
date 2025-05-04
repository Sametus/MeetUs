using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeetUs
{

    public partial class PersonPanel : Form
    {
        //string datafile = @"C:\Users\DELL\Desktop\MeetUs_projects\MeetUs\data.json";


        string datafile = Path.Combine(Directory.GetCurrentDirectory(), "data.json");


        Person person = new Person();
        List<string> passwordReverse = new List<string>();
        List<string> passwords;
        List<List<int>> meetDates;
        List<string> meetInfo;

        public PersonPanel()
        {
            InitializeComponent();
        }

        private void PersonPanel_Load(object sender, EventArgs e)
        {

            lbl_welcome.Text = $"Hoşgeldin! {PersonLogin.Name} {PersonLogin.Surname}";
            if (PersonLogin.Name == "buse".ToLower())
            {
                DateTime dt_start_buse = new DateTime(2023, 12, 6);
                DateTime dt_end_buse = new DateTime(2023, 12, 12);
                month_cal.SelectionRange = new SelectionRange(dt_start_buse, dt_end_buse);
            }
            if (PersonLogin.Name == "mehmet".ToLower())
            {
                DateTime dt_start_mehmet = new DateTime(2023, 12, 5);
                DateTime dt_end_mehmet = new DateTime(2023, 12, 10);
                month_cal.SelectionRange = new SelectionRange(dt_start_mehmet, dt_end_mehmet);
            }
            if (PersonLogin.Name == "sude".ToLower())
            {
                DateTime dt_start_sude = new DateTime(2023, 12, 8);
                DateTime dt_end_sude = new DateTime(2023, 12, 11);
                month_cal.SelectionRange = new SelectionRange(dt_start_sude, dt_end_sude);
            }

            string jsonString = File.ReadAllText(datafile);
            Person person = JsonSerializer.Deserialize<Person>(jsonString);
            passwords = person.password;
            meetDates = person.meetDate;
            meetInfo = person.meetInfo;

            List<string> passwordReverse = new List<string>();
            passwordReverse = passwords;
            passwordReverse.Reverse();
            foreach (var item in passwordReverse)
            {
                lbox_passwords.Items.Add(item);
            }



        }

        private void month_cal_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (PersonLogin.Name == "buse".ToLower())
            {
                DateTime dt_start_ayse = new DateTime(2023, 12, 6);
                DateTime dt_end_ayse = new DateTime(2023, 12, 12);
                month_cal.SelectionRange = new SelectionRange(dt_start_ayse, dt_end_ayse);
            }
            if (PersonLogin.Name == "mehmet".ToLower())
            {
                DateTime dt_start_mehmet = new DateTime(2023, 12, 5);
                DateTime dt_end_mehmet = new DateTime(2023, 12, 10);
                month_cal.SelectionRange = new SelectionRange(dt_start_mehmet, dt_end_mehmet);
            }
            if (PersonLogin.Name == "sude".ToLower())
            {
                DateTime dt_start_sude = new DateTime(2023, 12, 8);
                DateTime dt_end_sude = new DateTime(2023, 12, 11);
                month_cal.SelectionRange = new SelectionRange(dt_start_sude, dt_end_sude);
            }
        }

        private void lbox_passwords_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBox_searchMeet.Text = lbox_passwords.SelectedItem.ToString();
        }
        int index;
        private void btn_search_Click(object sender, EventArgs e)
        {
            if (txtBox_searchMeet.Text == string.Empty)
            {
                MessageBox.Show("Bir Şifre Giriniz!", "HATA", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                if (passwords.Contains(txtBox_searchMeet.Text))
                {
                    groupBox1.Visible = true;
                    index = passwords.IndexOf(txtBox_searchMeet.Text);
                    lbl_ınfoPassword.Text = txtBox_searchMeet.Text;
                    int year = meetDates[index][0];
                    int month = meetDates[index][1];
                    int day = meetDates[index][2];
                    DateTime start = new DateTime(year, month, day);
                    mont_calMeet.SetSelectionRange(start, start);

                    label8.Text = $"{day} - {CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month)} - {year}";
                    label9.Text = meetInfo[index];
                }
                else
                {
                    MessageBox.Show("Hatalı veya eksik Şifre", "HATA", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MeetScreen ms = new MeetScreen();
            ms.Show();
        }

        private void mont_calMeet_DateChanged(object sender, DateRangeEventArgs e)
        {
            index = passwords.IndexOf(txtBox_searchMeet.Text);
            lbl_ınfoPassword.Text = txtBox_searchMeet.Text;
            int year = meetDates[index][0];
            int month = meetDates[index][1];
            int day = meetDates[index][2];
            DateTime start = new DateTime(year, month, day);
            mont_calMeet.SetSelectionRange(start, start);
        }
    }
}
