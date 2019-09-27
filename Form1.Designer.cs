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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.genelislembox1 = new System.Windows.Forms.GroupBox();
            this.firstsonuclblTP = new System.Windows.Forms.Label();
            this.btnrastgele = new System.Windows.Forms.Button();
            this.secondsonuclblTP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sonuclbltp = new System.Windows.Forms.Label();
            this.islemlbl = new System.Windows.Forms.Label();
            this.bolmebox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bolenlbl = new System.Windows.Forms.Label();
            this.bolmeklnlbl = new System.Windows.Forms.Label();
            this.bolunenlbl = new System.Windows.Forms.Label();
            this.bolumlbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rastgelebox1 = new System.Windows.Forms.GroupBox();
            this.rastgelelbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_moveForm)).BeginInit();
            this.genelislembox1.SuspendLayout();
            this.bolmebox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.rastgelebox1.SuspendLayout();
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
            this.btn_closeForm.Location = new System.Drawing.Point(559, 0);
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
            this.btn_lowerForm.Location = new System.Drawing.Point(525, 0);
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
            this.girilecekbox1.Size = new System.Drawing.Size(283, 30);
            this.girilecekbox1.TabIndex = 3;
            this.girilecekbox1.Text = "Bir numara gir";
            this.girilecekbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // girilecekbox2
            // 
            this.girilecekbox2.BackColor = System.Drawing.Color.Silver;
            this.girilecekbox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.girilecekbox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girilecekbox2.Location = new System.Drawing.Point(301, 42);
            this.girilecekbox2.MaxLength = 19;
            this.girilecekbox2.Name = "girilecekbox2";
            this.girilecekbox2.Size = new System.Drawing.Size(283, 30);
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
            this.infobtn.Location = new System.Drawing.Point(12, 222);
            this.infobtn.Name = "infobtn";
            this.infobtn.Size = new System.Drawing.Size(65, 31);
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
            // genelislembox1
            // 
            this.genelislembox1.Controls.Add(this.islemlbl);
            this.genelislembox1.Controls.Add(this.sonuclbltp);
            this.genelislembox1.Controls.Add(this.label1);
            this.genelislembox1.Controls.Add(this.secondsonuclblTP);
            this.genelislembox1.Controls.Add(this.firstsonuclblTP);
            this.genelislembox1.Location = new System.Drawing.Point(224, 78);
            this.genelislembox1.Name = "genelislembox1";
            this.genelislembox1.Size = new System.Drawing.Size(359, 175);
            this.genelislembox1.TabIndex = 13;
            this.genelislembox1.TabStop = false;
            // 
            // firstsonuclblTP
            // 
            this.firstsonuclblTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.firstsonuclblTP.Location = new System.Drawing.Point(6, 16);
            this.firstsonuclblTP.Name = "firstsonuclblTP";
            this.firstsonuclblTP.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.firstsonuclblTP.Size = new System.Drawing.Size(347, 25);
            this.firstsonuclblTP.TabIndex = 0;
            this.firstsonuclblTP.Text = "0";
            this.firstsonuclblTP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnrastgele
            // 
            this.btnrastgele.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnrastgele.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnrastgele.Location = new System.Drawing.Point(12, 129);
            this.btnrastgele.Name = "btnrastgele";
            this.btnrastgele.Size = new System.Drawing.Size(206, 44);
            this.btnrastgele.TabIndex = 14;
            this.btnrastgele.Text = "rastgele";
            this.btnrastgele.UseVisualStyleBackColor = true;
            this.btnrastgele.Click += new System.EventHandler(this.Btnrastgele_Click);
            // 
            // secondsonuclblTP
            // 
            this.secondsonuclblTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.secondsonuclblTP.Location = new System.Drawing.Point(6, 57);
            this.secondsonuclblTP.Name = "secondsonuclblTP";
            this.secondsonuclblTP.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.secondsonuclblTP.Size = new System.Drawing.Size(347, 25);
            this.secondsonuclblTP.TabIndex = 1;
            this.secondsonuclblTP.Text = "0";
            this.secondsonuclblTP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 107);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(345, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "____________________________________________________________________";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sonuclbltp
            // 
            this.sonuclbltp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sonuclbltp.Location = new System.Drawing.Point(3, 130);
            this.sonuclbltp.Name = "sonuclbltp";
            this.sonuclbltp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sonuclbltp.Size = new System.Drawing.Size(347, 25);
            this.sonuclbltp.TabIndex = 3;
            this.sonuclbltp.Text = "0";
            this.sonuclbltp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // islemlbl
            // 
            this.islemlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.islemlbl.Location = new System.Drawing.Point(6, 82);
            this.islemlbl.Name = "islemlbl";
            this.islemlbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.islemlbl.Size = new System.Drawing.Size(37, 32);
            this.islemlbl.TabIndex = 4;
            this.islemlbl.Text = "+";
            this.islemlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bolmebox1
            // 
            this.bolmebox1.Controls.Add(this.label2);
            this.bolmebox1.Controls.Add(this.bolumlbl);
            this.bolmebox1.Controls.Add(this.bolunenlbl);
            this.bolmebox1.Controls.Add(this.bolmeklnlbl);
            this.bolmebox1.Controls.Add(this.bolenlbl);
            this.bolmebox1.Controls.Add(this.pictureBox1);
            this.bolmebox1.Location = new System.Drawing.Point(224, 78);
            this.bolmebox1.Name = "bolmebox1";
            this.bolmebox1.Size = new System.Drawing.Size(359, 175);
            this.bolmebox1.TabIndex = 14;
            this.bolmebox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(342, 150);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bolenlbl
            // 
            this.bolenlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bolenlbl.Location = new System.Drawing.Point(185, 42);
            this.bolenlbl.Name = "bolenlbl";
            this.bolenlbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bolenlbl.Size = new System.Drawing.Size(168, 25);
            this.bolenlbl.TabIndex = 5;
            this.bolenlbl.Text = "0";
            this.bolenlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bolmeklnlbl
            // 
            this.bolmeklnlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bolmeklnlbl.Location = new System.Drawing.Point(6, 132);
            this.bolmeklnlbl.Name = "bolmeklnlbl";
            this.bolmeklnlbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bolmeklnlbl.Size = new System.Drawing.Size(162, 25);
            this.bolmeklnlbl.TabIndex = 6;
            this.bolmeklnlbl.Text = "0";
            this.bolmeklnlbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bolunenlbl
            // 
            this.bolunenlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bolunenlbl.Location = new System.Drawing.Point(6, 42);
            this.bolunenlbl.Name = "bolunenlbl";
            this.bolunenlbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bolunenlbl.Size = new System.Drawing.Size(162, 25);
            this.bolunenlbl.TabIndex = 7;
            this.bolunenlbl.Text = "0";
            this.bolunenlbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bolumlbl
            // 
            this.bolumlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bolumlbl.Location = new System.Drawing.Point(185, 101);
            this.bolumlbl.Name = "bolumlbl";
            this.bolumlbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bolumlbl.Size = new System.Drawing.Size(162, 25);
            this.bolumlbl.TabIndex = 8;
            this.bolumlbl.Text = "0";
            this.bolumlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(86, 85);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(37, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "-";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rastgelebox1
            // 
            this.rastgelebox1.Controls.Add(this.rastgelelbl);
            this.rastgelebox1.Location = new System.Drawing.Point(224, 78);
            this.rastgelebox1.Name = "rastgelebox1";
            this.rastgelebox1.Size = new System.Drawing.Size(359, 72);
            this.rastgelebox1.TabIndex = 15;
            this.rastgelebox1.TabStop = false;
            // 
            // rastgelelbl
            // 
            this.rastgelelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rastgelelbl.Location = new System.Drawing.Point(11, 16);
            this.rastgelelbl.Name = "rastgelelbl";
            this.rastgelelbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rastgelelbl.Size = new System.Drawing.Size(337, 41);
            this.rastgelelbl.TabIndex = 5;
            this.rastgelelbl.Text = "Rastgele:";
            this.rastgelelbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(594, 264);
            this.Controls.Add(this.rastgelebox1);
            this.Controls.Add(this.bolmebox1);
            this.Controls.Add(this.btnrastgele);
            this.Controls.Add(this.genelislembox1);
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
            this.genelislembox1.ResumeLayout(false);
            this.bolmebox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.rastgelebox1.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox genelislembox1;
        private System.Windows.Forms.Label firstsonuclblTP;
        private System.Windows.Forms.Button btnrastgele;
        private System.Windows.Forms.Label secondsonuclblTP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label islemlbl;
        private System.Windows.Forms.Label sonuclbltp;
        private System.Windows.Forms.GroupBox bolmebox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label bolumlbl;
        private System.Windows.Forms.Label bolunenlbl;
        private System.Windows.Forms.Label bolmeklnlbl;
        private System.Windows.Forms.Label bolenlbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox rastgelebox1;
        private System.Windows.Forms.Label rastgelelbl;
    }
}

