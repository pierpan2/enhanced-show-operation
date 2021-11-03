
namespace FSShortcut
{
    partial class KeySetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeySetting));
            this.shortcutGrid = new System.Windows.Forms.DataGridView();
            this.LoadLive2D = new System.Windows.Forms.Button();
            this.clearAll = new System.Windows.Forms.Button();
            this.AddShortcut = new System.Windows.Forms.Button();
            this.DeleteShortcut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.shortcutGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // shortcutGrid
            // 
            this.shortcutGrid.AllowUserToAddRows = false;
            this.shortcutGrid.AllowUserToDeleteRows = false;
            this.shortcutGrid.AllowUserToResizeColumns = false;
            this.shortcutGrid.AllowUserToResizeRows = false;
            this.shortcutGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shortcutGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.shortcutGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shortcutGrid.Location = new System.Drawing.Point(132, 67);
            this.shortcutGrid.Margin = new System.Windows.Forms.Padding(5);
            this.shortcutGrid.Name = "shortcutGrid";
            this.shortcutGrid.RowHeadersWidth = 51;
            this.shortcutGrid.RowTemplate.Height = 27;
            this.shortcutGrid.Size = new System.Drawing.Size(755, 414);
            this.shortcutGrid.TabIndex = 0;
            this.shortcutGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.shortcutGrid_CellClick);
            this.shortcutGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.shortcutGrid_CellValueChanged);
            // 
            // LoadLive2D
            // 
            this.LoadLive2D.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LoadLive2D.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LoadLive2D.Location = new System.Drawing.Point(108, 531);
            this.LoadLive2D.Margin = new System.Windows.Forms.Padding(5);
            this.LoadLive2D.Name = "LoadLive2D";
            this.LoadLive2D.Size = new System.Drawing.Size(146, 97);
            this.LoadLive2D.TabIndex = 1;
            this.LoadLive2D.Text = "Live2D";
            this.LoadLive2D.UseVisualStyleBackColor = true;
            this.LoadLive2D.Click += new System.EventHandler(this.LoadLive2D_Click);
            // 
            // clearAll
            // 
            this.clearAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clearAll.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.clearAll.Location = new System.Drawing.Point(736, 577);
            this.clearAll.Margin = new System.Windows.Forms.Padding(5);
            this.clearAll.Name = "clearAll";
            this.clearAll.Size = new System.Drawing.Size(187, 67);
            this.clearAll.TabIndex = 2;
            this.clearAll.Text = "清空";
            this.clearAll.UseVisualStyleBackColor = true;
            this.clearAll.Click += new System.EventHandler(this.clearAll_Click);
            // 
            // AddShortcut
            // 
            this.AddShortcut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddShortcut.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AddShortcut.Location = new System.Drawing.Point(314, 549);
            this.AddShortcut.Margin = new System.Windows.Forms.Padding(5);
            this.AddShortcut.Name = "AddShortcut";
            this.AddShortcut.Size = new System.Drawing.Size(168, 80);
            this.AddShortcut.TabIndex = 3;
            this.AddShortcut.Text = "添加";
            this.AddShortcut.UseVisualStyleBackColor = true;
            this.AddShortcut.Click += new System.EventHandler(this.AddShortcut_Click);
            // 
            // DeleteShortcut
            // 
            this.DeleteShortcut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteShortcut.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DeleteShortcut.Location = new System.Drawing.Point(541, 531);
            this.DeleteShortcut.Margin = new System.Windows.Forms.Padding(5);
            this.DeleteShortcut.Name = "DeleteShortcut";
            this.DeleteShortcut.Size = new System.Drawing.Size(174, 96);
            this.DeleteShortcut.TabIndex = 4;
            this.DeleteShortcut.Text = "删除";
            this.DeleteShortcut.UseVisualStyleBackColor = true;
            this.DeleteShortcut.Click += new System.EventHandler(this.DeleteShortcut_Click);
            // 
            // KeySetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 649);
            this.Controls.Add(this.DeleteShortcut);
            this.Controls.Add(this.AddShortcut);
            this.Controls.Add(this.clearAll);
            this.Controls.Add(this.LoadLive2D);
            this.Controls.Add(this.shortcutGrid);
            this.Font = new System.Drawing.Font("宋体", 15F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(1018, 16634);
            this.MinimumSize = new System.Drawing.Size(1018, 696);
            this.Name = "KeySetting";
            this.Text = "快捷键设置";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.KeySetting_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.shortcutGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button LoadLive2D;
        private System.Windows.Forms.Button clearAll;
        private System.Windows.Forms.Button AddShortcut;
        private System.Windows.Forms.DataGridView shortcutGrid;
        private System.Windows.Forms.Button DeleteShortcut;
    }
}