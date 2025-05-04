using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeetUs
{
    public partial class PersonLogin : Form
    {
        public static string Name { get; set; }
        public static string Surname { get; set; }


        string datafile = Path.Combine(Directory.GetCurrentDirectory(), "data.json");
        public Person person = new Person();
        public PersonLogin()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string? name = txtbox_name.Text.ToLower();
            string? surname = txtBox_surname.Text.ToLower();

            Name = name;
            Surname = surname;
            if (name == "ahmet" && surname == "demir")
            {
                Form1 form1 = new Form1();
                form1.ShowDialog();
            }
            if ((name == "ahmet" && surname != "demir") || (name != "ahmet" && surname == "demir"))
            {
                string error = "Yanlış Kullanıcı Bilgisi. Tekrar Deneyiniz.";
                MessageBox.Show(error, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (name == "buse" && surname == "minik" || name == "mehmet" & surname == "alev" || name == "sude" & surname == "bayrak")
                {
                    PersonPanel personPanel = new PersonPanel();
                    personPanel.ShowDialog();
                }
                else
                {
                    if (name != "ahmet".ToLower() & surname != "demir".ToLower())
                    {
                        MessageBox.Show("Hatalı İsim Soyisim veya Kayıt Dışı Kullanıcı", "HATA", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
            }

            txtbox_name.Text = string.Empty;
            txtBox_surname.Text = string.Empty;
        
        }
    }
}
