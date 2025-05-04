namespace MeetUs
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            monthCalendar1 = new MonthCalendar();
            pictureBox1 = new PictureBox();
            txtbox_meetinfo = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Location = new Point(651, 98);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(161, 38);
            button1.TabIndex = 0;
            button1.Text = "Toplantı Oluştur";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.Location = new Point(651, 41);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(161, 39);
            button2.TabIndex = 0;
            button2.Text = "Mevcut Tarihler";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(385, 41);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 1;
            monthCalendar1.DateSelected += monthCalendar1_DateSelected;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(15, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(358, 361);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // txtbox_meetinfo
            // 
            txtbox_meetinfo.BorderStyle = BorderStyle.None;
            txtbox_meetinfo.Location = new Point(574, 260);
            txtbox_meetinfo.Name = "txtbox_meetinfo";
            txtbox_meetinfo.Size = new Size(207, 28);
            txtbox_meetinfo.TabIndex = 3;
            txtbox_meetinfo.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(385, 260);
            label1.Name = "label1";
            label1.Size = new Size(183, 28);
            label1.TabIndex = 4;
            label1.Text = "Toplantı Açıklaması:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(385, 301);
            label2.Name = "label2";
            label2.Size = new Size(325, 19);
            label2.TabIndex = 4;
            label2.Text = "(Lütfen toplantı açıklamasını boş bırakmayınız.)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 433);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtbox_meetinfo);
            Controls.Add(pictureBox1);
            Controls.Add(monthCalendar1);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private MonthCalendar monthCalendar1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        public RichTextBox txtbox_meetinfo;
    }
}