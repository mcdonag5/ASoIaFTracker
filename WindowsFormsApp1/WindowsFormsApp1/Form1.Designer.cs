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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.lbHouseName = new System.Windows.Forms.Label();
            this.lbHouseRealm = new System.Windows.Forms.Label();
            this.lbHouseSeatOfPower = new System.Windows.Forms.Label();
            this.lbHouseLiegeLord = new System.Windows.Forms.Label();
            this.lbHouseLiege = new System.Windows.Forms.Label();
            this.tbHouseName = new System.Windows.Forms.TextBox();
            this.tbHouseSeatOfPower = new System.Windows.Forms.TextBox();
            this.tbHouseLiege = new System.Windows.Forms.TextBox();
            this.cbHouseRealm = new System.Windows.Forms.ComboBox();
            this.tbHouseLiegeLord = new System.Windows.Forms.TextBox();
            this.lbHouseResources = new System.Windows.Forms.Label();
            this.lbHouseCurrent = new System.Windows.Forms.Label();
            this.lbHouseSpare = new System.Windows.Forms.Label();
            this.dgHouseDetails = new System.Windows.Forms.DataGridView();
            this.dgCal1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.devLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbHouseInfHol = new System.Windows.Forms.Label();
            this.lbHouInfHolList = new System.Windows.Forms.Label();
            this.lbHouseHF = new System.Windows.Forms.Label();
            this.lbHouseDefGain = new System.Windows.Forms.Label();
            this.lbHouseWeaGain = new System.Windows.Forms.Label();
            this.lbHousePowGain = new System.Windows.Forms.Label();
            this.lbHousePopGain = new System.Windows.Forms.Label();
            this.lbHouseLawGain = new System.Windows.Forms.Label();
            this.lbHouseLanGain = new System.Windows.Forms.Label();
            this.lbHouseInfGain = new System.Windows.Forms.Label();
            this.lbHouLanHol = new System.Windows.Forms.Label();
            this.lbHouLanHolList = new System.Windows.Forms.Label();
            this.dgCal2 = new System.Windows.Forms.DataGridView();
            this.dgCal3 = new System.Windows.Forms.DataGridView();
            this.lbHouseInfLoss = new System.Windows.Forms.Label();
            this.lbHouseLanLoss = new System.Windows.Forms.Label();
            this.lbHouseLawLoss = new System.Windows.Forms.Label();
            this.lbHousePopLoss = new System.Windows.Forms.Label();
            this.lbHousePowLoss = new System.Windows.Forms.Label();
            this.lbHouseWeaLoss = new System.Windows.Forms.Label();
            this.lbHouseDefLoss = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgHouseDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCal1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCal2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCal3)).BeginInit();
            this.SuspendLayout();
            // 
            // lbHouseName
            // 
            this.lbHouseName.AutoSize = true;
            this.lbHouseName.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHouseName.Location = new System.Drawing.Point(7, 48);
            this.lbHouseName.Name = "lbHouseName";
            this.lbHouseName.Size = new System.Drawing.Size(80, 25);
            this.lbHouseName.TabIndex = 0;
            this.lbHouseName.Text = "Name: ";
            // 
            // lbHouseRealm
            // 
            this.lbHouseRealm.AutoSize = true;
            this.lbHouseRealm.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHouseRealm.Location = new System.Drawing.Point(7, 85);
            this.lbHouseRealm.Name = "lbHouseRealm";
            this.lbHouseRealm.Size = new System.Drawing.Size(85, 25);
            this.lbHouseRealm.TabIndex = 1;
            this.lbHouseRealm.Text = "Realm: ";
            // 
            // lbHouseSeatOfPower
            // 
            this.lbHouseSeatOfPower.AutoSize = true;
            this.lbHouseSeatOfPower.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHouseSeatOfPower.Location = new System.Drawing.Point(407, 47);
            this.lbHouseSeatOfPower.Name = "lbHouseSeatOfPower";
            this.lbHouseSeatOfPower.Size = new System.Drawing.Size(150, 25);
            this.lbHouseSeatOfPower.TabIndex = 2;
            this.lbHouseSeatOfPower.Text = "Seat of Power: ";
            // 
            // lbHouseLiegeLord
            // 
            this.lbHouseLiegeLord.AutoSize = true;
            this.lbHouseLiegeLord.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHouseLiegeLord.Location = new System.Drawing.Point(288, 85);
            this.lbHouseLiegeLord.Name = "lbHouseLiegeLord";
            this.lbHouseLiegeLord.Size = new System.Drawing.Size(119, 25);
            this.lbHouseLiegeLord.TabIndex = 3;
            this.lbHouseLiegeLord.Text = "Liege Lord:";
            // 
            // lbHouseLiege
            // 
            this.lbHouseLiege.AutoSize = true;
            this.lbHouseLiege.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHouseLiege.Location = new System.Drawing.Point(595, 85);
            this.lbHouseLiege.Name = "lbHouseLiege";
            this.lbHouseLiege.Size = new System.Drawing.Size(69, 25);
            this.lbHouseLiege.TabIndex = 4;
            this.lbHouseLiege.Text = "Liege:";
            // 
            // tbHouseName
            // 
            this.tbHouseName.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHouseName.Location = new System.Drawing.Point(82, 44);
            this.tbHouseName.Name = "tbHouseName";
            this.tbHouseName.Size = new System.Drawing.Size(319, 29);
            this.tbHouseName.TabIndex = 5;
            // 
            // tbHouseSeatOfPower
            // 
            this.tbHouseSeatOfPower.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHouseSeatOfPower.Location = new System.Drawing.Point(549, 44);
            this.tbHouseSeatOfPower.Name = "tbHouseSeatOfPower";
            this.tbHouseSeatOfPower.Size = new System.Drawing.Size(341, 29);
            this.tbHouseSeatOfPower.TabIndex = 6;
            // 
            // tbHouseLiege
            // 
            this.tbHouseLiege.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHouseLiege.Location = new System.Drawing.Point(670, 85);
            this.tbHouseLiege.Name = "tbHouseLiege";
            this.tbHouseLiege.Size = new System.Drawing.Size(220, 29);
            this.tbHouseLiege.TabIndex = 7;
            // 
            // cbHouseRealm
            // 
            this.cbHouseRealm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHouseRealm.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHouseRealm.FormattingEnabled = true;
            this.cbHouseRealm.ImeMode = System.Windows.Forms.ImeMode.On;
            this.cbHouseRealm.Items.AddRange(new object[] {
            "King\'s Landing",
            "Dragonstone",
            "The North",
            "The Iron Islands",
            "The Riverlands",
            "The Mountains of the Moon",
            "The Westerlands",
            "The Reach",
            "The Stormlands",
            "Dorne"});
            this.cbHouseRealm.Location = new System.Drawing.Point(82, 83);
            this.cbHouseRealm.Name = "cbHouseRealm";
            this.cbHouseRealm.Size = new System.Drawing.Size(200, 31);
            this.cbHouseRealm.TabIndex = 8;
            // 
            // tbHouseLiegeLord
            // 
            this.tbHouseLiegeLord.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHouseLiegeLord.Location = new System.Drawing.Point(401, 85);
            this.tbHouseLiegeLord.Name = "tbHouseLiegeLord";
            this.tbHouseLiegeLord.Size = new System.Drawing.Size(188, 29);
            this.tbHouseLiegeLord.TabIndex = 9;
            // 
            // lbHouseResources
            // 
            this.lbHouseResources.AutoSize = true;
            this.lbHouseResources.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHouseResources.Location = new System.Drawing.Point(8, 171);
            this.lbHouseResources.Name = "lbHouseResources";
            this.lbHouseResources.Size = new System.Drawing.Size(109, 161);
            this.lbHouseResources.TabIndex = 10;
            this.lbHouseResources.Text = "Wealth:\r\nPower:\r\nPopulation:\r\nLaw:\r\nLands:\r\nInfluence:\r\nDefense:";
            this.lbHouseResources.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbHouseCurrent
            // 
            this.lbHouseCurrent.AutoSize = true;
            this.lbHouseCurrent.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHouseCurrent.Location = new System.Drawing.Point(123, 148);
            this.lbHouseCurrent.Name = "lbHouseCurrent";
            this.lbHouseCurrent.Size = new System.Drawing.Size(76, 184);
            this.lbHouseCurrent.TabIndex = 11;
            this.lbHouseCurrent.Text = "Current\r\n000\r\n000\r\n000\r\n000\r\n000\r\n000\r\n000";
            this.lbHouseCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbHouseSpare
            // 
            this.lbHouseSpare.AutoSize = true;
            this.lbHouseSpare.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHouseSpare.Location = new System.Drawing.Point(205, 148);
            this.lbHouseSpare.Name = "lbHouseSpare";
            this.lbHouseSpare.Size = new System.Drawing.Size(59, 184);
            this.lbHouseSpare.TabIndex = 12;
            this.lbHouseSpare.Text = "Spare\r\n000\r\n000\r\n000\r\n000\r\n000\r\n000\r\n000";
            this.lbHouseSpare.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgHouseDetails
            // 
            this.dgHouseDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHouseDetails.Location = new System.Drawing.Point(1114, 28);
            this.dgHouseDetails.Name = "dgHouseDetails";
            this.dgHouseDetails.Size = new System.Drawing.Size(240, 150);
            this.dgHouseDetails.TabIndex = 13;
            // 
            // dgCal1
            // 
            this.dgCal1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCal1.Location = new System.Drawing.Point(1114, 182);
            this.dgCal1.Name = "dgCal1";
            this.dgCal1.Size = new System.Drawing.Size(240, 150);
            this.dgCal1.TabIndex = 14;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenu});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1354, 25);
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
            this.devLogToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.devLogToolStripMenuItem.Text = "DevLog";
            this.devLogToolStripMenuItem.Click += new System.EventHandler(this.DevLogToolStripMenuItem_Click);
            // 
            // lbHouseInfHol
            // 
            this.lbHouseInfHol.AutoSize = true;
            this.lbHouseInfHol.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHouseInfHol.Location = new System.Drawing.Point(354, 332);
            this.lbHouseInfHol.Name = "lbHouseInfHol";
            this.lbHouseInfHol.Size = new System.Drawing.Size(169, 23);
            this.lbHouseInfHol.TabIndex = 16;
            this.lbHouseInfHol.Text = "Influence Holdings";
            this.lbHouseInfHol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbHouInfHolList
            // 
            this.lbHouInfHolList.AutoSize = true;
            this.lbHouInfHolList.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHouInfHolList.Location = new System.Drawing.Point(355, 355);
            this.lbHouInfHolList.Name = "lbHouInfHolList";
            this.lbHouInfHolList.Size = new System.Drawing.Size(139, 18);
            this.lbHouInfHolList.TabIndex = 17;
            this.lbHouInfHolList.Text = "Influence Holdings";
            // 
            // lbHouseHF
            // 
            this.lbHouseHF.AutoSize = true;
            this.lbHouseHF.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHouseHF.Location = new System.Drawing.Point(290, 171);
            this.lbHouseHF.Name = "lbHouseHF";
            this.lbHouseHF.Size = new System.Drawing.Size(36, 46);
            this.lbHouseHF.TabIndex = 18;
            this.lbHouseHF.Text = "HF\r\n0";
            this.lbHouseHF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbHouseDefGain
            // 
            this.lbHouseDefGain.AutoSize = true;
            this.lbHouseDefGain.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHouseDefGain.Location = new System.Drawing.Point(670, 171);
            this.lbHouseDefGain.Name = "lbHouseDefGain";
            this.lbHouseDefGain.Size = new System.Drawing.Size(47, 46);
            this.lbHouseDefGain.TabIndex = 19;
            this.lbHouseDefGain.Text = "DEF\r\n0";
            this.lbHouseDefGain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbHouseWeaGain
            // 
            this.lbHouseWeaGain.AutoSize = true;
            this.lbHouseWeaGain.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHouseWeaGain.Location = new System.Drawing.Point(332, 171);
            this.lbHouseWeaGain.Name = "lbHouseWeaGain";
            this.lbHouseWeaGain.Size = new System.Drawing.Size(54, 46);
            this.lbHouseWeaGain.TabIndex = 20;
            this.lbHouseWeaGain.Text = "WEA\r\n0";
            this.lbHouseWeaGain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbHousePowGain
            // 
            this.lbHousePowGain.AutoSize = true;
            this.lbHousePowGain.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHousePowGain.Location = new System.Drawing.Point(392, 171);
            this.lbHousePowGain.Name = "lbHousePowGain";
            this.lbHousePowGain.Size = new System.Drawing.Size(55, 46);
            this.lbHousePowGain.TabIndex = 21;
            this.lbHousePowGain.Text = "POW\r\n0";
            this.lbHousePowGain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbHousePopGain
            // 
            this.lbHousePopGain.AutoSize = true;
            this.lbHousePopGain.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHousePopGain.Location = new System.Drawing.Point(453, 171);
            this.lbHousePopGain.Name = "lbHousePopGain";
            this.lbHousePopGain.Size = new System.Drawing.Size(48, 46);
            this.lbHousePopGain.TabIndex = 22;
            this.lbHousePopGain.Text = "POP\r\n0";
            this.lbHousePopGain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbHouseLawGain
            // 
            this.lbHouseLawGain.AutoSize = true;
            this.lbHouseLawGain.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHouseLawGain.Location = new System.Drawing.Point(507, 171);
            this.lbHouseLawGain.Name = "lbHouseLawGain";
            this.lbHouseLawGain.Size = new System.Drawing.Size(53, 46);
            this.lbHouseLawGain.TabIndex = 23;
            this.lbHouseLawGain.Text = "LAW\r\n0";
            this.lbHouseLawGain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbHouseLanGain
            // 
            this.lbHouseLanGain.AutoSize = true;
            this.lbHouseLanGain.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHouseLanGain.Location = new System.Drawing.Point(566, 171);
            this.lbHouseLanGain.Name = "lbHouseLanGain";
            this.lbHouseLanGain.Size = new System.Drawing.Size(49, 46);
            this.lbHouseLanGain.TabIndex = 24;
            this.lbHouseLanGain.Text = "LAN\r\n0";
            this.lbHouseLanGain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbHouseInfGain
            // 
            this.lbHouseInfGain.AutoSize = true;
            this.lbHouseInfGain.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHouseInfGain.Location = new System.Drawing.Point(621, 171);
            this.lbHouseInfGain.Name = "lbHouseInfGain";
            this.lbHouseInfGain.Size = new System.Drawing.Size(43, 46);
            this.lbHouseInfGain.TabIndex = 25;
            this.lbHouseInfGain.Text = "INF\r\n0";
            this.lbHouseInfGain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbHouLanHol
            // 
            this.lbHouLanHol.AutoSize = true;
            this.lbHouLanHol.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHouLanHol.Location = new System.Drawing.Point(12, 332);
            this.lbHouLanHol.Name = "lbHouLanHol";
            this.lbHouLanHol.Size = new System.Drawing.Size(134, 23);
            this.lbHouLanHol.TabIndex = 26;
            this.lbHouLanHol.Text = "Land Holdings";
            this.lbHouLanHol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbHouLanHolList
            // 
            this.lbHouLanHolList.AutoSize = true;
            this.lbHouLanHolList.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHouLanHolList.Location = new System.Drawing.Point(13, 355);
            this.lbHouLanHolList.Name = "lbHouLanHolList";
            this.lbHouLanHolList.Size = new System.Drawing.Size(109, 18);
            this.lbHouLanHolList.TabIndex = 27;
            this.lbHouLanHolList.Text = "Land Holdings";
            // 
            // dgCal2
            // 
            this.dgCal2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCal2.Location = new System.Drawing.Point(1114, 332);
            this.dgCal2.Name = "dgCal2";
            this.dgCal2.Size = new System.Drawing.Size(240, 150);
            this.dgCal2.TabIndex = 28;
            // 
            // dgCal3
            // 
            this.dgCal3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCal3.Location = new System.Drawing.Point(1114, 488);
            this.dgCal3.Name = "dgCal3";
            this.dgCal3.Size = new System.Drawing.Size(240, 150);
            this.dgCal3.TabIndex = 29;
            // 
            // lbHouseInfLoss
            // 
            this.lbHouseInfLoss.AutoSize = true;
            this.lbHouseInfLoss.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHouseInfLoss.Location = new System.Drawing.Point(1012, 171);
            this.lbHouseInfLoss.Name = "lbHouseInfLoss";
            this.lbHouseInfLoss.Size = new System.Drawing.Size(43, 46);
            this.lbHouseInfLoss.TabIndex = 36;
            this.lbHouseInfLoss.Text = "INF\r\n0";
            this.lbHouseInfLoss.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbHouseLanLoss
            // 
            this.lbHouseLanLoss.AutoSize = true;
            this.lbHouseLanLoss.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHouseLanLoss.Location = new System.Drawing.Point(957, 171);
            this.lbHouseLanLoss.Name = "lbHouseLanLoss";
            this.lbHouseLanLoss.Size = new System.Drawing.Size(49, 46);
            this.lbHouseLanLoss.TabIndex = 35;
            this.lbHouseLanLoss.Text = "LAN\r\n0";
            this.lbHouseLanLoss.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbHouseLawLoss
            // 
            this.lbHouseLawLoss.AutoSize = true;
            this.lbHouseLawLoss.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHouseLawLoss.Location = new System.Drawing.Point(898, 171);
            this.lbHouseLawLoss.Name = "lbHouseLawLoss";
            this.lbHouseLawLoss.Size = new System.Drawing.Size(53, 46);
            this.lbHouseLawLoss.TabIndex = 34;
            this.lbHouseLawLoss.Text = "LAW\r\n0";
            this.lbHouseLawLoss.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbHousePopLoss
            // 
            this.lbHousePopLoss.AutoSize = true;
            this.lbHousePopLoss.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHousePopLoss.Location = new System.Drawing.Point(844, 171);
            this.lbHousePopLoss.Name = "lbHousePopLoss";
            this.lbHousePopLoss.Size = new System.Drawing.Size(48, 46);
            this.lbHousePopLoss.TabIndex = 33;
            this.lbHousePopLoss.Text = "POP\r\n0";
            this.lbHousePopLoss.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbHousePowLoss
            // 
            this.lbHousePowLoss.AutoSize = true;
            this.lbHousePowLoss.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHousePowLoss.Location = new System.Drawing.Point(783, 171);
            this.lbHousePowLoss.Name = "lbHousePowLoss";
            this.lbHousePowLoss.Size = new System.Drawing.Size(55, 46);
            this.lbHousePowLoss.TabIndex = 32;
            this.lbHousePowLoss.Text = "POW\r\n0";
            this.lbHousePowLoss.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbHouseWeaLoss
            // 
            this.lbHouseWeaLoss.AutoSize = true;
            this.lbHouseWeaLoss.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHouseWeaLoss.Location = new System.Drawing.Point(723, 171);
            this.lbHouseWeaLoss.Name = "lbHouseWeaLoss";
            this.lbHouseWeaLoss.Size = new System.Drawing.Size(54, 46);
            this.lbHouseWeaLoss.TabIndex = 31;
            this.lbHouseWeaLoss.Text = "WEA\r\n0";
            this.lbHouseWeaLoss.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbHouseDefLoss
            // 
            this.lbHouseDefLoss.AutoSize = true;
            this.lbHouseDefLoss.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHouseDefLoss.Location = new System.Drawing.Point(1061, 171);
            this.lbHouseDefLoss.Name = "lbHouseDefLoss";
            this.lbHouseDefLoss.Size = new System.Drawing.Size(47, 46);
            this.lbHouseDefLoss.TabIndex = 30;
            this.lbHouseDefLoss.Text = "DEF\r\n0";
            this.lbHouseDefLoss.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1129, 612);
            this.Controls.Add(this.lbHouseInfLoss);
            this.Controls.Add(this.lbHouseLanLoss);
            this.Controls.Add(this.lbHouseLawLoss);
            this.Controls.Add(this.lbHousePopLoss);
            this.Controls.Add(this.lbHousePowLoss);
            this.Controls.Add(this.lbHouseWeaLoss);
            this.Controls.Add(this.lbHouseDefLoss);
            this.Controls.Add(this.dgCal3);
            this.Controls.Add(this.dgCal2);
            this.Controls.Add(this.lbHouLanHolList);
            this.Controls.Add(this.lbHouLanHol);
            this.Controls.Add(this.lbHouseInfGain);
            this.Controls.Add(this.lbHouseLanGain);
            this.Controls.Add(this.lbHouseLawGain);
            this.Controls.Add(this.lbHousePopGain);
            this.Controls.Add(this.lbHousePowGain);
            this.Controls.Add(this.lbHouseWeaGain);
            this.Controls.Add(this.lbHouseDefGain);
            this.Controls.Add(this.lbHouseHF);
            this.Controls.Add(this.lbHouInfHolList);
            this.Controls.Add(this.lbHouseInfHol);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgCal1);
            this.Controls.Add(this.dgHouseDetails);
            this.Controls.Add(this.lbHouseSpare);
            this.Controls.Add(this.lbHouseCurrent);
            this.Controls.Add(this.lbHouseResources);
            this.Controls.Add(this.tbHouseLiegeLord);
            this.Controls.Add(this.cbHouseRealm);
            this.Controls.Add(this.tbHouseLiege);
            this.Controls.Add(this.tbHouseSeatOfPower);
            this.Controls.Add(this.tbHouseName);
            this.Controls.Add(this.lbHouseLiege);
            this.Controls.Add(this.lbHouseLiegeLord);
            this.Controls.Add(this.lbHouseSeatOfPower);
            this.Controls.Add(this.lbHouseRealm);
            this.Controls.Add(this.lbHouseName);
            this.Name = "FormMain";
            this.Text = "ASoIaF Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgHouseDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCal1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCal2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCal3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbHouseName;
        private System.Windows.Forms.Label lbHouseRealm;
        private System.Windows.Forms.Label lbHouseSeatOfPower;
        private System.Windows.Forms.Label lbHouseLiegeLord;
        private System.Windows.Forms.Label lbHouseLiege;
        private System.Windows.Forms.TextBox tbHouseName;
        private System.Windows.Forms.TextBox tbHouseSeatOfPower;
        private System.Windows.Forms.TextBox tbHouseLiege;
        private System.Windows.Forms.ComboBox cbHouseRealm;
        private System.Windows.Forms.TextBox tbHouseLiegeLord;
        private System.Windows.Forms.Label lbHouseResources;
        private System.Windows.Forms.Label lbHouseCurrent;
        private System.Windows.Forms.Label lbHouseSpare;
        private System.Windows.Forms.DataGridView dgHouseDetails;
        private System.Windows.Forms.DataGridView dgCal1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton tsMenu;
        private System.Windows.Forms.ToolStripMenuItem devLogToolStripMenuItem;
        private System.Windows.Forms.Label lbHouseInfHol;
        private System.Windows.Forms.Label lbHouInfHolList;
        private System.Windows.Forms.Label lbHouseHF;
        private System.Windows.Forms.Label lbHouseDefGain;
        private System.Windows.Forms.Label lbHouseWeaGain;
        private System.Windows.Forms.Label lbHousePowGain;
        private System.Windows.Forms.Label lbHousePopGain;
        private System.Windows.Forms.Label lbHouseLawGain;
        private System.Windows.Forms.Label lbHouseLanGain;
        private System.Windows.Forms.Label lbHouseInfGain;
        private System.Windows.Forms.Label lbHouLanHol;
        private System.Windows.Forms.Label lbHouLanHolList;
        private System.Windows.Forms.DataGridView dgCal2;
        private System.Windows.Forms.DataGridView dgCal3;
        private System.Windows.Forms.Label lbHouseInfLoss;
        private System.Windows.Forms.Label lbHouseLanLoss;
        private System.Windows.Forms.Label lbHouseLawLoss;
        private System.Windows.Forms.Label lbHousePopLoss;
        private System.Windows.Forms.Label lbHousePowLoss;
        private System.Windows.Forms.Label lbHouseWeaLoss;
        private System.Windows.Forms.Label lbHouseDefLoss;
    }
}

