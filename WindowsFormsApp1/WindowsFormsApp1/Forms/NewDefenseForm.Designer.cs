namespace WindowsFormsApp1.Forms
{
    partial class NewDefenseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewDefenseForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbBenefits = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.lbBuildTime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDiscount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbCost = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.cbDefense = new System.Windows.Forms.ComboBox();
            this.lbName = new System.Windows.Forms.Label();
            this.btBuy = new System.Windows.Forms.Button();
            this.rtbNote = new System.Windows.Forms.RichTextBox();
            this.dgDefense = new System.Windows.Forms.DataGridView();
            this.chbBuilt = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDefense)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lbBenefits, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.lbDescription, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lbBuildTime, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbDiscount, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbCost, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbName, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbDefense, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btBuy, 3, 10);
            this.tableLayoutPanel1.Controls.Add(this.rtbNote, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.chbBuilt, 2, 8);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(403, 445);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // lbBenefits
            // 
            this.lbBenefits.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBenefits.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lbBenefits, 4);
            this.lbBenefits.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBenefits.Location = new System.Drawing.Point(3, 258);
            this.lbBenefits.Name = "lbBenefits";
            this.lbBenefits.Size = new System.Drawing.Size(397, 36);
            this.lbBenefits.TabIndex = 20;
            this.lbBenefits.Text = "Benfits: Units defending a castle gain a +8 bonus to their Defense. Can Hold 4 se" +
    "ttlement Wealth holdings.";
            // 
            // lbDescription
            // 
            this.lbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDescription.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lbDescription, 4);
            this.lbDescription.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescription.Location = new System.Drawing.Point(3, 150);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(397, 108);
            this.lbDescription.TabIndex = 20;
            this.lbDescription.Text = resources.GetString("lbDescription.Text");
            // 
            // lbBuildTime
            // 
            this.lbBuildTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBuildTime.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lbBuildTime, 4);
            this.lbBuildTime.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBuildTime.Location = new System.Drawing.Point(3, 132);
            this.lbBuildTime.Name = "lbBuildTime";
            this.lbBuildTime.Size = new System.Drawing.Size(397, 18);
            this.lbBuildTime.TabIndex = 19;
            this.lbBuildTime.Text = "Build Time: 36+10d6 Months";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 28);
            this.label4.TabIndex = 11;
            this.label4.Text = "Notes:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 35);
            this.label2.TabIndex = 10;
            this.label2.Text = "Discount:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbDiscount
            // 
            this.tbDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDiscount.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDiscount.Location = new System.Drawing.Point(111, 100);
            this.tbDiscount.Name = "tbDiscount";
            this.tbDiscount.Size = new System.Drawing.Size(69, 29);
            this.tbDiscount.TabIndex = 12;
            this.tbDiscount.Text = "0";
            this.tbDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbDiscount.TextChanged += new System.EventHandler(this.TbDiscount_TextChanged);
            this.tbDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbDiscount_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(186, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 35);
            this.label3.TabIndex = 10;
            this.label3.Text = "Defense Cost:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbCost
            // 
            this.lbCost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCost.AutoSize = true;
            this.lbCost.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCost.Location = new System.Drawing.Point(330, 97);
            this.lbCost.Name = "lbCost";
            this.lbCost.Size = new System.Drawing.Size(70, 35);
            this.lbCost.TabIndex = 11;
            this.lbCost.Text = "0";
            this.lbCost.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 35);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.tbName, 3);
            this.tbName.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(111, 65);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(289, 29);
            this.tbName.TabIndex = 11;
            // 
            // cbDefense
            // 
            this.cbDefense.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.cbDefense, 4);
            this.cbDefense.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDefense.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDefense.FormattingEnabled = true;
            this.cbDefense.ImeMode = System.Windows.Forms.ImeMode.On;
            this.cbDefense.Items.AddRange(new object[] {
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
            this.cbDefense.Location = new System.Drawing.Point(3, 28);
            this.cbDefense.Name = "cbDefense";
            this.cbDefense.Size = new System.Drawing.Size(397, 31);
            this.cbDefense.TabIndex = 4;
            this.cbDefense.SelectedIndexChanged += new System.EventHandler(this.CbDefense_SelectedIndexChanged);
            // 
            // lbName
            // 
            this.lbName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbName.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lbName, 4);
            this.lbName.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(3, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(397, 25);
            this.lbName.TabIndex = 8;
            this.lbName.Text = "New Land Holding";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btBuy
            // 
            this.btBuy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btBuy.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuy.Location = new System.Drawing.Point(329, 404);
            this.btBuy.Margin = new System.Windows.Forms.Padding(2);
            this.btBuy.MaximumSize = new System.Drawing.Size(0, 40);
            this.btBuy.Name = "btBuy";
            this.btBuy.Size = new System.Drawing.Size(72, 40);
            this.btBuy.TabIndex = 51;
            this.btBuy.Text = "Buy";
            this.btBuy.UseVisualStyleBackColor = true;
            this.btBuy.Click += new System.EventHandler(this.BtBuy_Click);
            // 
            // rtbNote
            // 
            this.rtbNote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.rtbNote, 4);
            this.rtbNote.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbNote.Location = new System.Drawing.Point(3, 325);
            this.rtbNote.Name = "rtbNote";
            this.rtbNote.Size = new System.Drawing.Size(397, 74);
            this.rtbNote.TabIndex = 52;
            this.rtbNote.Text = "";
            // 
            // dgDefense
            // 
            this.dgDefense.AllowUserToAddRows = false;
            this.dgDefense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDefense.Location = new System.Drawing.Point(403, 284);
            this.dgDefense.Name = "dgDefense";
            this.dgDefense.Size = new System.Drawing.Size(40, 40);
            this.dgDefense.TabIndex = 12;
            this.dgDefense.Visible = false;
            // 
            // chbBuilt
            // 
            this.chbBuilt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chbBuilt.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.chbBuilt, 2);
            this.chbBuilt.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbBuilt.Location = new System.Drawing.Point(186, 297);
            this.chbBuilt.Name = "chbBuilt";
            this.chbBuilt.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.chbBuilt.Size = new System.Drawing.Size(214, 22);
            this.chbBuilt.TabIndex = 58;
            this.chbBuilt.Text = "Built";
            this.chbBuilt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chbBuilt.UseVisualStyleBackColor = true;
            // 
            // NewDefenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 469);
            this.Controls.Add(this.dgDefense);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "NewDefenseForm";
            this.Text = "NewDefenseForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDefense)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDiscount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbCost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ComboBox cbDefense;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button btBuy;
        private System.Windows.Forms.RichTextBox rtbNote;
        private System.Windows.Forms.DataGridView dgDefense;
        private System.Windows.Forms.Label lbBuildTime;
        private System.Windows.Forms.Label lbBenefits;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.CheckBox chbBuilt;
    }
}