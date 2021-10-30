
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
            this.shortcutGrid = new System.Windows.Forms.DataGridView();
            this.LoadLive2D = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.shortcutGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // shortcutGrid
            // 
            this.shortcutGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shortcutGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.shortcutGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shortcutGrid.Location = new System.Drawing.Point(81, 40);
            this.shortcutGrid.Name = "shortcutGrid";
            this.shortcutGrid.RowHeadersWidth = 51;
            this.shortcutGrid.RowTemplate.Height = 27;
            this.shortcutGrid.Size = new System.Drawing.Size(671, 316);
            this.shortcutGrid.TabIndex = 0;
            this.shortcutGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // LoadLive2D
            // 
            this.LoadLive2D.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LoadLive2D.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LoadLive2D.Location = new System.Drawing.Point(81, 394);
            this.LoadLive2D.Name = "LoadLive2D";
            this.LoadLive2D.Size = new System.Drawing.Size(140, 51);
            this.LoadLive2D.TabIndex = 1;
            this.LoadLive2D.Text = "Live2D";
            this.LoadLive2D.UseVisualStyleBackColor = true;
            this.LoadLive2D.Click += new System.EventHandler(this.LoadLive2D_Click);
            // 
            // KeySetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 457);
            this.Controls.Add(this.LoadLive2D);
            this.Controls.Add(this.shortcutGrid);
            this.Name = "KeySetting";
            this.Text = "KeySetting";
            ((System.ComponentModel.ISupportInitialize)(this.shortcutGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView shortcutGrid;
        private System.Windows.Forms.Button LoadLive2D;
    }
}