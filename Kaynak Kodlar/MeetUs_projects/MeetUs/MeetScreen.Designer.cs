namespace MeetUs
{
    partial class MeetScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MeetScreen));
            label1 = new Label();
            label22 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(45, 69);
            label1.Name = "label1";
            label1.Size = new Size(473, 57);
            label1.TabIndex = 0;
            label1.Text = "TOPLANTI AÇILIYOR";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(174, 147);
            label22.Name = "label22";
            label22.Size = new Size(179, 27);
            label22.TabIndex = 1;
            label22.Text = "(COMİNG SOON)";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(193, 214);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(144, 131);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // MeetScreen
            // 
            AutoScaleDimensions = new SizeF(12F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 427);
            Controls.Add(pictureBox1);
            Controls.Add(label22);
            Controls.Add(label1);
            Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MinimizeBox = false;
            Name = "MeetScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MeetScreen";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label22;
        private PictureBox pictureBox1;
    }
}