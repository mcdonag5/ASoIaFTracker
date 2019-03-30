namespace WindowsFormsApp1
{
    partial class CreateHouseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateHouseForm));
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpHeader = new System.Windows.Forms.TableLayoutPanel();
            this.lbName = new System.Windows.Forms.Label();
            this.pbHouseShield = new System.Windows.Forms.PictureBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbSeatOfPower = new System.Windows.Forms.Label();
            this.tbSeatOfPower = new System.Windows.Forms.TextBox();
            this.lbLiegeLord = new System.Windows.Forms.Label();
            this.tbLiegeLord = new System.Windows.Forms.TextBox();
            this.lbLiege = new System.Windows.Forms.Label();
            this.tbLiege = new System.Windows.Forms.TextBox();
            this.lbRealm = new System.Windows.Forms.Label();
            this.cbRealm = new System.Windows.Forms.ComboBox();
            this.lbRealmDescription = new System.Windows.Forms.Label();
            this.tlpHouseDetails = new System.Windows.Forms.TableLayoutPanel();
            this.lbTotalDefText = new System.Windows.Forms.Label();
            this.lbTotalInfText = new System.Windows.Forms.Label();
            this.lbTotalWeaText = new System.Windows.Forms.Label();
            this.lbHistoryWeaText = new System.Windows.Forms.Label();
            this.lbHistoryPopText = new System.Windows.Forms.Label();
            this.lbHistoryLawText = new System.Windows.Forms.Label();
            this.lbHistoryLanText = new System.Windows.Forms.Label();
            this.lbHistoryInfText = new System.Windows.Forms.Label();
            this.lbHistoryDefText = new System.Windows.Forms.Label();
            this.lbHistoryPowText = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbRealmDefText = new System.Windows.Forms.Label();
            this.lbRealmInfText = new System.Windows.Forms.Label();
            this.lbRealmLanText = new System.Windows.Forms.Label();
            this.lbRealmMod = new System.Windows.Forms.Label();
            this.lbRealmPopText = new System.Windows.Forms.Label();
            this.lbRealmWeaText = new System.Windows.Forms.Label();
            this.lbBase = new System.Windows.Forms.Label();
            this.lbDefense = new System.Windows.Forms.Label();
            this.lbInfluence = new System.Windows.Forms.Label();
            this.lbResources = new System.Windows.Forms.Label();
            this.lbWealth = new System.Windows.Forms.Label();
            this.lbPower = new System.Windows.Forms.Label();
            this.lbLand = new System.Windows.Forms.Label();
            this.lbLaw = new System.Windows.Forms.Label();
            this.lbPopulation = new System.Windows.Forms.Label();
            this.tbBaseWea = new System.Windows.Forms.TextBox();
            this.tbBasePow = new System.Windows.Forms.TextBox();
            this.tbBasePop = new System.Windows.Forms.TextBox();
            this.tbBaseLaw = new System.Windows.Forms.TextBox();
            this.tbBaseLan = new System.Windows.Forms.TextBox();
            this.tbBaseInf = new System.Windows.Forms.TextBox();
            this.tbBaseDef = new System.Windows.Forms.TextBox();
            this.lbRealmLawText = new System.Windows.Forms.Label();
            this.lbRealmPowText = new System.Windows.Forms.Label();
            this.lbHistory = new System.Windows.Forms.Label();
            this.lbTotalPowText = new System.Windows.Forms.Label();
            this.lbTotalPopText = new System.Windows.Forms.Label();
            this.lbTotalLanText = new System.Windows.Forms.Label();
            this.lbTotalLawText = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dgCal1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.tlpMain.SuspendLayout();
            this.tlpHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHouseShield)).BeginInit();
            this.tlpHouseDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCal1)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.tlpHeader, 0, 0);
            this.tlpMain.Controls.Add(this.tlpHouseDetails, 0, 1);
            this.tlpMain.Location = new System.Drawing.Point(12, 12);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 260F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Size = new System.Drawing.Size(902, 602);
            this.tlpMain.TabIndex = 0;
            // 
            // tlpHeader
            // 
            this.tlpHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpHeader.ColumnCount = 4;
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpHeader.Controls.Add(this.lbName, 0, 0);
            this.tlpHeader.Controls.Add(this.pbHouseShield, 0, 3);
            this.tlpHeader.Controls.Add(this.tbName, 1, 0);
            this.tlpHeader.Controls.Add(this.lbSeatOfPower, 2, 0);
            this.tlpHeader.Controls.Add(this.tbSeatOfPower, 3, 0);
            this.tlpHeader.Controls.Add(this.lbLiegeLord, 0, 1);
            this.tlpHeader.Controls.Add(this.tbLiegeLord, 1, 1);
            this.tlpHeader.Controls.Add(this.lbLiege, 2, 1);
            this.tlpHeader.Controls.Add(this.tbLiege, 3, 1);
            this.tlpHeader.Controls.Add(this.lbRealm, 0, 2);
            this.tlpHeader.Controls.Add(this.cbRealm, 1, 2);
            this.tlpHeader.Controls.Add(this.lbRealmDescription, 1, 3);
            this.tlpHeader.Location = new System.Drawing.Point(3, 3);
            this.tlpHeader.Name = "tlpHeader";
            this.tlpHeader.RowCount = 4;
            this.tlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHeader.Size = new System.Drawing.Size(896, 254);
            this.tlpHeader.TabIndex = 0;
            // 
            // lbName
            // 
            this.lbName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(3, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(120, 35);
            this.lbName.TabIndex = 8;
            this.lbName.Text = "Name:";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pbHouseShield
            // 
            this.pbHouseShield.Image = global::WindowsFormsApp1.Properties.Resources.NightsWatch;
            this.pbHouseShield.InitialImage = null;
            this.pbHouseShield.Location = new System.Drawing.Point(3, 110);
            this.pbHouseShield.Name = "pbHouseShield";
            this.pbHouseShield.Size = new System.Drawing.Size(120, 130);
            this.pbHouseShield.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHouseShield.TabIndex = 1;
            this.pbHouseShield.TabStop = false;
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(129, 3);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(303, 29);
            this.tbName.TabIndex = 9;
            // 
            // lbSeatOfPower
            // 
            this.lbSeatOfPower.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSeatOfPower.AutoSize = true;
            this.lbSeatOfPower.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSeatOfPower.Location = new System.Drawing.Point(438, 0);
            this.lbSeatOfPower.Name = "lbSeatOfPower";
            this.lbSeatOfPower.Size = new System.Drawing.Size(145, 35);
            this.lbSeatOfPower.TabIndex = 10;
            this.lbSeatOfPower.Text = "Seat of Power:";
            this.lbSeatOfPower.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbSeatOfPower
            // 
            this.tbSeatOfPower.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSeatOfPower.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSeatOfPower.Location = new System.Drawing.Point(589, 3);
            this.tbSeatOfPower.Name = "tbSeatOfPower";
            this.tbSeatOfPower.Size = new System.Drawing.Size(304, 29);
            this.tbSeatOfPower.TabIndex = 11;
            // 
            // lbLiegeLord
            // 
            this.lbLiegeLord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLiegeLord.AutoSize = true;
            this.lbLiegeLord.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLiegeLord.Location = new System.Drawing.Point(3, 35);
            this.lbLiegeLord.Name = "lbLiegeLord";
            this.lbLiegeLord.Size = new System.Drawing.Size(120, 35);
            this.lbLiegeLord.TabIndex = 12;
            this.lbLiegeLord.Text = "Liege Lord:";
            this.lbLiegeLord.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbLiegeLord
            // 
            this.tbLiegeLord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLiegeLord.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLiegeLord.Location = new System.Drawing.Point(129, 38);
            this.tbLiegeLord.Name = "tbLiegeLord";
            this.tbLiegeLord.Size = new System.Drawing.Size(303, 29);
            this.tbLiegeLord.TabIndex = 13;
            // 
            // lbLiege
            // 
            this.lbLiege.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLiege.AutoSize = true;
            this.lbLiege.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLiege.Location = new System.Drawing.Point(438, 35);
            this.lbLiege.Name = "lbLiege";
            this.lbLiege.Size = new System.Drawing.Size(145, 35);
            this.lbLiege.TabIndex = 14;
            this.lbLiege.Text = "Liege:";
            this.lbLiege.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbLiege
            // 
            this.tbLiege.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLiege.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLiege.Location = new System.Drawing.Point(589, 38);
            this.tbLiege.Name = "tbLiege";
            this.tbLiege.Size = new System.Drawing.Size(304, 29);
            this.tbLiege.TabIndex = 15;
            // 
            // lbRealm
            // 
            this.lbRealm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbRealm.AutoSize = true;
            this.lbRealm.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRealm.Location = new System.Drawing.Point(3, 70);
            this.lbRealm.Name = "lbRealm";
            this.lbRealm.Size = new System.Drawing.Size(120, 37);
            this.lbRealm.TabIndex = 16;
            this.lbRealm.Text = "Realm:";
            this.lbRealm.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cbRealm
            // 
            this.cbRealm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpHeader.SetColumnSpan(this.cbRealm, 3);
            this.cbRealm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRealm.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRealm.FormattingEnabled = true;
            this.cbRealm.ImeMode = System.Windows.Forms.ImeMode.On;
            this.cbRealm.Items.AddRange(new object[] {
            "Kings Landing",
            "Dragonstone",
            "The North",
            "The Iron Islands",
            "The Riverlands",
            "The Mountains of the Moon",
            "The Westerlands",
            "The Reach",
            "The Stormlands",
            "Dorne",
            "The Wall"});
            this.cbRealm.Location = new System.Drawing.Point(129, 73);
            this.cbRealm.Name = "cbRealm";
            this.cbRealm.Size = new System.Drawing.Size(764, 31);
            this.cbRealm.TabIndex = 17;
            this.cbRealm.TextChanged += new System.EventHandler(this.cbRealm_TextChanged);
            // 
            // lbRealmDescription
            // 
            this.lbRealmDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbRealmDescription.AutoSize = true;
            this.tlpHeader.SetColumnSpan(this.lbRealmDescription, 3);
            this.lbRealmDescription.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRealmDescription.Location = new System.Drawing.Point(129, 107);
            this.lbRealmDescription.Name = "lbRealmDescription";
            this.lbRealmDescription.Size = new System.Drawing.Size(764, 144);
            this.lbRealmDescription.TabIndex = 18;
            this.lbRealmDescription.Text = resources.GetString("lbRealmDescription.Text");
            // 
            // tlpHouseDetails
            // 
            this.tlpHouseDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpHouseDetails.ColumnCount = 7;
            this.tlpHouseDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpHouseDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpHouseDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpHouseDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpHouseDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpHouseDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 509F));
            this.tlpHouseDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpHouseDetails.Controls.Add(this.lbTotalDefText, 4, 7);
            this.tlpHouseDetails.Controls.Add(this.lbTotalInfText, 4, 6);
            this.tlpHouseDetails.Controls.Add(this.button1, 0, 8);
            this.tlpHouseDetails.Controls.Add(this.lbTotalWeaText, 4, 1);
            this.tlpHouseDetails.Controls.Add(this.lbHistoryWeaText, 3, 1);
            this.tlpHouseDetails.Controls.Add(this.lbHistoryPopText, 3, 3);
            this.tlpHouseDetails.Controls.Add(this.lbHistoryLawText, 3, 4);
            this.tlpHouseDetails.Controls.Add(this.lbHistoryLanText, 3, 5);
            this.tlpHouseDetails.Controls.Add(this.lbHistoryInfText, 3, 6);
            this.tlpHouseDetails.Controls.Add(this.lbHistoryDefText, 3, 7);
            this.tlpHouseDetails.Controls.Add(this.lbHistoryPowText, 3, 2);
            this.tlpHouseDetails.Controls.Add(this.lbTotal, 4, 0);
            this.tlpHouseDetails.Controls.Add(this.lbRealmDefText, 2, 7);
            this.tlpHouseDetails.Controls.Add(this.lbRealmInfText, 2, 6);
            this.tlpHouseDetails.Controls.Add(this.lbRealmLanText, 2, 5);
            this.tlpHouseDetails.Controls.Add(this.lbRealmMod, 2, 0);
            this.tlpHouseDetails.Controls.Add(this.lbRealmPopText, 2, 3);
            this.tlpHouseDetails.Controls.Add(this.lbRealmWeaText, 2, 1);
            this.tlpHouseDetails.Controls.Add(this.lbBase, 1, 0);
            this.tlpHouseDetails.Controls.Add(this.lbDefense, 0, 7);
            this.tlpHouseDetails.Controls.Add(this.lbInfluence, 0, 6);
            this.tlpHouseDetails.Controls.Add(this.lbResources, 0, 0);
            this.tlpHouseDetails.Controls.Add(this.lbWealth, 0, 1);
            this.tlpHouseDetails.Controls.Add(this.lbPower, 0, 2);
            this.tlpHouseDetails.Controls.Add(this.lbLand, 0, 5);
            this.tlpHouseDetails.Controls.Add(this.lbLaw, 0, 4);
            this.tlpHouseDetails.Controls.Add(this.lbPopulation, 0, 3);
            this.tlpHouseDetails.Controls.Add(this.tbBaseWea, 1, 1);
            this.tlpHouseDetails.Controls.Add(this.tbBasePow, 1, 2);
            this.tlpHouseDetails.Controls.Add(this.tbBasePop, 1, 3);
            this.tlpHouseDetails.Controls.Add(this.tbBaseLaw, 1, 4);
            this.tlpHouseDetails.Controls.Add(this.tbBaseLan, 1, 5);
            this.tlpHouseDetails.Controls.Add(this.tbBaseInf, 1, 6);
            this.tlpHouseDetails.Controls.Add(this.tbBaseDef, 1, 7);
            this.tlpHouseDetails.Controls.Add(this.lbRealmLawText, 2, 4);
            this.tlpHouseDetails.Controls.Add(this.lbRealmPowText, 2, 2);
            this.tlpHouseDetails.Controls.Add(this.lbHistory, 3, 0);
            this.tlpHouseDetails.Controls.Add(this.lbTotalPowText, 4, 2);
            this.tlpHouseDetails.Controls.Add(this.lbTotalPopText, 4, 3);
            this.tlpHouseDetails.Controls.Add(this.lbTotalLanText, 4, 5);
            this.tlpHouseDetails.Controls.Add(this.lbTotalLawText, 4, 4);
            this.tlpHouseDetails.Controls.Add(this.button2, 1, 8);
            this.tlpHouseDetails.Location = new System.Drawing.Point(2, 262);
            this.tlpHouseDetails.Margin = new System.Windows.Forms.Padding(2);
            this.tlpHouseDetails.Name = "tlpHouseDetails";
            this.tlpHouseDetails.Padding = new System.Windows.Forms.Padding(4);
            this.tlpHouseDetails.RowCount = 9;
            this.tlpHouseDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpHouseDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpHouseDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpHouseDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpHouseDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpHouseDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpHouseDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpHouseDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpHouseDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpHouseDetails.Size = new System.Drawing.Size(898, 296);
            this.tlpHouseDetails.TabIndex = 2;
            // 
            // lbTotalDefText
            // 
            this.lbTotalDefText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTotalDefText.AutoSize = true;
            this.lbTotalDefText.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalDefText.Location = new System.Drawing.Point(328, 231);
            this.lbTotalDefText.Name = "lbTotalDefText";
            this.lbTotalDefText.Size = new System.Drawing.Size(54, 34);
            this.lbTotalDefText.TabIndex = 13;
            this.lbTotalDefText.Text = "000";
            this.lbTotalDefText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbTotalInfText
            // 
            this.lbTotalInfText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTotalInfText.AutoSize = true;
            this.lbTotalInfText.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalInfText.Location = new System.Drawing.Point(328, 197);
            this.lbTotalInfText.Name = "lbTotalInfText";
            this.lbTotalInfText.Size = new System.Drawing.Size(54, 34);
            this.lbTotalInfText.TabIndex = 13;
            this.lbTotalInfText.Text = "000";
            this.lbTotalInfText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbTotalWeaText
            // 
            this.lbTotalWeaText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTotalWeaText.AutoSize = true;
            this.lbTotalWeaText.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalWeaText.Location = new System.Drawing.Point(328, 27);
            this.lbTotalWeaText.Name = "lbTotalWeaText";
            this.lbTotalWeaText.Size = new System.Drawing.Size(54, 34);
            this.lbTotalWeaText.TabIndex = 13;
            this.lbTotalWeaText.Text = "000";
            this.lbTotalWeaText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbHistoryWeaText
            // 
            this.lbHistoryWeaText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbHistoryWeaText.AutoSize = true;
            this.lbHistoryWeaText.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHistoryWeaText.Location = new System.Drawing.Point(249, 27);
            this.lbHistoryWeaText.Name = "lbHistoryWeaText";
            this.lbHistoryWeaText.Size = new System.Drawing.Size(73, 34);
            this.lbHistoryWeaText.TabIndex = 13;
            this.lbHistoryWeaText.Text = "000";
            this.lbHistoryWeaText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbHistoryPopText
            // 
            this.lbHistoryPopText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbHistoryPopText.AutoSize = true;
            this.lbHistoryPopText.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHistoryPopText.Location = new System.Drawing.Point(249, 95);
            this.lbHistoryPopText.Name = "lbHistoryPopText";
            this.lbHistoryPopText.Size = new System.Drawing.Size(73, 34);
            this.lbHistoryPopText.TabIndex = 13;
            this.lbHistoryPopText.Text = "000";
            this.lbHistoryPopText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbHistoryLawText
            // 
            this.lbHistoryLawText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbHistoryLawText.AutoSize = true;
            this.lbHistoryLawText.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHistoryLawText.Location = new System.Drawing.Point(249, 129);
            this.lbHistoryLawText.Name = "lbHistoryLawText";
            this.lbHistoryLawText.Size = new System.Drawing.Size(73, 34);
            this.lbHistoryLawText.TabIndex = 13;
            this.lbHistoryLawText.Text = "000";
            this.lbHistoryLawText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbHistoryLanText
            // 
            this.lbHistoryLanText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbHistoryLanText.AutoSize = true;
            this.lbHistoryLanText.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHistoryLanText.Location = new System.Drawing.Point(249, 163);
            this.lbHistoryLanText.Name = "lbHistoryLanText";
            this.lbHistoryLanText.Size = new System.Drawing.Size(73, 34);
            this.lbHistoryLanText.TabIndex = 13;
            this.lbHistoryLanText.Text = "000";
            this.lbHistoryLanText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbHistoryInfText
            // 
            this.lbHistoryInfText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbHistoryInfText.AutoSize = true;
            this.lbHistoryInfText.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHistoryInfText.Location = new System.Drawing.Point(249, 197);
            this.lbHistoryInfText.Name = "lbHistoryInfText";
            this.lbHistoryInfText.Size = new System.Drawing.Size(73, 34);
            this.lbHistoryInfText.TabIndex = 13;
            this.lbHistoryInfText.Text = "000";
            this.lbHistoryInfText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbHistoryDefText
            // 
            this.lbHistoryDefText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbHistoryDefText.AutoSize = true;
            this.lbHistoryDefText.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHistoryDefText.Location = new System.Drawing.Point(249, 231);
            this.lbHistoryDefText.Name = "lbHistoryDefText";
            this.lbHistoryDefText.Size = new System.Drawing.Size(73, 34);
            this.lbHistoryDefText.TabIndex = 13;
            this.lbHistoryDefText.Text = "000";
            this.lbHistoryDefText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbHistoryPowText
            // 
            this.lbHistoryPowText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbHistoryPowText.AutoSize = true;
            this.lbHistoryPowText.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHistoryPowText.Location = new System.Drawing.Point(249, 61);
            this.lbHistoryPowText.Name = "lbHistoryPowText";
            this.lbHistoryPowText.Size = new System.Drawing.Size(73, 34);
            this.lbHistoryPowText.TabIndex = 13;
            this.lbHistoryPowText.Text = "000";
            this.lbHistoryPowText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbTotal
            // 
            this.lbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(328, 4);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(54, 23);
            this.lbTotal.TabIndex = 13;
            this.lbTotal.Text = "Total";
            // 
            // lbRealmDefText
            // 
            this.lbRealmDefText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbRealmDefText.AutoSize = true;
            this.lbRealmDefText.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRealmDefText.Location = new System.Drawing.Point(179, 231);
            this.lbRealmDefText.Name = "lbRealmDefText";
            this.lbRealmDefText.Size = new System.Drawing.Size(64, 34);
            this.lbRealmDefText.TabIndex = 12;
            this.lbRealmDefText.Text = "000";
            this.lbRealmDefText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbRealmInfText
            // 
            this.lbRealmInfText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbRealmInfText.AutoSize = true;
            this.lbRealmInfText.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRealmInfText.Location = new System.Drawing.Point(179, 197);
            this.lbRealmInfText.Name = "lbRealmInfText";
            this.lbRealmInfText.Size = new System.Drawing.Size(64, 34);
            this.lbRealmInfText.TabIndex = 12;
            this.lbRealmInfText.Text = "000";
            this.lbRealmInfText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbRealmLanText
            // 
            this.lbRealmLanText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbRealmLanText.AutoSize = true;
            this.lbRealmLanText.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRealmLanText.Location = new System.Drawing.Point(179, 163);
            this.lbRealmLanText.Name = "lbRealmLanText";
            this.lbRealmLanText.Size = new System.Drawing.Size(64, 34);
            this.lbRealmLanText.TabIndex = 12;
            this.lbRealmLanText.Text = "000";
            this.lbRealmLanText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbRealmMod
            // 
            this.lbRealmMod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbRealmMod.AutoSize = true;
            this.lbRealmMod.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRealmMod.Location = new System.Drawing.Point(179, 4);
            this.lbRealmMod.Name = "lbRealmMod";
            this.lbRealmMod.Size = new System.Drawing.Size(64, 23);
            this.lbRealmMod.TabIndex = 11;
            this.lbRealmMod.Text = "Realm";
            // 
            // lbRealmPopText
            // 
            this.lbRealmPopText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbRealmPopText.AutoSize = true;
            this.lbRealmPopText.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRealmPopText.Location = new System.Drawing.Point(179, 95);
            this.lbRealmPopText.Name = "lbRealmPopText";
            this.lbRealmPopText.Size = new System.Drawing.Size(64, 34);
            this.lbRealmPopText.TabIndex = 12;
            this.lbRealmPopText.Text = "000";
            this.lbRealmPopText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbRealmWeaText
            // 
            this.lbRealmWeaText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbRealmWeaText.AutoSize = true;
            this.lbRealmWeaText.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRealmWeaText.Location = new System.Drawing.Point(179, 27);
            this.lbRealmWeaText.Name = "lbRealmWeaText";
            this.lbRealmWeaText.Size = new System.Drawing.Size(64, 34);
            this.lbRealmWeaText.TabIndex = 12;
            this.lbRealmWeaText.Text = "000";
            this.lbRealmWeaText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbBase
            // 
            this.lbBase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBase.AutoSize = true;
            this.lbBase.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBase.Location = new System.Drawing.Point(122, 4);
            this.lbBase.Name = "lbBase";
            this.lbBase.Size = new System.Drawing.Size(51, 23);
            this.lbBase.TabIndex = 10;
            this.lbBase.Text = "Base";
            this.lbBase.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbDefense
            // 
            this.lbDefense.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDefense.AutoSize = true;
            this.lbDefense.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDefense.Location = new System.Drawing.Point(7, 231);
            this.lbDefense.Name = "lbDefense";
            this.lbDefense.Size = new System.Drawing.Size(109, 34);
            this.lbDefense.TabIndex = 15;
            this.lbDefense.Text = "Defense:";
            this.lbDefense.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbInfluence
            // 
            this.lbInfluence.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbInfluence.AutoSize = true;
            this.lbInfluence.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfluence.Location = new System.Drawing.Point(7, 197);
            this.lbInfluence.Name = "lbInfluence";
            this.lbInfluence.Size = new System.Drawing.Size(109, 34);
            this.lbInfluence.TabIndex = 14;
            this.lbInfluence.Text = "Influence:";
            this.lbInfluence.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbResources
            // 
            this.lbResources.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbResources.AutoSize = true;
            this.lbResources.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResources.Location = new System.Drawing.Point(7, 4);
            this.lbResources.Name = "lbResources";
            this.lbResources.Size = new System.Drawing.Size(109, 23);
            this.lbResources.TabIndex = 8;
            this.lbResources.Text = "Resources";
            this.lbResources.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbWealth
            // 
            this.lbWealth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbWealth.AutoSize = true;
            this.lbWealth.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWealth.Location = new System.Drawing.Point(7, 27);
            this.lbWealth.Name = "lbWealth";
            this.lbWealth.Size = new System.Drawing.Size(109, 34);
            this.lbWealth.TabIndex = 9;
            this.lbWealth.Text = "Wealth:";
            this.lbWealth.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbPower
            // 
            this.lbPower.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPower.AutoSize = true;
            this.lbPower.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPower.Location = new System.Drawing.Point(7, 61);
            this.lbPower.Name = "lbPower";
            this.lbPower.Size = new System.Drawing.Size(109, 34);
            this.lbPower.TabIndex = 10;
            this.lbPower.Text = "Power:";
            this.lbPower.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbLand
            // 
            this.lbLand.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLand.AutoSize = true;
            this.lbLand.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLand.Location = new System.Drawing.Point(7, 163);
            this.lbLand.Name = "lbLand";
            this.lbLand.Size = new System.Drawing.Size(109, 34);
            this.lbLand.TabIndex = 11;
            this.lbLand.Text = "Land:";
            this.lbLand.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbLaw
            // 
            this.lbLaw.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLaw.AutoSize = true;
            this.lbLaw.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLaw.Location = new System.Drawing.Point(7, 129);
            this.lbLaw.Name = "lbLaw";
            this.lbLaw.Size = new System.Drawing.Size(109, 34);
            this.lbLaw.TabIndex = 12;
            this.lbLaw.Text = "Law:";
            this.lbLaw.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbPopulation
            // 
            this.lbPopulation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPopulation.AutoSize = true;
            this.lbPopulation.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPopulation.Location = new System.Drawing.Point(7, 95);
            this.lbPopulation.Name = "lbPopulation";
            this.lbPopulation.Size = new System.Drawing.Size(109, 34);
            this.lbPopulation.TabIndex = 13;
            this.lbPopulation.Text = "Population:";
            this.lbPopulation.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbBaseWea
            // 
            this.tbBaseWea.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.tbBaseWea.Location = new System.Drawing.Point(122, 30);
            this.tbBaseWea.MaxLength = 3;
            this.tbBaseWea.Name = "tbBaseWea";
            this.tbBaseWea.Size = new System.Drawing.Size(51, 28);
            this.tbBaseWea.TabIndex = 22;
            this.tbBaseWea.Text = "000";
            this.tbBaseWea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbBaseWea.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            // 
            // tbBasePow
            // 
            this.tbBasePow.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.tbBasePow.Location = new System.Drawing.Point(122, 64);
            this.tbBasePow.MaxLength = 3;
            this.tbBasePow.Name = "tbBasePow";
            this.tbBasePow.Size = new System.Drawing.Size(51, 28);
            this.tbBasePow.TabIndex = 23;
            this.tbBasePow.Text = "000";
            this.tbBasePow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbBasePow.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            // 
            // tbBasePop
            // 
            this.tbBasePop.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.tbBasePop.Location = new System.Drawing.Point(122, 98);
            this.tbBasePop.MaxLength = 3;
            this.tbBasePop.Name = "tbBasePop";
            this.tbBasePop.Size = new System.Drawing.Size(51, 28);
            this.tbBasePop.TabIndex = 24;
            this.tbBasePop.Text = "000";
            this.tbBasePop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbBasePop.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            // 
            // tbBaseLaw
            // 
            this.tbBaseLaw.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.tbBaseLaw.Location = new System.Drawing.Point(122, 132);
            this.tbBaseLaw.MaxLength = 3;
            this.tbBaseLaw.Name = "tbBaseLaw";
            this.tbBaseLaw.Size = new System.Drawing.Size(51, 28);
            this.tbBaseLaw.TabIndex = 25;
            this.tbBaseLaw.Text = "000";
            this.tbBaseLaw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbBaseLaw.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            // 
            // tbBaseLan
            // 
            this.tbBaseLan.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.tbBaseLan.Location = new System.Drawing.Point(122, 166);
            this.tbBaseLan.MaxLength = 3;
            this.tbBaseLan.Name = "tbBaseLan";
            this.tbBaseLan.Size = new System.Drawing.Size(51, 28);
            this.tbBaseLan.TabIndex = 26;
            this.tbBaseLan.Text = "000";
            this.tbBaseLan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbBaseLan.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            // 
            // tbBaseInf
            // 
            this.tbBaseInf.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.tbBaseInf.Location = new System.Drawing.Point(122, 200);
            this.tbBaseInf.MaxLength = 3;
            this.tbBaseInf.Name = "tbBaseInf";
            this.tbBaseInf.Size = new System.Drawing.Size(51, 28);
            this.tbBaseInf.TabIndex = 27;
            this.tbBaseInf.Text = "000";
            this.tbBaseInf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbBaseInf.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            // 
            // tbBaseDef
            // 
            this.tbBaseDef.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.tbBaseDef.Location = new System.Drawing.Point(122, 234);
            this.tbBaseDef.MaxLength = 3;
            this.tbBaseDef.Name = "tbBaseDef";
            this.tbBaseDef.Size = new System.Drawing.Size(51, 28);
            this.tbBaseDef.TabIndex = 28;
            this.tbBaseDef.Text = "000";
            this.tbBaseDef.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbBaseDef.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            // 
            // lbRealmLawText
            // 
            this.lbRealmLawText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbRealmLawText.AutoSize = true;
            this.lbRealmLawText.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRealmLawText.Location = new System.Drawing.Point(179, 129);
            this.lbRealmLawText.Name = "lbRealmLawText";
            this.lbRealmLawText.Size = new System.Drawing.Size(64, 34);
            this.lbRealmLawText.TabIndex = 29;
            this.lbRealmLawText.Text = "000";
            this.lbRealmLawText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbRealmPowText
            // 
            this.lbRealmPowText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbRealmPowText.AutoSize = true;
            this.lbRealmPowText.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRealmPowText.Location = new System.Drawing.Point(179, 61);
            this.lbRealmPowText.Name = "lbRealmPowText";
            this.lbRealmPowText.Size = new System.Drawing.Size(64, 34);
            this.lbRealmPowText.TabIndex = 12;
            this.lbRealmPowText.Text = "000";
            this.lbRealmPowText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbHistory
            // 
            this.lbHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbHistory.AutoSize = true;
            this.lbHistory.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHistory.Location = new System.Drawing.Point(249, 4);
            this.lbHistory.Name = "lbHistory";
            this.lbHistory.Size = new System.Drawing.Size(73, 23);
            this.lbHistory.TabIndex = 12;
            this.lbHistory.Text = "History";
            // 
            // lbTotalPowText
            // 
            this.lbTotalPowText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTotalPowText.AutoSize = true;
            this.lbTotalPowText.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPowText.Location = new System.Drawing.Point(328, 61);
            this.lbTotalPowText.Name = "lbTotalPowText";
            this.lbTotalPowText.Size = new System.Drawing.Size(54, 34);
            this.lbTotalPowText.TabIndex = 30;
            this.lbTotalPowText.Text = "000";
            this.lbTotalPowText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbTotalPopText
            // 
            this.lbTotalPopText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTotalPopText.AutoSize = true;
            this.lbTotalPopText.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPopText.Location = new System.Drawing.Point(328, 95);
            this.lbTotalPopText.Name = "lbTotalPopText";
            this.lbTotalPopText.Size = new System.Drawing.Size(54, 34);
            this.lbTotalPopText.TabIndex = 31;
            this.lbTotalPopText.Text = "000";
            this.lbTotalPopText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbTotalLanText
            // 
            this.lbTotalLanText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTotalLanText.AutoSize = true;
            this.lbTotalLanText.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalLanText.Location = new System.Drawing.Point(328, 163);
            this.lbTotalLanText.Name = "lbTotalLanText";
            this.lbTotalLanText.Size = new System.Drawing.Size(54, 34);
            this.lbTotalLanText.TabIndex = 33;
            this.lbTotalLanText.Text = "000";
            this.lbTotalLanText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbTotalLawText
            // 
            this.lbTotalLawText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTotalLawText.AutoSize = true;
            this.lbTotalLawText.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalLawText.Location = new System.Drawing.Point(328, 129);
            this.lbTotalLawText.Name = "lbTotalLawText";
            this.lbTotalLawText.Size = new System.Drawing.Size(54, 34);
            this.lbTotalLawText.TabIndex = 32;
            this.lbTotalLawText.Text = "000";
            this.lbTotalLawText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(66, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 21);
            this.button1.TabIndex = 3;
            this.button1.Text = "7d6";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgCal1
            // 
            this.dgCal1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCal1.Location = new System.Drawing.Point(917, 109);
            this.dgCal1.Name = "dgCal1";
            this.dgCal1.Size = new System.Drawing.Size(240, 150);
            this.dgCal1.TabIndex = 1;
            this.dgCal1.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(122, 268);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 21);
            this.button2.TabIndex = 34;
            this.button2.Text = "5d6";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CreateHouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 626);
            this.Controls.Add(this.dgCal1);
            this.Controls.Add(this.tlpMain);
            this.Name = "CreateHouseForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CreateHouseForm_Load);
            this.tlpMain.ResumeLayout(false);
            this.tlpHeader.ResumeLayout(false);
            this.tlpHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHouseShield)).EndInit();
            this.tlpHouseDetails.ResumeLayout(false);
            this.tlpHouseDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCal1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpHeader;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbSeatOfPower;
        private System.Windows.Forms.TextBox tbSeatOfPower;
        private System.Windows.Forms.Label lbLiegeLord;
        private System.Windows.Forms.TextBox tbLiegeLord;
        private System.Windows.Forms.Label lbLiege;
        private System.Windows.Forms.TextBox tbLiege;
        private System.Windows.Forms.Label lbRealm;
        private System.Windows.Forms.ComboBox cbRealm;
        private System.Windows.Forms.Label lbRealmDescription;
        private System.Windows.Forms.PictureBox pbHouseShield;
        private System.Windows.Forms.DataGridView dgCal1;
        private System.Windows.Forms.TableLayoutPanel tlpHouseDetails;
        private System.Windows.Forms.Label lbRealmDefText;
        private System.Windows.Forms.Label lbRealmInfText;
        private System.Windows.Forms.Label lbRealmLanText;
        private System.Windows.Forms.Label lbRealmPopText;
        private System.Windows.Forms.Label lbRealmPowText;
        private System.Windows.Forms.Label lbRealmWeaText;
        private System.Windows.Forms.Label lbRealmMod;
        private System.Windows.Forms.Label lbBase;
        private System.Windows.Forms.Label lbDefense;
        private System.Windows.Forms.Label lbInfluence;
        private System.Windows.Forms.Label lbResources;
        private System.Windows.Forms.Label lbWealth;
        private System.Windows.Forms.Label lbPower;
        private System.Windows.Forms.Label lbLand;
        private System.Windows.Forms.Label lbLaw;
        private System.Windows.Forms.Label lbPopulation;
        private System.Windows.Forms.TextBox tbBaseWea;
        private System.Windows.Forms.TextBox tbBasePow;
        private System.Windows.Forms.TextBox tbBasePop;
        private System.Windows.Forms.TextBox tbBaseLaw;
        private System.Windows.Forms.TextBox tbBaseLan;
        private System.Windows.Forms.TextBox tbBaseInf;
        private System.Windows.Forms.TextBox tbBaseDef;
        private System.Windows.Forms.Label lbRealmLawText;
        private System.Windows.Forms.Label lbHistory;
        private System.Windows.Forms.Label lbHistoryPowText;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbHistoryPopText;
        private System.Windows.Forms.Label lbHistoryLawText;
        private System.Windows.Forms.Label lbHistoryLanText;
        private System.Windows.Forms.Label lbHistoryInfText;
        private System.Windows.Forms.Label lbHistoryDefText;
        private System.Windows.Forms.Label lbTotalDefText;
        private System.Windows.Forms.Label lbTotalInfText;
        private System.Windows.Forms.Label lbTotalWeaText;
        private System.Windows.Forms.Label lbHistoryWeaText;
        private System.Windows.Forms.Label lbTotalPowText;
        private System.Windows.Forms.Label lbTotalPopText;
        private System.Windows.Forms.Label lbTotalLanText;
        private System.Windows.Forms.Label lbTotalLawText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}