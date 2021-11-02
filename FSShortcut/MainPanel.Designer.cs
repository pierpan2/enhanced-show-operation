
namespace FSShortcut
{
    partial class MainPanel
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
            label1 = new System.Windows.Forms.Label();
            this.SettingBut = new System.Windows.Forms.Button();
            this.Intro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("黑体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            label1.Location = new System.Drawing.Point(309, 96);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(137, 40);
            label1.TabIndex = 0;
            label1.Text = "label1";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            label1.Click += new System.EventHandler(label1_Click);
            // 
            // SettingBut
            // 
            this.SettingBut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SettingBut.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SettingBut.Location = new System.Drawing.Point(116, 223);
            this.SettingBut.Name = "SettingBut";
            this.SettingBut.Size = new System.Drawing.Size(124, 79);
            this.SettingBut.TabIndex = 1;
            this.SettingBut.Text = "快捷键设置";
            this.SettingBut.UseVisualStyleBackColor = true;
            this.SettingBut.Click += new System.EventHandler(this.SettingBut_Click);
            // 
            // Intro
            // 
            this.Intro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Intro.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Intro.Location = new System.Drawing.Point(482, 266);
            this.Intro.Name = "Intro";
            this.Intro.Size = new System.Drawing.Size(236, 52);
            this.Intro.TabIndex = 2;
            this.Intro.Text = "功能介绍和设置";
            this.Intro.UseVisualStyleBackColor = true;
            this.Intro.Click += new System.EventHandler(this.Intro_Click);
            // 
            // MainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 353);
            this.Controls.Add(this.Intro);
            this.Controls.Add(this.SettingBut);
            this.Controls.Add(label1);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "MainPanel";
            this.Text = "显示操作强化版";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainPanel_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SettingBut;
        private System.Windows.Forms.Button Intro;
        public static System.Windows.Forms.Label label1;
    }
}

