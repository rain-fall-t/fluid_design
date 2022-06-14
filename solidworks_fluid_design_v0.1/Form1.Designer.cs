namespace solidworks_fluid_design_v0._1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnLink = new HZH_Controls.Controls.UCBtnExt();
            this.testStatus = new CCWin.SkinControl.SkinTextBox();
            this.BtnDesign = new HZH_Controls.Controls.UCBtnExt();
            this.ucWave2 = new HZH_Controls.Controls.UCWave();
            this.ucBtnExt1 = new HZH_Controls.Controls.UCBtnExt();
            this.ucBtnExt2 = new HZH_Controls.Controls.UCBtnExt();
            this.ucBtnExt3 = new HZH_Controls.Controls.UCBtnExt();
            this.ucBtnExt4 = new HZH_Controls.Controls.UCBtnExt();
            this.btnPeiYouPan = new HZH_Controls.Controls.UCBtnExt();
            this.btnGangti = new HZH_Controls.Controls.UCBtnExt();
            this.ucBtnExt5 = new HZH_Controls.Controls.UCBtnExt();
            this.SuspendLayout();
            // 
            // btnLink
            // 
            this.btnLink.BackColor = System.Drawing.Color.White;
            this.btnLink.BtnBackColor = System.Drawing.Color.White;
            this.btnLink.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLink.BtnForeColor = System.Drawing.Color.White;
            this.btnLink.BtnText = "连接到SW";
            this.btnLink.ConerRadius = 5;
            this.btnLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLink.EnabledMouseEffect = false;
            this.btnLink.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnLink.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnLink.IsRadius = true;
            this.btnLink.IsShowRect = true;
            this.btnLink.IsShowTips = false;
            this.btnLink.Location = new System.Drawing.Point(197, 9);
            this.btnLink.Margin = new System.Windows.Forms.Padding(0);
            this.btnLink.Name = "btnLink";
            this.btnLink.RectColor = System.Drawing.Color.DarkBlue;
            this.btnLink.RectWidth = 1;
            this.btnLink.Size = new System.Drawing.Size(128, 43);
            this.btnLink.TabIndex = 0;
            this.btnLink.TabStop = false;
            this.btnLink.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btnLink.TipsText = "";
            this.btnLink.BtnClick += new System.EventHandler(this.btnStart_BtnClick);
            // 
            // testStatus
            // 
            this.testStatus.BackColor = System.Drawing.Color.Transparent;
            this.testStatus.DownBack = null;
            this.testStatus.Icon = null;
            this.testStatus.IconIsButton = false;
            this.testStatus.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.testStatus.IsPasswordChat = '\0';
            this.testStatus.IsSystemPasswordChar = false;
            this.testStatus.Lines = new string[] {
        "状态：未连接"};
            this.testStatus.Location = new System.Drawing.Point(200, 52);
            this.testStatus.Margin = new System.Windows.Forms.Padding(0);
            this.testStatus.MaxLength = 32767;
            this.testStatus.MinimumSize = new System.Drawing.Size(28, 28);
            this.testStatus.MouseBack = null;
            this.testStatus.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.testStatus.Multiline = true;
            this.testStatus.Name = "testStatus";
            this.testStatus.NormlBack = null;
            this.testStatus.Padding = new System.Windows.Forms.Padding(5);
            this.testStatus.ReadOnly = true;
            this.testStatus.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.testStatus.Size = new System.Drawing.Size(125, 30);
            // 
            // 
            // 
            this.testStatus.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.testStatus.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testStatus.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.testStatus.SkinTxt.ForeColor = System.Drawing.Color.RoyalBlue;
            this.testStatus.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.testStatus.SkinTxt.Multiline = true;
            this.testStatus.SkinTxt.Name = "BaseText";
            this.testStatus.SkinTxt.ReadOnly = true;
            this.testStatus.SkinTxt.Size = new System.Drawing.Size(115, 20);
            this.testStatus.SkinTxt.TabIndex = 0;
            this.testStatus.SkinTxt.Text = "状态：未连接";
            this.testStatus.SkinTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.testStatus.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.testStatus.SkinTxt.WaterText = "";
            this.testStatus.TabIndex = 1;
            this.testStatus.Text = "状态：未连接";
            this.testStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.testStatus.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.testStatus.WaterText = "";
            this.testStatus.WordWrap = true;
            // 
            // BtnDesign
            // 
            this.BtnDesign.BackColor = System.Drawing.Color.White;
            this.BtnDesign.BtnBackColor = System.Drawing.Color.White;
            this.BtnDesign.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnDesign.BtnForeColor = System.Drawing.Color.White;
            this.BtnDesign.BtnText = "柱塞";
            this.BtnDesign.ConerRadius = 5;
            this.BtnDesign.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDesign.EnabledMouseEffect = false;
            this.BtnDesign.FillColor = System.Drawing.Color.RoyalBlue;
            this.BtnDesign.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BtnDesign.IsRadius = true;
            this.BtnDesign.IsShowRect = true;
            this.BtnDesign.IsShowTips = false;
            this.BtnDesign.Location = new System.Drawing.Point(32, 96);
            this.BtnDesign.Margin = new System.Windows.Forms.Padding(0);
            this.BtnDesign.Name = "BtnDesign";
            this.BtnDesign.RectColor = System.Drawing.Color.DarkBlue;
            this.BtnDesign.RectWidth = 1;
            this.BtnDesign.Size = new System.Drawing.Size(85, 41);
            this.BtnDesign.TabIndex = 0;
            this.BtnDesign.TabStop = false;
            this.BtnDesign.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.BtnDesign.TipsText = "";
            this.BtnDesign.BtnClick += new System.EventHandler(this.btnDesign1_BtnClick);
            // 
            // ucWave2
            // 
            this.ucWave2.Location = new System.Drawing.Point(-21, 198);
            this.ucWave2.Name = "ucWave2";
            this.ucWave2.Size = new System.Drawing.Size(600, 100);
            this.ucWave2.TabIndex = 2;
            this.ucWave2.Text = "ucWave2";
            this.ucWave2.WaveColor = System.Drawing.Color.RoyalBlue;
            this.ucWave2.WaveHeight = 30;
            this.ucWave2.WaveSleep = 50;
            this.ucWave2.WaveWidth = 200;
            // 
            // ucBtnExt1
            // 
            this.ucBtnExt1.BackColor = System.Drawing.Color.White;
            this.ucBtnExt1.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt1.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt1.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt1.BtnText = "柱塞";
            this.ucBtnExt1.ConerRadius = 5;
            this.ucBtnExt1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt1.EnabledMouseEffect = false;
            this.ucBtnExt1.FillColor = System.Drawing.Color.RoyalBlue;
            this.ucBtnExt1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnExt1.IsRadius = true;
            this.ucBtnExt1.IsShowRect = true;
            this.ucBtnExt1.IsShowTips = false;
            this.ucBtnExt1.Location = new System.Drawing.Point(32, 96);
            this.ucBtnExt1.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt1.Name = "ucBtnExt1";
            this.ucBtnExt1.RectColor = System.Drawing.Color.DarkBlue;
            this.ucBtnExt1.RectWidth = 1;
            this.ucBtnExt1.Size = new System.Drawing.Size(85, 41);
            this.ucBtnExt1.TabIndex = 0;
            this.ucBtnExt1.TabStop = false;
            this.ucBtnExt1.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt1.TipsText = "";
            this.ucBtnExt1.BtnClick += new System.EventHandler(this.btnDesign1_BtnClick);
            // 
            // ucBtnExt2
            // 
            this.ucBtnExt2.BackColor = System.Drawing.Color.White;
            this.ucBtnExt2.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt2.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt2.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt2.BtnText = "滑靴";
            this.ucBtnExt2.ConerRadius = 5;
            this.ucBtnExt2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt2.EnabledMouseEffect = false;
            this.ucBtnExt2.FillColor = System.Drawing.Color.RoyalBlue;
            this.ucBtnExt2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnExt2.IsRadius = true;
            this.ucBtnExt2.IsShowRect = true;
            this.ucBtnExt2.IsShowTips = false;
            this.ucBtnExt2.Location = new System.Drawing.Point(147, 96);
            this.ucBtnExt2.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt2.Name = "ucBtnExt2";
            this.ucBtnExt2.RectColor = System.Drawing.Color.DarkBlue;
            this.ucBtnExt2.RectWidth = 1;
            this.ucBtnExt2.Size = new System.Drawing.Size(85, 41);
            this.ucBtnExt2.TabIndex = 3;
            this.ucBtnExt2.TabStop = false;
            this.ucBtnExt2.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt2.TipsText = "";
            this.ucBtnExt2.BtnClick += new System.EventHandler(this.ucBtnExt2_BtnClick);
            // 
            // ucBtnExt3
            // 
            this.ucBtnExt3.BackColor = System.Drawing.Color.White;
            this.ucBtnExt3.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt3.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt3.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt3.BtnText = "设置";
            this.ucBtnExt3.ConerRadius = 5;
            this.ucBtnExt3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt3.EnabledMouseEffect = false;
            this.ucBtnExt3.FillColor = System.Drawing.Color.RoyalBlue;
            this.ucBtnExt3.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnExt3.IsRadius = true;
            this.ucBtnExt3.IsShowRect = true;
            this.ucBtnExt3.IsShowTips = false;
            this.ucBtnExt3.Location = new System.Drawing.Point(32, 9);
            this.ucBtnExt3.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt3.Name = "ucBtnExt3";
            this.ucBtnExt3.RectColor = System.Drawing.Color.DarkBlue;
            this.ucBtnExt3.RectWidth = 1;
            this.ucBtnExt3.Size = new System.Drawing.Size(85, 41);
            this.ucBtnExt3.TabIndex = 4;
            this.ucBtnExt3.TabStop = false;
            this.ucBtnExt3.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt3.TipsText = "";
            this.ucBtnExt3.BtnClick += new System.EventHandler(this.setting_BtnClick);
            // 
            // ucBtnExt4
            // 
            this.ucBtnExt4.BackColor = System.Drawing.Color.White;
            this.ucBtnExt4.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt4.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt4.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt4.BtnText = "退出";
            this.ucBtnExt4.ConerRadius = 5;
            this.ucBtnExt4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt4.EnabledMouseEffect = false;
            this.ucBtnExt4.FillColor = System.Drawing.Color.RoyalBlue;
            this.ucBtnExt4.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnExt4.IsRadius = true;
            this.ucBtnExt4.IsShowRect = true;
            this.ucBtnExt4.IsShowTips = false;
            this.ucBtnExt4.Location = new System.Drawing.Point(414, 11);
            this.ucBtnExt4.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt4.Name = "ucBtnExt4";
            this.ucBtnExt4.RectColor = System.Drawing.Color.DarkBlue;
            this.ucBtnExt4.RectWidth = 1;
            this.ucBtnExt4.Size = new System.Drawing.Size(85, 41);
            this.ucBtnExt4.TabIndex = 5;
            this.ucBtnExt4.TabStop = false;
            this.ucBtnExt4.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt4.TipsText = "";
            this.ucBtnExt4.BtnClick += new System.EventHandler(this.exit_BtnClick);
            // 
            // btnPeiYouPan
            // 
            this.btnPeiYouPan.BackColor = System.Drawing.Color.White;
            this.btnPeiYouPan.BtnBackColor = System.Drawing.Color.White;
            this.btnPeiYouPan.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPeiYouPan.BtnForeColor = System.Drawing.Color.White;
            this.btnPeiYouPan.BtnText = "配油盘";
            this.btnPeiYouPan.ConerRadius = 5;
            this.btnPeiYouPan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPeiYouPan.EnabledMouseEffect = false;
            this.btnPeiYouPan.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnPeiYouPan.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnPeiYouPan.IsRadius = true;
            this.btnPeiYouPan.IsShowRect = true;
            this.btnPeiYouPan.IsShowTips = false;
            this.btnPeiYouPan.Location = new System.Drawing.Point(266, 96);
            this.btnPeiYouPan.Margin = new System.Windows.Forms.Padding(0);
            this.btnPeiYouPan.Name = "btnPeiYouPan";
            this.btnPeiYouPan.RectColor = System.Drawing.Color.DarkBlue;
            this.btnPeiYouPan.RectWidth = 1;
            this.btnPeiYouPan.Size = new System.Drawing.Size(85, 41);
            this.btnPeiYouPan.TabIndex = 6;
            this.btnPeiYouPan.TabStop = false;
            this.btnPeiYouPan.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btnPeiYouPan.TipsText = "";
            this.btnPeiYouPan.BtnClick += new System.EventHandler(this.btnPeiYouPan_BtnClick);
            // 
            // btnGangti
            // 
            this.btnGangti.BackColor = System.Drawing.Color.White;
            this.btnGangti.BtnBackColor = System.Drawing.Color.White;
            this.btnGangti.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGangti.BtnForeColor = System.Drawing.Color.White;
            this.btnGangti.BtnText = "缸体";
            this.btnGangti.ConerRadius = 5;
            this.btnGangti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGangti.EnabledMouseEffect = false;
            this.btnGangti.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnGangti.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnGangti.IsRadius = true;
            this.btnGangti.IsShowRect = true;
            this.btnGangti.IsShowTips = false;
            this.btnGangti.Location = new System.Drawing.Point(385, 96);
            this.btnGangti.Margin = new System.Windows.Forms.Padding(0);
            this.btnGangti.Name = "btnGangti";
            this.btnGangti.RectColor = System.Drawing.Color.DarkBlue;
            this.btnGangti.RectWidth = 1;
            this.btnGangti.Size = new System.Drawing.Size(85, 41);
            this.btnGangti.TabIndex = 7;
            this.btnGangti.TabStop = false;
            this.btnGangti.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btnGangti.TipsText = "";
            this.btnGangti.BtnClick += new System.EventHandler(this.btnGangti_BtnClick);
            // 
            // ucBtnExt5
            // 
            this.ucBtnExt5.BackColor = System.Drawing.Color.White;
            this.ucBtnExt5.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt5.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt5.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt5.BtnText = "装配";
            this.ucBtnExt5.ConerRadius = 5;
            this.ucBtnExt5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt5.EnabledMouseEffect = false;
            this.ucBtnExt5.FillColor = System.Drawing.Color.RoyalBlue;
            this.ucBtnExt5.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnExt5.IsRadius = true;
            this.ucBtnExt5.IsShowRect = true;
            this.ucBtnExt5.IsShowTips = false;
            this.ucBtnExt5.Location = new System.Drawing.Point(200, 154);
            this.ucBtnExt5.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt5.Name = "ucBtnExt5";
            this.ucBtnExt5.RectColor = System.Drawing.Color.DarkBlue;
            this.ucBtnExt5.RectWidth = 1;
            this.ucBtnExt5.Size = new System.Drawing.Size(85, 41);
            this.ucBtnExt5.TabIndex = 8;
            this.ucBtnExt5.TabStop = false;
            this.ucBtnExt5.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt5.TipsText = "";
            this.ucBtnExt5.BtnClick += new System.EventHandler(this.ucBtnExt5_BtnClick);
            // 
            // Form1
            // 
            this.BackgroundImage = global::solidworks_fluid_design_v0._1.Properties.Resources.all;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(526, 260);
            this.Controls.Add(this.ucBtnExt5);
            this.Controls.Add(this.btnGangti);
            this.Controls.Add(this.btnPeiYouPan);
            this.Controls.Add(this.ucBtnExt4);
            this.Controls.Add(this.ucBtnExt3);
            this.Controls.Add(this.ucBtnExt2);
            this.Controls.Add(this.ucWave2);
            this.Controls.Add(this.testStatus);
            this.Controls.Add(this.ucBtnExt1);
            this.Controls.Add(this.BtnDesign);
            this.Controls.Add(this.btnLink);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "流体力学设计软件";
            this.ResumeLayout(false);

        }

        #endregion

        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private CCWin.SkinControl.SkinHotKey skinHotKey1;
        private HZH_Controls.Controls.UCWave ucWave1;
        private HZH_Controls.Controls.UCBtnExt btnStart;
        private HZH_Controls.Controls.TextBoxEx statusText;
        private HZH_Controls.Controls.TextBoxEx textBoxEx2;
        private HZH_Controls.Controls.UCBtnExt BtnDesign1;
        private HZH_Controls.Controls.UCBtnExt btnLink;
        private CCWin.SkinControl.SkinTextBox testStatus;
        private HZH_Controls.Controls.UCBtnExt BtnDesign;
        private HZH_Controls.Controls.UCWave ucWave2;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt1;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt2;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt3;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt4;
        private HZH_Controls.Controls.UCBtnExt btnPeiYouPan;
        private HZH_Controls.Controls.UCBtnExt btnGangti;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt5;
    }
}

