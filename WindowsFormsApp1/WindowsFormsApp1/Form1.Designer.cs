namespace WindowsFormsApp1
{
    partial class Form1
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cbHouseRealm = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lbHouseResources = new System.Windows.Forms.Label();
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
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(670, 85);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(220, 29);
            this.textBox2.TabIndex = 7;
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
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(401, 85);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(188, 29);
            this.textBox3.TabIndex = 9;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(912, 540);
            this.Controls.Add(this.lbHouseResources);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.cbHouseRealm);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tbHouseSeatOfPower);
            this.Controls.Add(this.tbHouseName);
            this.Controls.Add(this.lbHouseLiege);
            this.Controls.Add(this.lbHouseLiegeLord);
            this.Controls.Add(this.lbHouseSeatOfPower);
            this.Controls.Add(this.lbHouseRealm);
            this.Controls.Add(this.lbHouseName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox cbHouseRealm;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lbHouseResources;
    }
}

