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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.dgHouseDetails = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.devLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmQryHelper = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmmLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbCreateHouse = new System.Windows.Forms.ToolStripButton();
            this.tsbViewHouse = new System.Windows.Forms.ToolStripButton();
            this.tsbDeleteHouse = new System.Windows.Forms.ToolStripButton();
            this.tsbViewHoldings = new System.Windows.Forms.ToolStripButton();
            this.tsbCreateNewHolding = new System.Windows.Forms.ToolStripDropDownButton();
            this.wealthHoldingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wealthImprovemntToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.influnceHoldingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.influnceImprovemntToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defenseHoldingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unitTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panLogIn = new System.Windows.Forms.Panel();
            this.btLogIn = new System.Windows.Forms.Button();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgHouseDetails)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panLogIn.SuspendLayout();
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgHouseDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgHouseDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgHouseDetails.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgHouseDetails.Location = new System.Drawing.Point(0, 25);
            this.dgHouseDetails.Name = "dgHouseDetails";
            this.dgHouseDetails.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgHouseDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
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
            this.tsbCreateHouse,
            this.tsbViewHouse,
            this.tsbDeleteHouse,
            this.tsbViewHoldings,
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
            this.tsmQryHelper,
            this.tsmChangePassword,
            this.tsmmLogout});
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
            this.devLogToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.devLogToolStripMenuItem.Text = "DevLog";
            this.devLogToolStripMenuItem.Click += new System.EventHandler(this.TsbMenuDevLog_Click);
            // 
            // tsmQryHelper
            // 
            this.tsmQryHelper.Enabled = false;
            this.tsmQryHelper.Name = "tsmQryHelper";
            this.tsmQryHelper.Size = new System.Drawing.Size(168, 22);
            this.tsmQryHelper.Text = "Qry Helper";
            this.tsmQryHelper.Click += new System.EventHandler(this.GetQryNumberToolStripMenuItem_Click);
            // 
            // tsmChangePassword
            // 
            this.tsmChangePassword.Enabled = false;
            this.tsmChangePassword.Name = "tsmChangePassword";
            this.tsmChangePassword.Size = new System.Drawing.Size(168, 22);
            this.tsmChangePassword.Text = "Change Password";
            this.tsmChangePassword.Click += new System.EventHandler(this.tsmChangePassword_Click);
            // 
            // tsmmLogout
            // 
            this.tsmmLogout.Enabled = false;
            this.tsmmLogout.Name = "tsmmLogout";
            this.tsmmLogout.Size = new System.Drawing.Size(168, 22);
            this.tsmmLogout.Text = "Logout";
            this.tsmmLogout.Click += new System.EventHandler(this.TsmmLogout_Click);
            // 
            // tsbCreateHouse
            // 
            this.tsbCreateHouse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbCreateHouse.Enabled = false;
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
            this.tsbViewHouse.Enabled = false;
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
            // tsbViewHoldings
            // 
            this.tsbViewHoldings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbViewHoldings.Enabled = false;
            this.tsbViewHoldings.Image = ((System.Drawing.Image)(resources.GetObject("tsbViewHoldings.Image")));
            this.tsbViewHoldings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbViewHoldings.Name = "tsbViewHoldings";
            this.tsbViewHoldings.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbViewHoldings.Size = new System.Drawing.Size(97, 22);
            this.tsbViewHoldings.Text = "View Holdings";
            this.tsbViewHoldings.Click += new System.EventHandler(this.TsbViewHoldings_Click);
            // 
            // tsbCreateNewHolding
            // 
            this.tsbCreateNewHolding.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbCreateNewHolding.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wealthHoldingToolStripMenuItem,
            this.wealthImprovemntToolStripMenuItem,
            this.influnceHoldingToolStripMenuItem,
            this.influnceImprovemntToolStripMenuItem,
            this.defenseHoldingToolStripMenuItem,
            this.unitTypeToolStripMenuItem});
            this.tsbCreateNewHolding.Enabled = false;
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
            this.wealthHoldingToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.wealthHoldingToolStripMenuItem.Text = "Wealth Holding";
            this.wealthHoldingToolStripMenuItem.Click += new System.EventHandler(this.WealthHoldingToolStripMenuItem_Click);
            // 
            // wealthImprovemntToolStripMenuItem
            // 
            this.wealthImprovemntToolStripMenuItem.Name = "wealthImprovemntToolStripMenuItem";
            this.wealthImprovemntToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.wealthImprovemntToolStripMenuItem.Text = "Wealth Improvment";
            this.wealthImprovemntToolStripMenuItem.Click += new System.EventHandler(this.WealthImprovemntToolStripMenuItem_Click);
            // 
            // influnceHoldingToolStripMenuItem
            // 
            this.influnceHoldingToolStripMenuItem.Name = "influnceHoldingToolStripMenuItem";
            this.influnceHoldingToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.influnceHoldingToolStripMenuItem.Text = "Influence Holding";
            this.influnceHoldingToolStripMenuItem.Click += new System.EventHandler(this.InflunceHoldingToolStripMenuItem_Click);
            // 
            // influnceImprovemntToolStripMenuItem
            // 
            this.influnceImprovemntToolStripMenuItem.Name = "influnceImprovemntToolStripMenuItem";
            this.influnceImprovemntToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.influnceImprovemntToolStripMenuItem.Text = "Influence Improvment";
            this.influnceImprovemntToolStripMenuItem.Click += new System.EventHandler(this.InflunceImprovemntToolStripMenuItem_Click);
            // 
            // defenseHoldingToolStripMenuItem
            // 
            this.defenseHoldingToolStripMenuItem.Name = "defenseHoldingToolStripMenuItem";
            this.defenseHoldingToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.defenseHoldingToolStripMenuItem.Text = "Defense Holding";
            this.defenseHoldingToolStripMenuItem.Click += new System.EventHandler(this.DefenseHoldingToolStripMenuItem_Click);
            // 
            // unitTypeToolStripMenuItem
            // 
            this.unitTypeToolStripMenuItem.Name = "unitTypeToolStripMenuItem";
            this.unitTypeToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.unitTypeToolStripMenuItem.Text = "Unit Type";
            this.unitTypeToolStripMenuItem.Click += new System.EventHandler(this.UnitTypeToolStripMenuItem_Click);
            // 
            // panLogIn
            // 
            this.panLogIn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panLogIn.Controls.Add(this.btLogIn);
            this.panLogIn.Controls.Add(this.lbPassword);
            this.panLogIn.Controls.Add(this.tbPassword);
            this.panLogIn.Controls.Add(this.tbUsername);
            this.panLogIn.Controls.Add(this.lbUsername);
            this.panLogIn.Location = new System.Drawing.Point(0, 25);
            this.panLogIn.Name = "panLogIn";
            this.panLogIn.Size = new System.Drawing.Size(1371, 604);
            this.panLogIn.TabIndex = 16;
            // 
            // btLogIn
            // 
            this.btLogIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btLogIn.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogIn.Location = new System.Drawing.Point(823, 361);
            this.btLogIn.Name = "btLogIn";
            this.btLogIn.Size = new System.Drawing.Size(64, 30);
            this.btLogIn.TabIndex = 91;
            this.btLogIn.Text = "LogIn";
            this.btLogIn.UseVisualStyleBackColor = true;
            this.btLogIn.Click += new System.EventHandler(this.BtLogIn_Click);
            // 
            // lbPassword
            // 
            this.lbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.Location = new System.Drawing.Point(412, 328);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(108, 25);
            this.lbPassword.TabIndex = 90;
            this.lbPassword.Text = "Password:";
            this.lbPassword.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPassword.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(526, 326);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '•';
            this.tbPassword.Size = new System.Drawing.Size(361, 29);
            this.tbPassword.TabIndex = 89;
            this.tbPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPassword_KeyDown);
            // 
            // tbUsername
            // 
            this.tbUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUsername.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.Location = new System.Drawing.Point(526, 291);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(361, 29);
            this.tbUsername.TabIndex = 88;
            // 
            // lbUsername
            // 
            this.lbUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(405, 293);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(115, 25);
            this.lbUsername.TabIndex = 87;
            this.lbUsername.Text = "Username:";
            this.lbUsername.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1371, 632);
            this.Controls.Add(this.panLogIn);
            this.Controls.Add(this.dgHouseDetails);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ASoIaF Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgHouseDetails)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panLogIn.ResumeLayout(false);
            this.panLogIn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgHouseDetails;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton tsMenu;
        private System.Windows.Forms.ToolStripMenuItem devLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsbCreateHouse;
        private System.Windows.Forms.ToolStripButton tsbViewHouse;
        private System.Windows.Forms.ToolStripButton tsbDeleteHouse;
        private System.Windows.Forms.ToolStripMenuItem tsmQryHelper;
        private System.Windows.Forms.ToolStripDropDownButton tsbCreateNewHolding;
        private System.Windows.Forms.ToolStripMenuItem wealthHoldingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wealthImprovemntToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem influnceHoldingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem influnceImprovemntToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unitTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defenseHoldingToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsbViewHoldings;
        private System.Windows.Forms.Panel panLogIn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Button btLogIn;
        private System.Windows.Forms.ToolStripMenuItem tsmChangePassword;
        private System.Windows.Forms.ToolStripMenuItem tsmmLogout;
    }
}

