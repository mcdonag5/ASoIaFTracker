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
            this.dgCal1 = new System.Windows.Forms.DataGridView();
            this.pbHouseShield = new System.Windows.Forms.PictureBox();
            this.tlpMain.SuspendLayout();
            this.tlpHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCal1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHouseShield)).BeginInit();
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
            this.tlpMain.Location = new System.Drawing.Point(12, 12);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 4;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 260F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
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
            // dgCal1
            // 
            this.dgCal1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCal1.Location = new System.Drawing.Point(917, 109);
            this.dgCal1.Name = "dgCal1";
            this.dgCal1.Size = new System.Drawing.Size(240, 150);
            this.dgCal1.TabIndex = 1;
            this.dgCal1.Visible = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.dgCal1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHouseShield)).EndInit();
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
    }
}