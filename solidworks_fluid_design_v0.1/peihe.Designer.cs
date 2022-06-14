namespace solidworks_fluid_design_v0._1
{
    partial class peihe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(peihe));
            this.btnBegin = new HZH_Controls.Controls.UCBtnExt();
            this.ucBtnExt1 = new HZH_Controls.Controls.UCBtnExt();
            this.checkSave = new HZH_Controls.Controls.UCCheckBox();
            this.SuspendLayout();
            // 
            // btnBegin
            // 
            this.btnBegin.BackColor = System.Drawing.Color.White;
            this.btnBegin.BtnBackColor = System.Drawing.Color.White;
            this.btnBegin.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBegin.BtnForeColor = System.Drawing.Color.White;
            this.btnBegin.BtnText = "开始";
            this.btnBegin.ConerRadius = 5;
            this.btnBegin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBegin.EnabledMouseEffect = false;
            this.btnBegin.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnBegin.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnBegin.IsRadius = true;
            this.btnBegin.IsShowRect = true;
            this.btnBegin.IsShowTips = false;
            this.btnBegin.Location = new System.Drawing.Point(53, 39);
            this.btnBegin.Margin = new System.Windows.Forms.Padding(0);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.RectColor = System.Drawing.Color.DarkBlue;
            this.btnBegin.RectWidth = 1;
            this.btnBegin.Size = new System.Drawing.Size(85, 41);
            this.btnBegin.TabIndex = 3;
            this.btnBegin.TabStop = false;
            this.btnBegin.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btnBegin.TipsText = "";
            this.btnBegin.BtnClick += new System.EventHandler(this.btnBegin_BtnClick);
            // 
            // ucBtnExt1
            // 
            this.ucBtnExt1.BackColor = System.Drawing.Color.White;
            this.ucBtnExt1.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt1.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt1.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt1.BtnText = "返回";
            this.ucBtnExt1.ConerRadius = 5;
            this.ucBtnExt1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt1.EnabledMouseEffect = false;
            this.ucBtnExt1.FillColor = System.Drawing.Color.RoyalBlue;
            this.ucBtnExt1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnExt1.IsRadius = true;
            this.ucBtnExt1.IsShowRect = true;
            this.ucBtnExt1.IsShowTips = false;
            this.ucBtnExt1.Location = new System.Drawing.Point(432, 210);
            this.ucBtnExt1.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt1.Name = "ucBtnExt1";
            this.ucBtnExt1.RectColor = System.Drawing.Color.DarkBlue;
            this.ucBtnExt1.RectWidth = 1;
            this.ucBtnExt1.Size = new System.Drawing.Size(85, 41);
            this.ucBtnExt1.TabIndex = 3;
            this.ucBtnExt1.TabStop = false;
            this.ucBtnExt1.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt1.TipsText = "";
            this.ucBtnExt1.BtnClick += new System.EventHandler(this.ucBtnExt1_BtnClick);
            // 
            // checkSave
            // 
            this.checkSave.BackColor = System.Drawing.Color.Transparent;
            this.checkSave.Checked = false;
            this.checkSave.Font = new System.Drawing.Font("宋体", 12F);
            this.checkSave.Location = new System.Drawing.Point(35, 181);
            this.checkSave.Name = "checkSave";
            this.checkSave.Padding = new System.Windows.Forms.Padding(1);
            this.checkSave.Size = new System.Drawing.Size(120, 30);
            this.checkSave.TabIndex = 5;
            this.checkSave.TextValue = "自动保存";
            // 
            // peihe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 260);
            this.Controls.Add(this.checkSave);
            this.Controls.Add(this.ucBtnExt1);
            this.Controls.Add(this.btnBegin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "peihe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "配油盘设计";
            this.ResumeLayout(false);

        }

        #endregion

        private HZH_Controls.Controls.UCBtnExt btnBegin;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt1;
        private HZH_Controls.Controls.UCCheckBox checkSave;
    }
}