
namespace FSShortcut
{
    partial class IntroNSetting
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
            this.label1 = new System.Windows.Forms.Label();
            this.followCursor = new System.Windows.Forms.CheckBox();
            this.duration = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.FontSize = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.checkLive2D = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.duration)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(45, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(488, 168);
            this.label1.TabIndex = 0;
            this.label1.Text = "底下四个按钮：\n加载Live2D快捷键，添加，删除，清空\n点左边快捷键录入，双击右边写字\n最左边空白列用来选中删除\n桌面捕获可以用跟随鼠标那个\n窗口捕捉添加主界面" +
    "显示。";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // followCursor
            // 
            this.followCursor.AutoSize = true;
            this.followCursor.Checked = true;
            this.followCursor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.followCursor.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.followCursor.Location = new System.Drawing.Point(17, 225);
            this.followCursor.Name = "followCursor";
            this.followCursor.Size = new System.Drawing.Size(216, 29);
            this.followCursor.TabIndex = 1;
            this.followCursor.Text = "跟随鼠标显示？";
            this.followCursor.UseVisualStyleBackColor = true;
            this.followCursor.CheckedChanged += new System.EventHandler(this.followCursor_CheckedChanged);
            // 
            // duration
            // 
            this.duration.DecimalPlaces = 1;
            this.duration.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.duration.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.duration.Location = new System.Drawing.Point(295, 310);
            this.duration.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(120, 34);
            this.duration.TabIndex = 2;
            this.duration.Value = new decimal(new int[] {
            8,
            0,
            0,
            65536});
            this.duration.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("黑体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(109, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "持续时间(秒)";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("华文琥珀", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(493, 437);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 89);
            this.button1.TabIndex = 4;
            this.button1.Text = "      好耶！";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FontSize
            // 
            this.FontSize.AutoSize = true;
            this.FontSize.Font = new System.Drawing.Font("黑体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FontSize.Location = new System.Drawing.Point(12, 388);
            this.FontSize.Name = "FontSize";
            this.FontSize.Size = new System.Drawing.Size(292, 28);
            this.FontSize.TabIndex = 5;
            this.FontSize.Text = "点我左键字体右键字色";
            this.FontSize.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FontSize_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("黑体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(443, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "点我修改背景颜色";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(685, 430);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 102);
            this.button2.TabIndex = 7;
            this.button2.Text = "重置";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkLive2D
            // 
            this.checkLive2D.AutoSize = true;
            this.checkLive2D.Checked = true;
            this.checkLive2D.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkLive2D.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkLive2D.Location = new System.Drawing.Point(17, 260);
            this.checkLive2D.Name = "checkLive2D";
            this.checkLive2D.Size = new System.Drawing.Size(268, 29);
            this.checkLive2D.TabIndex = 8;
            this.checkLive2D.Text = "只在Live2D时显示？";
            this.checkLive2D.UseVisualStyleBackColor = true;
            this.checkLive2D.CheckedChanged += new System.EventHandler(this.checkLive2D_CheckedChanged);
            // 
            // IntroNSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 538);
            this.ControlBox = false;
            this.Controls.Add(this.checkLive2D);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FontSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.duration);
            this.Controls.Add(this.followCursor);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IntroNSetting";
            this.Text = "介绍和设置";
            ((System.ComponentModel.ISupportInitialize)(this.duration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox followCursor;
        private System.Windows.Forms.NumericUpDown duration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label FontSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkLive2D;
    }
}