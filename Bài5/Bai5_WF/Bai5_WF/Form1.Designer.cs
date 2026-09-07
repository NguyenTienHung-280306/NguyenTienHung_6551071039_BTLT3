namespace Bai5_WF
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
            label1 = new Label();
            txtHoTen = new TextBox();
            radGreen = new RadioButton();
            radRed = new RadioButton();
            radBlue = new RadioButton();
            radBlack = new RadioButton();
            chkBold = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label2 = new Label();
            button1 = new Button();
            lblLapTrinhBoi = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(182, 17);
            label1.Name = "label1";
            label1.Size = new Size(119, 31);
            label1.TabIndex = 0;
            label1.Text = "Nhập tên:";
            label1.Click += label1_Click;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(301, 23);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(333, 27);
            txtHoTen.TabIndex = 1;
            txtHoTen.TextChanged += txtHoTen_TextChanged;
            // 
            // radGreen
            // 
            radGreen.AutoSize = true;
            radGreen.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radGreen.ForeColor = Color.Green;
            radGreen.Location = new Point(22, 83);
            radGreen.Name = "radGreen";
            radGreen.Size = new Size(72, 24);
            radGreen.TabIndex = 2;
            radGreen.TabStop = true;
            radGreen.Text = "Green";
            radGreen.UseVisualStyleBackColor = true;
            // 
            // radRed
            // 
            radRed.AutoSize = true;
            radRed.Checked = true;
            radRed.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radRed.ForeColor = Color.Red;
            radRed.Location = new Point(22, 26);
            radRed.Name = "radRed";
            radRed.Size = new Size(57, 24);
            radRed.TabIndex = 3;
            radRed.TabStop = true;
            radRed.Text = "Red";
            radRed.UseVisualStyleBackColor = true;
            radRed.CheckedChanged += radRed_CheckedChanged_1;
            // 
            // radBlue
            // 
            radBlue.AutoSize = true;
            radBlue.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radBlue.ForeColor = Color.Blue;
            radBlue.Location = new Point(22, 143);
            radBlue.Name = "radBlue";
            radBlue.Size = new Size(61, 24);
            radBlue.TabIndex = 4;
            radBlue.TabStop = true;
            radBlue.Text = "Blue";
            radBlue.UseVisualStyleBackColor = true;
            // 
            // radBlack
            // 
            radBlack.AutoSize = true;
            radBlack.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radBlack.Location = new Point(22, 201);
            radBlack.Name = "radBlack";
            radBlack.Size = new Size(67, 24);
            radBlack.TabIndex = 5;
            radBlack.TabStop = true;
            radBlack.Text = "Black";
            radBlack.UseVisualStyleBackColor = true;
            // 
            // chkBold
            // 
            chkBold.AutoSize = true;
            chkBold.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            chkBold.ForeColor = Color.Blue;
            chkBold.Location = new Point(24, 43);
            chkBold.Name = "chkBold";
            chkBold.Size = new Size(63, 24);
            chkBold.TabIndex = 6;
            chkBold.Text = "Bold";
            chkBold.UseVisualStyleBackColor = true;
            chkBold.CheckedChanged += chkBold_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            checkBox2.ForeColor = Color.Blue;
            checkBox2.Location = new Point(24, 115);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(133, 24);
            checkBox2.TabIndex = 7;
            checkBox2.Text = "Nghiêng Italic";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline);
            checkBox3.ForeColor = Color.Blue;
            checkBox3.Location = new Point(24, 185);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(105, 24);
            checkBox3.TabIndex = 8;
            checkBox3.Text = "Gạch Chân";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightSkyBlue;
            groupBox1.Controls.Add(radRed);
            groupBox1.Controls.Add(radGreen);
            groupBox1.Controls.Add(radBlue);
            groupBox1.Controls.Add(radBlack);
            groupBox1.Location = new Point(139, 96);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(232, 247);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Color";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Salmon;
            groupBox2.Controls.Add(chkBold);
            groupBox2.Controls.Add(checkBox2);
            groupBox2.Controls.Add(checkBox3);
            groupBox2.Location = new Point(469, 102);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(244, 241);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Font";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(119, 386);
            label2.Name = "label2";
            label2.Size = new Size(167, 32);
            label2.TabIndex = 11;
            label2.Text = "Lập trình bởi:";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(592, 382);
            button1.Name = "button1";
            button1.Size = new Size(134, 46);
            button1.TabIndex = 13;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = true;
            // 
            // lblLapTrinhBoi
            // 
            lblLapTrinhBoi.AutoSize = true;
            lblLapTrinhBoi.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblLapTrinhBoi.Location = new Point(319, 386);
            lblLapTrinhBoi.Name = "lblLapTrinhBoi";
            lblLapTrinhBoi.Size = new Size(0, 32);
            lblLapTrinhBoi.TabIndex = 14;
            lblLapTrinhBoi.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblLapTrinhBoi);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(txtHoTen);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Định dạng(Formater)";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtHoTen;
        private RadioButton radGreen;
        private RadioButton radRed;
        private RadioButton radBlue;
        private RadioButton radBlack;
        private CheckBox chkBold;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label2;
        private Button button1;
        private Label lblLapTrinhBoi;
    }
}
