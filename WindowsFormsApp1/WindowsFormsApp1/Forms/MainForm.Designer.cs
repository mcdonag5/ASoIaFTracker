namespace WindowsFormsApp1
{
    partial class FormMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.dgHouseDetails = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.devLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsddViewHouse = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsbPlayerNPC = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbPlayerRoss = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbAllHouses = new System.Windows.Forms.ToolStripButton();
            this.tsbPlayerKyle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbCreateHouse = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgHouseDetails)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgHouseDetails
            // 
            this.dgHouseDetails.AllowUserToAddRows = false;
            this.dgHouseDetails.AllowUserToDeleteRows = false;
            this.dgHouseDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgHouseDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgHouseDetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgHouseDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgHouseDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgHouseDetails.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgHouseDetails.Location = new System.Drawing.Point(0, 25);
            this.dgHouseDetails.Name = "dgHouseDetails";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgHouseDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgHouseDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgHouseDetails.Size = new System.Drawing.Size(1371, 604);
            this.dgHouseDetails.TabIndex = 13;
            this.dgHouseDetails.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgHouseDetails_CellMouseDoubleClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenu,
            this.tsbAllHouses,
            this.tsddViewHouse,
            this.tsbCreateHouse});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1371, 25);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsMenu
            // 
            this.tsMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.devLogToolStripMenuItem});
            this.tsMenu.Image = ((System.Drawing.Image)(resources.GetObject("tsMenu.Image")));
            this.tsMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(51, 22);
            this.tsMenu.Text = "Menu";
            // 
            // devLogToolStripMenuItem
            // 
            this.devLogToolStripMenuItem.Name = "devLogToolStripMenuItem";
            this.devLogToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.devLogToolStripMenuItem.Text = "DevLog";
            this.devLogToolStripMenuItem.Click += new System.EventHandler(this.TsbMenuDevLog);
            // 
            // tsddViewHouse
            // 
            this.tsddViewHouse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsddViewHouse.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbPlayerNPC,
            this.tsbPlayerRoss,
            this.tsbPlayerKyle});
            this.tsddViewHouse.Image = ((System.Drawing.Image)(resources.GetObject("tsddViewHouse.Image")));
            this.tsddViewHouse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddViewHouse.Name = "tsddViewHouse";
            this.tsddViewHouse.Size = new System.Drawing.Size(52, 22);
            this.tsddViewHouse.Text = "Player";
            // 
            // tsbPlayerNPC
            // 
            this.tsbPlayerNPC.Name = "tsbPlayerNPC";
            this.tsbPlayerNPC.Size = new System.Drawing.Size(180, 22);
            this.tsbPlayerNPC.Text = "NPC";
            this.tsbPlayerNPC.Click += new System.EventHandler(this.AllHousesToolStripMenuItem_Click);
            // 
            // tsbPlayerRoss
            // 
            this.tsbPlayerRoss.Name = "tsbPlayerRoss";
            this.tsbPlayerRoss.Size = new System.Drawing.Size(180, 22);
            this.tsbPlayerRoss.Text = "Ross";
            this.tsbPlayerRoss.Click += new System.EventHandler(this.PlayersToolStripMenuItem_Click);
            // 
            // tsbAllHouses
            // 
            this.tsbAllHouses.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbAllHouses.Image = ((System.Drawing.Image)(resources.GetObject("tsbAllHouses.Image")));
            this.tsbAllHouses.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAllHouses.Name = "tsbAllHouses";
            this.tsbAllHouses.Size = new System.Drawing.Size(62, 22);
            this.tsbAllHouses.Text = "All House";
            this.tsbAllHouses.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // tsbPlayerKyle
            // 
            this.tsbPlayerKyle.Name = "tsbPlayerKyle";
            this.tsbPlayerKyle.Size = new System.Drawing.Size(180, 22);
            this.tsbPlayerKyle.Text = "Kyle";
            this.tsbPlayerKyle.Click += new System.EventHandler(this.KyleToolStripMenuItem_Click);
            // 
            // tsbCreateHouse
            // 
            this.tsbCreateHouse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbCreateHouse.Image = ((System.Drawing.Image)(resources.GetObject("tsbCreateHouse.Image")));
            this.tsbCreateHouse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCreateHouse.Name = "tsbCreateHouse";
            this.tsbCreateHouse.Size = new System.Drawing.Size(82, 22);
            this.tsbCreateHouse.Text = "Create House";
            this.tsbCreateHouse.Click += new System.EventHandler(this.TsbCreateHouse_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1371, 632);
            this.Controls.Add(this.dgHouseDetails);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ASoIaF Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgHouseDetails)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgHouseDetails;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton tsMenu;
        private System.Windows.Forms.ToolStripMenuItem devLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton tsddViewHouse;
        private System.Windows.Forms.ToolStripMenuItem tsbPlayerNPC;
        private System.Windows.Forms.ToolStripMenuItem tsbPlayerRoss;
        private System.Windows.Forms.ToolStripMenuItem tsbPlayerKyle;
        private System.Windows.Forms.ToolStripButton tsbAllHouses;
        private System.Windows.Forms.ToolStripButton tsbCreateHouse;
    }
}

