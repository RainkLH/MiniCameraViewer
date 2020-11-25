namespace RKCamView
{
    partial class RKCamView
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RKCamView));
            this.AVPlayer = new AForge.Controls.VideoSourcePlayer();
            this.label1 = new System.Windows.Forms.Label();
            this.coBox_CamList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.coBox_ResoList = new System.Windows.Forms.ComboBox();
            this.btn_Photo = new System.Windows.Forms.Button();
            this.pBox_View = new System.Windows.Forms.PictureBox();
            this.btn_View = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_View)).BeginInit();
            this.SuspendLayout();
            // 
            // AVPlayer
            // 
            this.AVPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AVPlayer.Location = new System.Drawing.Point(2, 2);
            this.AVPlayer.Name = "AVPlayer";
            this.AVPlayer.Size = new System.Drawing.Size(640, 480);
            this.AVPlayer.TabIndex = 0;
            this.AVPlayer.Text = "AVPlayer";
            this.AVPlayer.VideoSource = null;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(645, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "CameraDevice:";
            // 
            // coBox_CamList
            // 
            this.coBox_CamList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coBox_CamList.FormattingEnabled = true;
            this.coBox_CamList.Location = new System.Drawing.Point(648, 24);
            this.coBox_CamList.Name = "coBox_CamList";
            this.coBox_CamList.Size = new System.Drawing.Size(150, 20);
            this.coBox_CamList.TabIndex = 2;
            this.coBox_CamList.SelectedIndexChanged += new System.EventHandler(this.coBox_CamList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(645, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Resolution Ratio:";
            // 
            // coBox_ResoList
            // 
            this.coBox_ResoList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coBox_ResoList.FormattingEnabled = true;
            this.coBox_ResoList.Location = new System.Drawing.Point(648, 66);
            this.coBox_ResoList.Name = "coBox_ResoList";
            this.coBox_ResoList.Size = new System.Drawing.Size(150, 20);
            this.coBox_ResoList.TabIndex = 4;
            this.coBox_ResoList.SelectedIndexChanged += new System.EventHandler(this.coBox_ResoList_SelectedIndexChanged);
            // 
            // btn_Photo
            // 
            this.btn_Photo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Photo.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Photo.Location = new System.Drawing.Point(723, 338);
            this.btn_Photo.Name = "btn_Photo";
            this.btn_Photo.Size = new System.Drawing.Size(75, 23);
            this.btn_Photo.TabIndex = 5;
            this.btn_Photo.Text = "Photograph";
            this.btn_Photo.UseVisualStyleBackColor = true;
            this.btn_Photo.Click += new System.EventHandler(this.btn_Photo_Click);
            // 
            // pBox_View
            // 
            this.pBox_View.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pBox_View.Location = new System.Drawing.Point(648, 367);
            this.pBox_View.Name = "pBox_View";
            this.pBox_View.Size = new System.Drawing.Size(150, 115);
            this.pBox_View.TabIndex = 6;
            this.pBox_View.TabStop = false;
            this.pBox_View.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pBox_View_MouseClick);
            // 
            // btn_View
            // 
            this.btn_View.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_View.BackColor = System.Drawing.Color.Transparent;
            this.btn_View.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View.Location = new System.Drawing.Point(648, 92);
            this.btn_View.Name = "btn_View";
            this.btn_View.Size = new System.Drawing.Size(150, 46);
            this.btn_View.TabIndex = 7;
            this.btn_View.Text = "Open";
            this.btn_View.UseVisualStyleBackColor = false;
            this.btn_View.Click += new System.EventHandler(this.btn_View_Click);
            // 
            // RKCamView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 486);
            this.Controls.Add(this.btn_View);
            this.Controls.Add(this.pBox_View);
            this.Controls.Add(this.btn_Photo);
            this.Controls.Add(this.coBox_ResoList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.coBox_CamList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AVPlayer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RKCamView";
            this.Text = "RK Camera Viewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pBox_View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AForge.Controls.VideoSourcePlayer AVPlayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox coBox_CamList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox coBox_ResoList;
        private System.Windows.Forms.Button btn_Photo;
        private System.Windows.Forms.PictureBox pBox_View;
        private System.Windows.Forms.Button btn_View;
    }
}

