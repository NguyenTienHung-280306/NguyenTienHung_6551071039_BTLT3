namespace Bai3_WF
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
            lblHoTen = new Label();
            label2 = new Label();
            label3 = new Label();
            txtHo = new TextBox();
            txtTen = new TextBox();
            btnHo = new Button();
            btnTen = new Button();
            btnHoTen = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.BackColor = SystemColors.MenuHighlight;
            lblHoTen.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHoTen.Location = new Point(335, 27);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(0, 46);
            lblHoTen.TabIndex = 0;
            lblHoTen.DoubleClick += lblHoTen_DoubleClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(182, 104);
            label2.Name = "label2";
            label2.Size = new Size(76, 31);
            label2.TabIndex = 1;
            label2.Text = "Họ lót";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(209, 184);
            label3.Name = "label3";
            label3.Size = new Size(49, 31);
            label3.TabIndex = 2;
            label3.Text = "Tên";
            // 
            // txtHo
            // 
            txtHo.Location = new Point(269, 108);
            txtHo.Name = "txtHo";
            txtHo.Size = new Size(276, 27);
            txtHo.TabIndex = 3;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(269, 188);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(276, 27);
            txtTen.TabIndex = 4;
            // 
            // btnHo
            // 
            btnHo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHo.Location = new Point(120, 275);
            btnHo.Name = "btnHo";
            btnHo.Size = new Size(151, 43);
            btnHo.TabIndex = 5;
            btnHo.Text = "Họ Lót";
            btnHo.UseVisualStyleBackColor = true;
            btnHo.Click += btnHo_Click;
            // 
            // btnTen
            // 
            btnTen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTen.Location = new Point(335, 275);
            btnTen.Name = "btnTen";
            btnTen.Size = new Size(138, 43);
            btnTen.TabIndex = 6;
            btnTen.Text = "Tên";
            btnTen.UseVisualStyleBackColor = true;
            btnTen.Click += btnTen_Click;
            // 
            // btnHoTen
            // 
            btnHoTen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHoTen.Location = new Point(570, 275);
            btnHoTen.Name = "btnHoTen";
            btnHoTen.Size = new Size(132, 43);
            btnHoTen.TabIndex = 7;
            btnHoTen.Text = "Họ và tên";
            btnHoTen.UseVisualStyleBackColor = true;
            btnHoTen.Click += btnHoTen_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(304, 369);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(192, 49);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát chương trình";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnThoat);
            Controls.Add(btnHoTen);
            Controls.Add(btnTen);
            Controls.Add(btnHo);
            Controls.Add(txtTen);
            Controls.Add(txtHo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblHoTen);
            Name = "Form1";
            Text = "Bài tập họ và tên";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHoTen;
        private Label label2;
        private Label label3;
        private TextBox txtHo;
        private TextBox txtTen;
        private Button btnHo;
        private Button btnTen;
        private Button btnHoTen;
        private Button btnThoat;
    }
}
