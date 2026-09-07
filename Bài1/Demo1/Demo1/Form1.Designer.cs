namespace Demo1
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
            label2 = new Label();
            txtNhapPass = new TextBox();
            txtHienThi = new TextBox();
            btnhienthi = new Button();
            btntiep = new Button();
            btndong = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(162, 103);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 0;
            label1.Text = "Nhập Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(213, 195);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 1;
            label2.Text = "Hiển Thị";
            // 
            // txtNhapPass
            // 
            txtNhapPass.Location = new Point(303, 105);
            txtNhapPass.Name = "txtNhapPass";
            txtNhapPass.PasswordChar = '*';
            txtNhapPass.Size = new Size(180, 27);
            txtNhapPass.TabIndex = 2;
            // 
            // txtHienThi
            // 
            txtHienThi.Location = new Point(303, 195);
            txtHienThi.Name = "txtHienThi";
            txtHienThi.Size = new Size(180, 27);
            txtHienThi.TabIndex = 3;
            // 
            // btnhienthi
            // 
            btnhienthi.Location = new Point(139, 323);
            btnhienthi.Name = "btnhienthi";
            btnhienthi.Size = new Size(94, 29);
            btnhienthi.TabIndex = 4;
            btnhienthi.Text = "Hiển thị";
            btnhienthi.UseVisualStyleBackColor = true;
            btnhienthi.Click += btnhienthi_Click;
            // 
            // btntiep
            // 
            btntiep.Location = new Point(334, 323);
            btntiep.Name = "btntiep";
            btntiep.Size = new Size(94, 29);
            btntiep.TabIndex = 5;
            btntiep.Text = "Tiếp";
            btntiep.UseVisualStyleBackColor = true;
            btntiep.Click += btntiep_Click;
            // 
            // btndong
            // 
            btndong.Location = new Point(546, 323);
            btndong.Name = "btndong";
            btndong.Size = new Size(94, 29);
            btndong.TabIndex = 6;
            btndong.Text = "Đóng";
            btndong.UseVisualStyleBackColor = true;
            btndong.Click += btndong_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(786, 450);
            Controls.Add(btndong);
            Controls.Add(btntiep);
            Controls.Add(btnhienthi);
            Controls.Add(txtHienThi);
            Controls.Add(txtNhapPass);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Sử dụng Label và Textbox";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNhapPass;
        private TextBox txtHienThi;
        private Button btnhienthi;
        private Button btntiep;
        private Button btndong;
    }
}
