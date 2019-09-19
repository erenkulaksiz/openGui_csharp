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
            this.btn_Settings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_moveForm)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_closeForm
            // 
            this.btn_closeForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_closeForm.FlatAppearance.BorderSize = 0;
            this.btn_closeForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.btn_lowerForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_lowerForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_lowerForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_lowerForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_lowerForm.ForeColor = System.Drawing.Color.White;
            this.btn_lowerForm.Location = new System.Drawing.Point(473, -1);
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
            this.pBox_moveForm.Size = new System.Drawing.Size(545, 28);
            this.pBox_moveForm.TabIndex = 2;
            this.pBox_moveForm.TabStop = false;
            this.pBox_moveForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PBox_moveForm_MouseDown);
            this.pBox_moveForm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PBox_moveForm_MouseMove);
            this.pBox_moveForm.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PBox_moveForm_MouseUp);
            // 
            // btn_Settings
            // 
            this.btn_Settings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Settings.BackgroundImage")));
            this.btn_Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Settings.FlatAppearance.BorderSize = 0;
            this.btn_Settings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Settings.Location = new System.Drawing.Point(509, 337);
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.Size = new System.Drawing.Size(36, 32);
            this.btn_Settings.TabIndex = 3;
            this.btn_Settings.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(544, 369);
            this.Controls.Add(this.btn_Settings);
            this.Controls.Add(this.btn_lowerForm);
            this.Controls.Add(this.btn_closeForm);
            this.Controls.Add(this.pBox_moveForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "openGui";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBox_moveForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_closeForm;
        private System.Windows.Forms.Button btn_lowerForm;
        private System.Windows.Forms.PictureBox pBox_moveForm;
        private System.Windows.Forms.Button btn_Settings;
    }
}

