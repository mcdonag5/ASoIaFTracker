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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.dgHouseDetails = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.devLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbseeTestHouses = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmQryHelper = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbAllHouses = new System.Windows.Forms.ToolStripButton();
            this.tsddViewHouse = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsbPlayerNPC = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbPlayerRoss = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbPlayerKyle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbCreateHouse = new System.Windows.Forms.ToolStripButton();
            this.tsbViewHouse = new System.Windows.Forms.ToolStripButton();
            this.tsbDeleteHouse = new System.Windows.Forms.ToolStripButton();
            this.tsbCreateNewHolding = new System.Windows.Forms.ToolStripDropDownButton();
            this.wealthHoldingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wealthImprovemntToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.influnceHoldingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.influnceImprovemntToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unitTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgHouseDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgHouseDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgHouseDetails.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgHouseDetails.Location = new System.Drawing.Point(0, 25);
            this.dgHouseDetails.Name = "dgHouseDetails";
            this.dgHouseDetails.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgHouseDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
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
            this.tsbCreateHouse,
            this.tsbViewHouse,
            this.tsbDeleteHouse,
            this.tsbCreateNewHolding});
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
            this.devLogToolStripMenuItem,
            this.tsbseeTestHouses,
            this.tsmQryHelper});
            this.tsMenu.Image = ((System.Drawing.Image)(resources.GetObject("tsMenu.Image")));
            this.tsMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsMenu.Size = new System.Drawing.Size(61, 22);
            this.tsMenu.Text = "Menu";
            // 
            // devLogToolStripMenuItem
            // 
            this.devLogToolStripMenuItem.Name = "devLogToolStripMenuItem";
            this.devLogToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.devLogToolStripMenuItem.Text = "DevLog";
            this.devLogToolStripMenuItem.Click += new System.EventHandler(this.TsbMenuDevLog_Click);
            // 
            // tsbseeTestHouses
            // 
            this.tsbseeTestHouses.Name = "tsbseeTestHouses";
            this.tsbseeTestHouses.Size = new System.Drawing.Size(158, 22);
            this.tsbseeTestHouses.Text = "See Test Houses";
            this.tsbseeTestHouses.Click += new System.EventHandler(this.TsbseeTestHouses_Click);
            // 
            // tsmQryHelper
            // 
            this.tsmQryHelper.Name = "tsmQryHelper";
            this.tsmQryHelper.Size = new System.Drawing.Size(158, 22);
            this.tsmQryHelper.Text = "Qry Helper";
            this.tsmQryHelper.Click += new System.EventHandler(this.GetQryNumberToolStripMenuItem_Click);
            // 
            // tsbAllHouses
            // 
            this.tsbAllHouses.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbAllHouses.Image = ((System.Drawing.Image)(resources.GetObject("tsbAllHouses.Image")));
            this.tsbAllHouses.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAllHouses.Name = "tsbAllHouses";
            this.tsbAllHouses.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbAllHouses.Size = new System.Drawing.Size(72, 22);
            this.tsbAllHouses.Text = "All House";
            this.tsbAllHouses.Click += new System.EventHandler(this.TsbAllHouses_Click);
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
            this.tsddViewHouse.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsddViewHouse.Size = new System.Drawing.Size(62, 22);
            this.tsddViewHouse.Text = "Player";
            // 
            // tsbPlayerNPC
            // 
            this.tsbPlayerNPC.Name = "tsbPlayerNPC";
            this.tsbPlayerNPC.Size = new System.Drawing.Size(98, 22);
            this.tsbPlayerNPC.Text = "NPC";
            this.tsbPlayerNPC.Click += new System.EventHandler(this.PlayersToolStripMenuItem_Click);
            // 
            // tsbPlayerRoss
            // 
            this.tsbPlayerRoss.Name = "tsbPlayerRoss";
            this.tsbPlayerRoss.Size = new System.Drawing.Size(98, 22);
            this.tsbPlayerRoss.Text = "Ross";
            this.tsbPlayerRoss.Click += new System.EventHandler(this.PlayersToolStripMenuItem_Click);
            // 
            // tsbPlayerKyle
            // 
            this.tsbPlayerKyle.Name = "tsbPlayerKyle";
            this.tsbPlayerKyle.Size = new System.Drawing.Size(98, 22);
            this.tsbPlayerKyle.Text = "Kyle";
            this.tsbPlayerKyle.Click += new System.EventHandler(this.PlayersToolStripMenuItem_Click);
            // 
            // tsbCreateHouse
            // 
            this.tsbCreateHouse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbCreateHouse.Image = ((System.Drawing.Image)(resources.GetObject("tsbCreateHouse.Image")));
            this.tsbCreateHouse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCreateHouse.Name = "tsbCreateHouse";
            this.tsbCreateHouse.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbCreateHouse.Size = new System.Drawing.Size(92, 22);
            this.tsbCreateHouse.Text = "Create House";
            this.tsbCreateHouse.Click += new System.EventHandler(this.TsbCreateHouse_Click);
            // 
            // tsbViewHouse
            // 
            this.tsbViewHouse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbViewHouse.Image = ((System.Drawing.Image)(resources.GetObject("tsbViewHouse.Image")));
            this.tsbViewHouse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbViewHouse.Name = "tsbViewHouse";
            this.tsbViewHouse.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbViewHouse.Size = new System.Drawing.Size(83, 22);
            this.tsbViewHouse.Text = "View House";
            this.tsbViewHouse.Click += new System.EventHandler(this.TsbViewHouse_Click);
            // 
            // tsbDeleteHouse
            // 
            this.tsbDeleteHouse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbDeleteHouse.Enabled = false;
            this.tsbDeleteHouse.Image = ((System.Drawing.Image)(resources.GetObject("tsbDeleteHouse.Image")));
            this.tsbDeleteHouse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeleteHouse.Name = "tsbDeleteHouse";
            this.tsbDeleteHouse.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbDeleteHouse.Size = new System.Drawing.Size(91, 22);
            this.tsbDeleteHouse.Text = "Delete House";
            this.tsbDeleteHouse.Click += new System.EventHandler(this.TsbDeleteHouse_Click);
            // 
            // tsbCreateNewHolding
            // 
            this.tsbCreateNewHolding.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbCreateNewHolding.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wealthHoldingToolStripMenuItem,
            this.wealthImprovemntToolStripMenuItem,
            this.influnceHoldingToolStripMenuItem,
            this.influnceImprovemntToolStripMenuItem,
            this.unitTypeToolStripMenuItem});
            this.tsbCreateNewHolding.Image = ((System.Drawing.Image)(resources.GetObject("tsbCreateNewHolding.Image")));
            this.tsbCreateNewHolding.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCreateNewHolding.Name = "tsbCreateNewHolding";
            this.tsbCreateNewHolding.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbCreateNewHolding.Size = new System.Drawing.Size(142, 22);
            this.tsbCreateNewHolding.Text = "Create New Holdings";
            // 
            // wealthHoldingToolStripMenuItem
            // 
            this.wealthHoldingToolStripMenuItem.Name = "wealthHoldingToolStripMenuItem";
            this.wealthHoldingToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.wealthHoldingToolStripMenuItem.Text = "Wealth Holding";
            this.wealthHoldingToolStripMenuItem.Click += new System.EventHandler(this.wealthHoldingToolStripMenuItem_Click);
            // 
            // wealthImprovemntToolStripMenuItem
            // 
            this.wealthImprovemntToolStripMenuItem.Name = "wealthImprovemntToolStripMenuItem";
            this.wealthImprovemntToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.wealthImprovemntToolStripMenuItem.Text = "Wealth Improvemnt";
            // 
            // influnceHoldingToolStripMenuItem
            // 
            this.influnceHoldingToolStripMenuItem.Name = "influnceHoldingToolStripMenuItem";
            this.influnceHoldingToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.influnceHoldingToolStripMenuItem.Text = "Influnce Holding";
            // 
            // influnceImprovemntToolStripMenuItem
            // 
            this.influnceImprovemntToolStripMenuItem.Name = "influnceImprovemntToolStripMenuItem";
            this.influnceImprovemntToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.influnceImprovemntToolStripMenuItem.Text = "Influnce Improvemnt";
            // 
            // unitTypeToolStripMenuItem
            // 
            this.unitTypeToolStripMenuItem.Name = "unitTypeToolStripMenuItem";
            this.unitTypeToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.unitTypeToolStripMenuItem.Text = "Unit Type";
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
        private System.Windows.Forms.ToolStripMenuItem tsbseeTestHouses;
        private System.Windows.Forms.ToolStripButton tsbViewHouse;
        private System.Windows.Forms.ToolStripButton tsbDeleteHouse;
        private System.Windows.Forms.ToolStripMenuItem tsmQryHelper;
        private System.Windows.Forms.ToolStripDropDownButton tsbCreateNewHolding;
        private System.Windows.Forms.ToolStripMenuItem wealthHoldingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wealthImprovemntToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem influnceHoldingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem influnceImprovemntToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unitTypeToolStripMenuItem;
    }
}

