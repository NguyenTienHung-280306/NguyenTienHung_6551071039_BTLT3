namespace Bai2_WF
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
            btnClick = new Button();
            SuspendLayout();
            // 
            // btnClick
            // 
            btnClick.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnClick.ForeColor = Color.Red;
            btnClick.Location = new Point(273, 153);
            btnClick.Name = "btnClick";
            btnClick.Size = new Size(217, 110);
            btnClick.TabIndex = 0;
            btnClick.Text = "CLICK ME";
            btnClick.UseVisualStyleBackColor = true;
            btnClick.Click += btnClick_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClick);
            Name = "Form1";
            Text = "Simple Even Example";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnClick;
    }
}
