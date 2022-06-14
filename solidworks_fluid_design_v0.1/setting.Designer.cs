namespace solidworks_fluid_design_v0._1
{
    partial class setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(setting));
            this.labelVer = new CCWin.SkinControl.SkinLabel();
            this.comboxVer = new HZH_Controls.Controls.UCCombox();
            this.btnOk = new HZH_Controls.Controls.UCBtnExt();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.textSavePath = new HZH_Controls.Controls.UCTextBoxEx();
            this.SuspendLayout();
            // 
            // labelVer
            // 
            this.labelVer.AutoSize = true;
            this.labelVer.BackColor = System.Drawing.Color.Transparent;
            this.labelVer.BorderColor = System.Drawing.Color.White;
            this.labelVer.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.labelVer.Location = new System.Drawing.Point(49, 53);
            this.labelVer.Name = "labelVer";
            this.labelVer.Size = new System.Drawing.Size(157, 27);
            this.labelVer.TabIndex = 1;
            this.labelVer.Text = "Solidworks版本";
            this.labelVer.Click += new System.EventHandler(this.skinLabel1_Click);
            // 
            // comboxVer
            // 
            this.comboxVer.BackColor = System.Drawing.Color.Transparent;
            this.comboxVer.BackColorExt = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.comboxVer.BoxStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.comboxVer.ConerRadius = 5;
            this.comboxVer.DropPanelHeight = -1;
            this.comboxVer.FillColor = System.Drawing.Color.White;
            this.comboxVer.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.comboxVer.IsRadius = true;
            this.comboxVer.IsShowRect = true;
            this.comboxVer.ItemWidth = 70;
            this.comboxVer.Location = new System.Drawing.Point(213, 50);
            this.comboxVer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboxVer.Name = "comboxVer";
            this.comboxVer.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.comboxVer.RectWidth = 1;
            this.comboxVer.SelectedIndex = -1;
            this.comboxVer.SelectedValue = "";
            this.comboxVer.Size = new System.Drawing.Size(173, 32);
            this.comboxVer.Source = null;
            this.comboxVer.TabIndex = 3;
            this.comboxVer.TextValue = "2020";
            this.comboxVer.TriangleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.comboxVer.Load += new System.EventHandler(this.comboxVer_Load);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.White;
            this.btnOk.BtnBackColor = System.Drawing.Color.White;
            this.btnOk.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOk.BtnForeColor = System.Drawing.Color.White;
            this.btnOk.BtnText = "确定";
            this.btnOk.ConerRadius = 5;
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.EnabledMouseEffect = false;
            this.btnOk.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnOk.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnOk.IsRadius = true;
            this.btnOk.IsShowRect = true;
            this.btnOk.IsShowTips = false;
            this.btnOk.Location = new System.Drawing.Point(201, 180);
            this.btnOk.Margin = new System.Windows.Forms.Padding(0);
            this.btnOk.Name = "btnOk";
            this.btnOk.RectColor = System.Drawing.Color.DarkBlue;
            this.btnOk.RectWidth = 1;
            this.btnOk.Size = new System.Drawing.Size(85, 41);
            this.btnOk.TabIndex = 6;
            this.btnOk.TabStop = false;
            this.btnOk.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btnOk.TipsText = "";
            this.btnOk.BtnClick += new System.EventHandler(this.btnOk_BtnClick);
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.skinLabel1.Location = new System.Drawing.Point(49, 102);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(92, 27);
            this.skinLabel1.TabIndex = 1;
            this.skinLabel1.Text = "保存路径";
            this.skinLabel1.Click += new System.EventHandler(this.skinLabel1_Click);
            // 
            // textSavePath
            // 
            this.textSavePath.BackColor = System.Drawing.Color.Transparent;
            this.textSavePath.ConerRadius = 5;
            this.textSavePath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textSavePath.DecLength = 2;
            this.textSavePath.FillColor = System.Drawing.Color.Empty;
            this.textSavePath.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.textSavePath.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textSavePath.InputText = "";
            this.textSavePath.InputType = HZH_Controls.TextInputType.NotControl;
            this.textSavePath.IsFocusColor = true;
            this.textSavePath.IsFouceShowKey = false;
            this.textSavePath.IsRadius = true;
            this.textSavePath.IsShowClearBtn = true;
            this.textSavePath.IsShowKeyboard = false;
            this.textSavePath.IsShowRect = true;
            this.textSavePath.IsShowSearchBtn = false;
            this.textSavePath.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderAll_EN;
            this.textSavePath.Location = new System.Drawing.Point(213, 102);
            this.textSavePath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textSavePath.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.textSavePath.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.textSavePath.Name = "textSavePath";
            this.textSavePath.Padding = new System.Windows.Forms.Padding(5);
            this.textSavePath.PasswordChar = '\0';
            this.textSavePath.PromptColor = System.Drawing.Color.Gray;
            this.textSavePath.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textSavePath.PromptText = "\"D:\\\\fluid_design\\\\\"";
            this.textSavePath.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.textSavePath.RectWidth = 1;
            this.textSavePath.RegexPattern = "";
            this.textSavePath.Size = new System.Drawing.Size(173, 32);
            this.textSavePath.TabIndex = 7;
            // 
            // setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 253);
            this.Controls.Add(this.textSavePath);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.comboxVer);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.labelVer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "setting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "setting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CCWin.SkinControl.SkinLabel labelVer;
        private HZH_Controls.Controls.UCCombox comboxVer;
        private HZH_Controls.Controls.UCBtnExt btnOk;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private HZH_Controls.Controls.UCTextBoxEx textSavePath;
    }
}