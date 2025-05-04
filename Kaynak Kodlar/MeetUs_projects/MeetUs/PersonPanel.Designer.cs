namespace MeetUs
{
    partial class PersonPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_welcome = new Label();
            label2 = new Label();
            txtBox_searchMeet = new TextBox();
            btn_search = new Button();
            label3 = new Label();
            lbox_passwords = new ListBox();
            groupBox1 = new GroupBox();
            button2 = new Button();
            label9 = new Label();
            label8 = new Label();
            lbl_ınfoPassword = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            mont_calMeet = new MonthCalendar();
            groupBox2 = new GroupBox();
            month_cal = new MonthCalendar();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_welcome
            // 
            lbl_welcome.AutoSize = true;
            lbl_welcome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_welcome.Location = new Point(13, 9);
            lbl_welcome.Margin = new Padding(4, 0, 4, 0);
            lbl_welcome.Name = "lbl_welcome";
            lbl_welcome.Size = new Size(24, 28);
            lbl_welcome.TabIndex = 0;
            lbl_welcome.Text = "...";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label2.Location = new Point(15, 43);
            label2.Name = "label2";
            label2.Size = new Size(113, 28);
            label2.TabIndex = 1;
            label2.Text = "Şifre Girin:";
            // 
            // txtBox_searchMeet
            // 
            txtBox_searchMeet.BorderStyle = BorderStyle.FixedSingle;
            txtBox_searchMeet.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtBox_searchMeet.Location = new Point(134, 46);
            txtBox_searchMeet.Name = "txtBox_searchMeet";
            txtBox_searchMeet.Size = new Size(141, 30);
            txtBox_searchMeet.TabIndex = 2;
            // 
            // btn_search
            // 
            btn_search.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_search.Location = new Point(282, 43);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(129, 30);
            btn_search.TabIndex = 3;
            btn_search.Text = "Toplantı Ara";
            btn_search.UseVisualStyleBackColor = true;
            btn_search.Click += btn_search_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 81);
            label3.Name = "label3";
            label3.Size = new Size(227, 28);
            label3.TabIndex = 5;
            label3.Text = "Sizinle Paylaşılan Şifreler:";
            // 
            // lbox_passwords
            // 
            lbox_passwords.FormattingEnabled = true;
            lbox_passwords.ItemHeight = 28;
            lbox_passwords.Location = new Point(13, 122);
            lbox_passwords.Name = "lbox_passwords";
            lbox_passwords.Size = new Size(180, 116);
            lbox_passwords.TabIndex = 6;
            lbox_passwords.SelectedIndexChanged += lbox_passwords_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(lbl_ınfoPassword);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(mont_calMeet);
            groupBox1.Location = new Point(13, 274);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(792, 229);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Toplantı Bilgileri";
            groupBox1.Visible = false;
            // 
            // button2
            // 
            button2.Location = new Point(18, 143);
            button2.Name = "button2";
            button2.Size = new Size(222, 39);
            button2.TabIndex = 3;
            button2.Text = "Toplantıya Katıl ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(186, 102);
            label9.Name = "label9";
            label9.Size = new Size(102, 28);
            label9.TabIndex = 2;
            label9.Text = "(meetInfo)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(186, 70);
            label8.Name = "label8";
            label8.Size = new Size(109, 28);
            label8.TabIndex = 2;
            label8.Text = "(meetDate)";
            // 
            // lbl_ınfoPassword
            // 
            lbl_ınfoPassword.AutoSize = true;
            lbl_ınfoPassword.Location = new Point(186, 40);
            lbl_ınfoPassword.Name = "lbl_ınfoPassword";
            lbl_ınfoPassword.Size = new Size(107, 28);
            lbl_ınfoPassword.TabIndex = 2;
            lbl_ınfoPassword.Text = "(password)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point);
            label6.Location = new Point(18, 102);
            label6.Name = "label6";
            label6.Size = new Size(147, 28);
            label6.TabIndex = 1;
            label6.Text = "Toplantı Başlığı:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point);
            label5.Location = new Point(18, 70);
            label5.Name = "label5";
            label5.Size = new Size(132, 28);
            label5.TabIndex = 1;
            label5.Text = "Toplantı Tarih:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point);
            label4.Location = new Point(18, 40);
            label4.Name = "label4";
            label4.Size = new Size(143, 28);
            label4.TabIndex = 1;
            label4.Text = "Toplantı Şifresi:";
            // 
            // mont_calMeet
            // 
            mont_calMeet.Location = new Point(505, 22);
            mont_calMeet.Name = "mont_calMeet";
            mont_calMeet.TabIndex = 0;
            mont_calMeet.DateChanged += mont_calMeet_DateChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(month_cal);
            groupBox2.Location = new Point(417, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(388, 256);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Müsait Olunan Tarih ve Saatler";
            // 
            // month_cal
            // 
            month_cal.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            month_cal.Location = new Point(113, 31);
            month_cal.Name = "month_cal";
            month_cal.TabIndex = 0;
            month_cal.DateChanged += month_cal_DateChanged;
            // 
            // PersonPanel
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 531);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lbox_passwords);
            Controls.Add(label3);
            Controls.Add(btn_search);
            Controls.Add(txtBox_searchMeet);
            Controls.Add(label2);
            Controls.Add(lbl_welcome);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "PersonPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PersonPanel";
            Load += PersonPanel_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lbl_welcome;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label4;
        private Label label6;
        private Label label5;
        public TextBox txtBox_searchMeet;
        public Button btn_search;
        public Button button2;
        public ListBox lbox_passwords;
        public MonthCalendar mont_calMeet;
        public MonthCalendar month_cal;
        public Label label9;
        public Label label8;
        public Label lbl_ınfoPassword;
    }
}