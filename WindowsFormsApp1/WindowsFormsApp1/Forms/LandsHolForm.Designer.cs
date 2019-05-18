namespace WindowsFormsApp1
{
    partial class LandsHolForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LandsHolForm));
            this.lbTypeName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbWealthHolding = new System.Windows.Forms.ComboBox();
            this.cbLandHolding = new System.Windows.Forms.ComboBox();
            this.cbDefLanFea = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbImprovemnt = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbCost = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.chbBuilt = new System.Windows.Forms.CheckBox();
            this.lbDesc = new System.Windows.Forms.Label();
            this.lbBenfits = new System.Windows.Forms.Label();
            this.rtbNotes = new System.Windows.Forms.RichTextBox();
            this.lbAddions = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.dgDef = new System.Windows.Forms.DataGridView();
            this.dgLandFea = new System.Windows.Forms.DataGridView();
            this.dgLand = new System.Windows.Forms.DataGridView();
            this.dgWea = new System.Windows.Forms.DataGridView();
            this.dgImp = new System.Windows.Forms.DataGridView();
            this.tsddbNew = new System.Windows.Forms.ToolStripDropDownButton();
            this.landHoldingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.landFeatureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defenseHoldingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wealthHoldingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wealthImprovementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbDeleteCurrent = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDef)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgLandFea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgLand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgWea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgImp)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTypeName
            // 
            this.lbTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTypeName.AutoSize = true;
            this.lbTypeName.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTypeName.Location = new System.Drawing.Point(3, 0);
            this.lbTypeName.Name = "lbTypeName";
            this.tableLayoutPanel3.SetRowSpan(this.lbTypeName, 2);
            this.lbTypeName.Size = new System.Drawing.Size(408, 64);
            this.lbTypeName.TabIndex = 0;
            this.lbTypeName.Text = "Maester - Maester Dasher";
            this.lbTypeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.cbWealthHolding, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbLandHolding, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbDefLanFea, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(617, 29);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // cbWealthHolding
            // 
            this.cbWealthHolding.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbWealthHolding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWealthHolding.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWealthHolding.FormattingEnabled = true;
            this.cbWealthHolding.Location = new System.Drawing.Point(413, 3);
            this.cbWealthHolding.Name = "cbWealthHolding";
            this.cbWealthHolding.Size = new System.Drawing.Size(201, 24);
            this.cbWealthHolding.TabIndex = 2;
            this.cbWealthHolding.SelectedIndexChanged += new System.EventHandler(this.CbWealthHolding_SelectedIndexChanged);
            // 
            // cbLandHolding
            // 
            this.cbLandHolding.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbLandHolding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLandHolding.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLandHolding.FormattingEnabled = true;
            this.cbLandHolding.Location = new System.Drawing.Point(3, 3);
            this.cbLandHolding.Name = "cbLandHolding";
            this.cbLandHolding.Size = new System.Drawing.Size(199, 24);
            this.cbLandHolding.TabIndex = 1;
            this.cbLandHolding.SelectedIndexChanged += new System.EventHandler(this.CbLandHolding_SelectedIndexChanged);
            // 
            // cbDefLanFea
            // 
            this.cbDefLanFea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDefLanFea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDefLanFea.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDefLanFea.FormattingEnabled = true;
            this.cbDefLanFea.Location = new System.Drawing.Point(208, 3);
            this.cbDefLanFea.Name = "cbDefLanFea";
            this.cbDefLanFea.Size = new System.Drawing.Size(199, 24);
            this.cbDefLanFea.TabIndex = 0;
            this.cbDefLanFea.SelectedIndexChanged += new System.EventHandler(this.CbDefLanFea_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.lbImprovemnt, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbDesc, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbBenfits, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.rtbNotes, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.lbAddions, 0, 6);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 28);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(623, 555);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // lbImprovemnt
            // 
            this.lbImprovemnt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbImprovemnt.AutoSize = true;
            this.lbImprovemnt.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImprovemnt.Location = new System.Drawing.Point(3, 195);
            this.lbImprovemnt.Name = "lbImprovemnt";
            this.lbImprovemnt.Size = new System.Drawing.Size(617, 18);
            this.lbImprovemnt.TabIndex = 7;
            this.lbImprovemnt.Text = "fnxfnfsgnbfgxnfgnfghsnsfnfgnsfgnsfgns";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.tbName, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.lbCost, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbType, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.lbTypeName, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.chbBuilt, 1, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 38);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(617, 100);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(3, 67);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(408, 31);
            this.tbName.TabIndex = 3;
            // 
            // lbCost
            // 
            this.lbCost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCost.AutoSize = true;
            this.lbCost.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCost.Location = new System.Drawing.Point(417, 0);
            this.lbCost.Name = "lbCost";
            this.lbCost.Size = new System.Drawing.Size(197, 36);
            this.lbCost.TabIndex = 1;
            this.lbCost.Text = "Cost: 10 Wealth, 5 Defense";
            this.lbCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbType
            // 
            this.lbType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbType.AutoSize = true;
            this.lbType.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbType.Location = new System.Drawing.Point(417, 64);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(197, 36);
            this.lbType.TabIndex = 2;
            this.lbType.Text = "Personage";
            this.lbType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chbBuilt
            // 
            this.chbBuilt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chbBuilt.AutoSize = true;
            this.chbBuilt.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbBuilt.Location = new System.Drawing.Point(417, 39);
            this.chbBuilt.Name = "chbBuilt";
            this.chbBuilt.Padding = new System.Windows.Forms.Padding(60, 0, 60, 0);
            this.chbBuilt.Size = new System.Drawing.Size(197, 22);
            this.chbBuilt.TabIndex = 4;
            this.chbBuilt.Text = "Built";
            this.chbBuilt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chbBuilt.UseVisualStyleBackColor = true;
            // 
            // lbDesc
            // 
            this.lbDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDesc.AutoSize = true;
            this.lbDesc.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDesc.Location = new System.Drawing.Point(3, 141);
            this.lbDesc.Name = "lbDesc";
            this.lbDesc.Size = new System.Drawing.Size(617, 18);
            this.lbDesc.TabIndex = 2;
            this.lbDesc.Text = "fnxfnfsgnbfgxnfgnfghsnsfnfgnsfgnsfgns";
            // 
            // lbBenfits
            // 
            this.lbBenfits.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBenfits.AutoSize = true;
            this.lbBenfits.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBenfits.Location = new System.Drawing.Point(3, 159);
            this.lbBenfits.Name = "lbBenfits";
            this.lbBenfits.Size = new System.Drawing.Size(617, 18);
            this.lbBenfits.TabIndex = 3;
            this.lbBenfits.Text = "fnxfnfsgnbfgxnfgnfghsnsfnfgnsfgnsfgns";
            // 
            // rtbNotes
            // 
            this.rtbNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbNotes.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbNotes.Location = new System.Drawing.Point(3, 216);
            this.rtbNotes.Name = "rtbNotes";
            this.rtbNotes.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbNotes.Size = new System.Drawing.Size(617, 336);
            this.rtbNotes.TabIndex = 5;
            this.rtbNotes.Text = "";
            // 
            // lbAddions
            // 
            this.lbAddions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAddions.AutoSize = true;
            this.lbAddions.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddions.Location = new System.Drawing.Point(3, 177);
            this.lbAddions.Name = "lbAddions";
            this.lbAddions.Size = new System.Drawing.Size(617, 18);
            this.lbAddions.TabIndex = 4;
            this.lbAddions.Text = "fnxfnfsgnbfgxnfgnfghsnsfnfgnsfgnsfgns";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsddbNew,
            this.tsbDeleteCurrent});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(647, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // dgDef
            // 
            this.dgDef.AllowUserToAddRows = false;
            this.dgDef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDef.Location = new System.Drawing.Point(304, 310);
            this.dgDef.Name = "dgDef";
            this.dgDef.Size = new System.Drawing.Size(206, 148);
            this.dgDef.TabIndex = 35;
            this.dgDef.Visible = false;
            // 
            // dgLandFea
            // 
            this.dgLandFea.AllowUserToAddRows = false;
            this.dgLandFea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLandFea.Location = new System.Drawing.Point(304, 284);
            this.dgLandFea.Name = "dgLandFea";
            this.dgLandFea.Size = new System.Drawing.Size(38, 32);
            this.dgLandFea.TabIndex = 34;
            this.dgLandFea.Visible = false;
            // 
            // dgLand
            // 
            this.dgLand.AllowUserToAddRows = false;
            this.dgLand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLand.Location = new System.Drawing.Point(304, 252);
            this.dgLand.Name = "dgLand";
            this.dgLand.Size = new System.Drawing.Size(38, 32);
            this.dgLand.TabIndex = 33;
            this.dgLand.Visible = false;
            // 
            // dgWea
            // 
            this.dgWea.AllowUserToAddRows = false;
            this.dgWea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgWea.Location = new System.Drawing.Point(304, 281);
            this.dgWea.Name = "dgWea";
            this.dgWea.Size = new System.Drawing.Size(38, 32);
            this.dgWea.TabIndex = 36;
            this.dgWea.Visible = false;
            // 
            // dgImp
            // 
            this.dgImp.AllowUserToAddRows = false;
            this.dgImp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgImp.Location = new System.Drawing.Point(312, 289);
            this.dgImp.Name = "dgImp";
            this.dgImp.Size = new System.Drawing.Size(38, 32);
            this.dgImp.TabIndex = 37;
            this.dgImp.Visible = false;
            // 
            // tsddbNew
            // 
            this.tsddbNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsddbNew.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.landHoldingToolStripMenuItem,
            this.landFeatureToolStripMenuItem,
            this.defenseHoldingToolStripMenuItem,
            this.wealthHoldingToolStripMenuItem,
            this.wealthImprovementToolStripMenuItem});
            this.tsddbNew.Image = ((System.Drawing.Image)(resources.GetObject("tsddbNew.Image")));
            this.tsddbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbNew.Name = "tsddbNew";
            this.tsddbNew.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsddbNew.Size = new System.Drawing.Size(54, 22);
            this.tsddbNew.Text = "New";
            // 
            // landHoldingToolStripMenuItem
            // 
            this.landHoldingToolStripMenuItem.Name = "landHoldingToolStripMenuItem";
            this.landHoldingToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.landHoldingToolStripMenuItem.Text = "Land Holding";
            this.landHoldingToolStripMenuItem.Click += new System.EventHandler(this.LandHoldingToolStripMenuItem_Click);
            // 
            // landFeatureToolStripMenuItem
            // 
            this.landFeatureToolStripMenuItem.Enabled = false;
            this.landFeatureToolStripMenuItem.Name = "landFeatureToolStripMenuItem";
            this.landFeatureToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.landFeatureToolStripMenuItem.Text = "Land Feature";
            this.landFeatureToolStripMenuItem.Click += new System.EventHandler(this.LandFeatureToolStripMenuItem_Click);
            // 
            // defenseHoldingToolStripMenuItem
            // 
            this.defenseHoldingToolStripMenuItem.Enabled = false;
            this.defenseHoldingToolStripMenuItem.Name = "defenseHoldingToolStripMenuItem";
            this.defenseHoldingToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.defenseHoldingToolStripMenuItem.Text = "Defense Holding";
            this.defenseHoldingToolStripMenuItem.Click += new System.EventHandler(this.DefenseHoldingToolStripMenuItem_Click);
            // 
            // wealthHoldingToolStripMenuItem
            // 
            this.wealthHoldingToolStripMenuItem.Enabled = false;
            this.wealthHoldingToolStripMenuItem.Name = "wealthHoldingToolStripMenuItem";
            this.wealthHoldingToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.wealthHoldingToolStripMenuItem.Text = "Wealth Holding";
            this.wealthHoldingToolStripMenuItem.Click += new System.EventHandler(this.WealthHoldingToolStripMenuItem_Click);
            // 
            // wealthImprovementToolStripMenuItem
            // 
            this.wealthImprovementToolStripMenuItem.Enabled = false;
            this.wealthImprovementToolStripMenuItem.Name = "wealthImprovementToolStripMenuItem";
            this.wealthImprovementToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.wealthImprovementToolStripMenuItem.Text = "Wealth Improvement";
            this.wealthImprovementToolStripMenuItem.Click += new System.EventHandler(this.WealthImprovementToolStripMenuItem_Click);
            // 
            // tsbDeleteCurrent
            // 
            this.tsbDeleteCurrent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbDeleteCurrent.Image = ((System.Drawing.Image)(resources.GetObject("tsbDeleteCurrent.Image")));
            this.tsbDeleteCurrent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeleteCurrent.Name = "tsbDeleteCurrent";
            this.tsbDeleteCurrent.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbDeleteCurrent.Size = new System.Drawing.Size(97, 22);
            this.tsbDeleteCurrent.Text = "Delete Current";
            // 
            // LandsHolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(647, 595);
            this.Controls.Add(this.dgImp);
            this.Controls.Add(this.dgWea);
            this.Controls.Add(this.dgDef);
            this.Controls.Add(this.dgLandFea);
            this.Controls.Add(this.dgLand);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "LandsHolForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LandsHolForm_FormClosing);
            this.Load += new System.EventHandler(this.LandsHolForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDef)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgLandFea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgLand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgWea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgImp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTypeName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ComboBox cbWealthHolding;
        private System.Windows.Forms.ComboBox cbLandHolding;
        private System.Windows.Forms.ComboBox cbDefLanFea;
        private System.Windows.Forms.Label lbBenfits;
        private System.Windows.Forms.Label lbDesc;
        private System.Windows.Forms.Label lbAddions;
        private System.Windows.Forms.RichTextBox rtbNotes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lbCost;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.DataGridView dgDef;
        private System.Windows.Forms.DataGridView dgLandFea;
        private System.Windows.Forms.DataGridView dgLand;
        private System.Windows.Forms.Label lbImprovemnt;
        private System.Windows.Forms.DataGridView dgWea;
        private System.Windows.Forms.DataGridView dgImp;
        private System.Windows.Forms.ToolStripDropDownButton tsddbNew;
        private System.Windows.Forms.ToolStripMenuItem landHoldingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem landFeatureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defenseHoldingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wealthHoldingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wealthImprovementToolStripMenuItem;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ToolStripButton tsbDeleteCurrent;
        private System.Windows.Forms.CheckBox chbBuilt;
    }
}