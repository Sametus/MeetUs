using System.Text.Json;


namespace MeetUs
{

    public partial class Form1 : Form
    {


        string datafile = Path.Combine(Directory.GetCurrentDirectory(), "data.json");
        List<int> meets = new List<int>();
        public Person person = new Person();

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PersonDates personDates = new PersonDates();
            personDates.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string jsonstring = File.ReadAllText(datafile);                   // *********
            Person? person = JsonSerializer.Deserialize<Person>(jsonstring);  // *********

            string meetInfoString = txtbox_meetinfo.Text;
            string sifre = DoingPassword();
            MessageBox.Show($"Toplantý Oluþturuldu!\nToplantý Kodunuz: \"{sifre}\"\n(Sistem tarafýndan diðer kullanýcýlar ile paylaþýldý.)","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            person.password.Add(sifre);
            person.meetDate.Add(meets);
            person.meetInfo.Add(meetInfoString);
            var opitons = new JsonSerializerOptions { WriteIndented = true };  // *********
            string jsonWriting = JsonSerializer.Serialize(person, opitons);    // *********

            File.WriteAllText(datafile, jsonWriting);                          // *********

            txtbox_meetinfo.Text = string.Empty;
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            int day = monthCalendar1.SelectionStart.Day;
            int month = monthCalendar1.SelectionStart.Month;
            int year = monthCalendar1.SelectionStart.Year;
            meets = [year, month, day];
        }

        public string DoingPassword()
        {
            string s1;
            string s2;
            string s3;
            string s4;
            string s5;

            Random r1 = new Random();
            var charKeys = "abcdefghijklmnopqrstuvwxyz0123456789".ToCharArray();
            s1 = charKeys[r1.Next(35)].ToString();
            s2 = charKeys[r1.Next(35)].ToString();
            s3 = charKeys[r1.Next(35)].ToString();
            s4 = charKeys[r1.Next(35)].ToString();
            s5 = charKeys[r1.Next(35)].ToString();
            string result = s1 + s2 + s3 + s4 + s5;
            return result;
        }


    }
}
