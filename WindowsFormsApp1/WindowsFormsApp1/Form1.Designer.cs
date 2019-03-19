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
            this.label1 = new System.Windows.Forms.Label();
            this.dgHouseDetails = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgHouseDetails)).BeginInit();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 184);
            this.label1.TabIndex = 12;
            this.label1.Text = "Spare\r\n000\r\n000\r\n000\r\n000\r\n000\r\n000\r\n000";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgHouseDetails
            // 
            this.dgHouseDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHouseDetails.Location = new System.Drawing.Point(650, 368);
            this.dgHouseDetails.Name = "dgHouseDetails";
            this.dgHouseDetails.Size = new System.Drawing.Size(240, 150);
            this.dgHouseDetails.TabIndex = 13;
            this.dgHouseDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgHouseDetails_CellContentClick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(912, 540);
            this.Controls.Add(this.dgHouseDetails);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgHouseDetails;
    }
}

