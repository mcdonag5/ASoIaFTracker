namespace WindowsFormsApp1.Forms
{
    partial class BannersHoldingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BannersHoldingsForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNewBanner = new System.Windows.Forms.ToolStripButton();
            this.tsbViewBanner = new System.Windows.Forms.ToolStripButton();
            this.tsbDeleteBanner = new System.Windows.Forms.ToolStripButton();
            this.dgBanners = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBanners)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNewBanner,
            this.tsbViewBanner,
            this.tsbDeleteBanner});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1371, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbNewBanner
            // 
            this.tsbNewBanner.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbNewBanner.Image = ((System.Drawing.Image)(resources.GetObject("tsbNewBanner.Image")));
            this.tsbNewBanner.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewBanner.Name = "tsbNewBanner";
            this.tsbNewBanner.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbNewBanner.Size = new System.Drawing.Size(177, 22);
            this.tsbNewBanner.Text = "Add Existing House as Banner";
            this.tsbNewBanner.Click += new System.EventHandler(this.tsbNewBanner_Click);
            // 
            // tsbViewBanner
            // 
            this.tsbViewBanner.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbViewBanner.Image = ((System.Drawing.Image)(resources.GetObject("tsbViewBanner.Image")));
            this.tsbViewBanner.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbViewBanner.Name = "tsbViewBanner";
            this.tsbViewBanner.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbViewBanner.Size = new System.Drawing.Size(86, 22);
            this.tsbViewBanner.Text = "View Banner";
            this.tsbViewBanner.Click += new System.EventHandler(this.tsbViewBanner_Click);
            // 
            // tsbDeleteBanner
            // 
            this.tsbDeleteBanner.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbDeleteBanner.Image = ((System.Drawing.Image)(resources.GetObject("tsbDeleteBanner.Image")));
            this.tsbDeleteBanner.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeleteBanner.Name = "tsbDeleteBanner";
            this.tsbDeleteBanner.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbDeleteBanner.Size = new System.Drawing.Size(104, 22);
            this.tsbDeleteBanner.Text = "Remove Banner";
            this.tsbDeleteBanner.Click += new System.EventHandler(this.tsbDeleteBanner_Click);
            // 
            // dgBanners
            // 
            this.dgBanners.AllowUserToAddRows = false;
            this.dgBanners.AllowUserToDeleteRows = false;
            this.dgBanners.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgBanners.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgBanners.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgBanners.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgBanners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgBanners.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgBanners.Location = new System.Drawing.Point(0, 28);
            this.dgBanners.Name = "dgBanners";
            this.dgBanners.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgBanners.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgBanners.Size = new System.Drawing.Size(1371, 604);
            this.dgBanners.TabIndex = 14;
            this.dgBanners.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgBanners_CellMouseDoubleClick);
            // 
            // BannersHoldingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 632);
            this.Controls.Add(this.dgBanners);
            this.Controls.Add(this.toolStrip1);
            this.Name = "BannersHoldingsForm";
            this.Text = "BannersHoldings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BannersHoldings_FormClosing);
            this.Load += new System.EventHandler(this.BannersHoldings_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBanners)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNewBanner;
        private System.Windows.Forms.DataGridView dgBanners;
        private System.Windows.Forms.ToolStripButton tsbDeleteBanner;
        private System.Windows.Forms.ToolStripButton tsbViewBanner;
    }
}