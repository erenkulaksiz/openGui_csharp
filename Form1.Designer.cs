namespace openGui_csharp
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_closeForm = new System.Windows.Forms.Button();
            this.btn_lowerForm = new System.Windows.Forms.Button();
            this.pBox_moveForm = new System.Windows.Forms.PictureBox();
            this.girilecekbox1 = new System.Windows.Forms.TextBox();
            this.girilecekbox2 = new System.Windows.Forms.TextBox();
            this.btntopla = new System.Windows.Forms.Button();
            this.infobtn = new System.Windows.Forms.Button();
            this.btncikar = new System.Windows.Forms.Button();
            this.btncarp = new System.Windows.Forms.Button();
            this.btnbol = new System.Windows.Forms.Button();
            this.gbox1 = new System.Windows.Forms.GroupBox();
            this.sonuclbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_moveForm)).BeginInit();
            this.gbox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_closeForm
            // 
            this.btn_closeForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_closeForm.FlatAppearance.BorderSize = 0;
            this.btn_closeForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_closeForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_closeForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_closeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_closeForm.ForeColor = System.Drawing.Color.White;
            this.btn_closeForm.Location = new System.Drawing.Point(509, 0);
            this.btn_closeForm.Name = "btn_closeForm";
            this.btn_closeForm.Size = new System.Drawing.Size(36, 28);
            this.btn_closeForm.TabIndex = 0;
            this.btn_closeForm.Text = "X";
            this.btn_closeForm.UseVisualStyleBackColor = true;
            this.btn_closeForm.Click += new System.EventHandler(this.Btn_closeForm_Click);
            // 
            // btn_lowerForm
            // 
            this.btn_lowerForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_lowerForm.FlatAppearance.BorderSize = 0;
            this.btn_lowerForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_lowerForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_lowerForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_lowerForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_lowerForm.ForeColor = System.Drawing.Color.White;
            this.btn_lowerForm.Location = new System.Drawing.Point(475, 0);
            this.btn_lowerForm.Name = "btn_lowerForm";
            this.btn_lowerForm.Size = new System.Drawing.Size(36, 28);
            this.btn_lowerForm.TabIndex = 1;
            this.btn_lowerForm.Text = "_";
            this.btn_lowerForm.UseVisualStyleBackColor = true;
            this.btn_lowerForm.Click += new System.EventHandler(this.Btn_lowerForm_Click);
            // 
            // pBox_moveForm
            // 
            this.pBox_moveForm.Location = new System.Drawing.Point(0, 0);
            this.pBox_moveForm.Name = "pBox_moveForm";
            this.pBox_moveForm.Size = new System.Drawing.Size(545, 43);
            this.pBox_moveForm.TabIndex = 2;
            this.pBox_moveForm.TabStop = false;
            this.pBox_moveForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PBox_moveForm_MouseDown);
            this.pBox_moveForm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PBox_moveForm_MouseMove);
            this.pBox_moveForm.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PBox_moveForm_MouseUp);
            // 
            // girilecekbox1
            // 
            this.girilecekbox1.BackColor = System.Drawing.Color.Silver;
            this.girilecekbox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.girilecekbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girilecekbox1.Location = new System.Drawing.Point(12, 42);
            this.girilecekbox1.MaxLength = 19;
            this.girilecekbox1.Name = "girilecekbox1";
            this.girilecekbox1.Size = new System.Drawing.Size(250, 30);
            this.girilecekbox1.TabIndex = 3;
            this.girilecekbox1.Text = "Bir numara gir";
            this.girilecekbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // girilecekbox2
            // 
            this.girilecekbox2.BackColor = System.Drawing.Color.Silver;
            this.girilecekbox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.girilecekbox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girilecekbox2.Location = new System.Drawing.Point(281, 42);
            this.girilecekbox2.MaxLength = 19;
            this.girilecekbox2.Name = "girilecekbox2";
            this.girilecekbox2.Size = new System.Drawing.Size(250, 30);
            this.girilecekbox2.TabIndex = 4;
            this.girilecekbox2.Text = "Bir numara gir";
            this.girilecekbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btntopla
            // 
            this.btntopla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btntopla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntopla.Location = new System.Drawing.Point(12, 78);
            this.btntopla.Name = "btntopla";
            this.btntopla.Size = new System.Drawing.Size(47, 45);
            this.btntopla.TabIndex = 5;
            this.btntopla.Text = "+";
            this.btntopla.UseVisualStyleBackColor = true;
            this.btntopla.Click += new System.EventHandler(this.Btntopla_Click);
            // 
            // infobtn
            // 
            this.infobtn.FlatAppearance.BorderSize = 0;
            this.infobtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(162)));
            this.infobtn.Location = new System.Drawing.Point(12, 129);
            this.infobtn.Name = "infobtn";
            this.infobtn.Size = new System.Drawing.Size(65, 44);
            this.infobtn.TabIndex = 9;
            this.infobtn.Text = "bilgi";
            this.infobtn.UseVisualStyleBackColor = true;
            this.infobtn.Click += new System.EventHandler(this.İnfobtn_Click);
            // 
            // btncikar
            // 
            this.btncikar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncikar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncikar.Location = new System.Drawing.Point(65, 78);
            this.btncikar.Name = "btncikar";
            this.btncikar.Size = new System.Drawing.Size(47, 45);
            this.btncikar.TabIndex = 10;
            this.btncikar.Text = "-";
            this.btncikar.UseVisualStyleBackColor = true;
            this.btncikar.Click += new System.EventHandler(this.Btncikar_Click);
            // 
            // btncarp
            // 
            this.btncarp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncarp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncarp.Location = new System.Drawing.Point(118, 78);
            this.btncarp.Name = "btncarp";
            this.btncarp.Size = new System.Drawing.Size(47, 45);
            this.btncarp.TabIndex = 11;
            this.btncarp.Text = "x";
            this.btncarp.UseVisualStyleBackColor = true;
            this.btncarp.Click += new System.EventHandler(this.Btncarp_Click);
            // 
            // btnbol
            // 
            this.btnbol.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnbol.Location = new System.Drawing.Point(171, 78);
            this.btnbol.Name = "btnbol";
            this.btnbol.Size = new System.Drawing.Size(47, 45);
            this.btnbol.TabIndex = 12;
            this.btnbol.Text = "/";
            this.btnbol.UseVisualStyleBackColor = true;
            this.btnbol.Click += new System.EventHandler(this.Btnbol_Click);
            // 
            // gbox1
            // 
            this.gbox1.Controls.Add(this.sonuclbl);
            this.gbox1.Location = new System.Drawing.Point(225, 72);
            this.gbox1.Name = "gbox1";
            this.gbox1.Size = new System.Drawing.Size(307, 51);
            this.gbox1.TabIndex = 13;
            this.gbox1.TabStop = false;
            // 
            // sonuclbl
            // 
            this.sonuclbl.AutoSize = true;
            this.sonuclbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sonuclbl.Location = new System.Drawing.Point(6, 16);
            this.sonuclbl.Name = "sonuclbl";
            this.sonuclbl.Size = new System.Drawing.Size(300, 25);
            this.sonuclbl.TabIndex = 0;
            this.sonuclbl.Text = "Sonuç: 29587438574345345345";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(544, 185);
            this.Controls.Add(this.gbox1);
            this.Controls.Add(this.btnbol);
            this.Controls.Add(this.btncarp);
            this.Controls.Add(this.btncikar);
            this.Controls.Add(this.infobtn);
            this.Controls.Add(this.btntopla);
            this.Controls.Add(this.girilecekbox2);
            this.Controls.Add(this.girilecekbox1);
            this.Controls.Add(this.btn_lowerForm);
            this.Controls.Add(this.btn_closeForm);
            this.Controls.Add(this.pBox_moveForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "openGui";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBox_moveForm)).EndInit();
            this.gbox1.ResumeLayout(false);
            this.gbox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_closeForm;
        private System.Windows.Forms.Button btn_lowerForm;
        private System.Windows.Forms.PictureBox pBox_moveForm;
        private System.Windows.Forms.TextBox girilecekbox1;
        private System.Windows.Forms.TextBox girilecekbox2;
        private System.Windows.Forms.Button btntopla;
        private System.Windows.Forms.Button infobtn;
        private System.Windows.Forms.Button btncikar;
        private System.Windows.Forms.Button btncarp;
        private System.Windows.Forms.Button btnbol;
        private System.Windows.Forms.GroupBox gbox1;
        private System.Windows.Forms.Label sonuclbl;
    }
}

