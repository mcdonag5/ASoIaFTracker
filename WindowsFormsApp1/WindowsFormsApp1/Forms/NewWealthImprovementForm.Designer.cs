namespace WindowsFormsApp1.Forms
{
    partial class NewWealthImprovementForm
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
            this.lbBuildTime = new System.Windows.Forms.Label();
            this.lbRequirement = new System.Windows.Forms.Label();
            this.lbCost = new System.Windows.Forms.Label();
            this.dgImprovement = new System.Windows.Forms.DataGridView();
            this.dgHouse = new System.Windows.Forms.DataGridView();
            this.dgLand = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.cbImprovement = new System.Windows.Forms.ComboBox();
            this.lbBenefits = new System.Windows.Forms.Label();
            this.cbTradeHouse = new System.Windows.Forms.ComboBox();
            this.lbTradeHouse = new System.Windows.Forms.Label();
            this.chbBuilt = new System.Windows.Forms.CheckBox();
            this.btBuy = new System.Windows.Forms.Button();
            this.cbTradeLand = new System.Windows.Forms.ComboBox();
            this.lbTradeLand = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbDescription = new System.Windows.Forms.Label();
            this.dgTrade1 = new System.Windows.Forms.DataGridView();
            this.dgTrade2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgImprovement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgHouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgLand)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTrade1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTrade2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbBuildTime
            // 
            this.lbBuildTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBuildTime.AutoSize = true;
            this.lbBuildTime.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBuildTime.Location = new System.Drawing.Point(277, 87);
            this.lbBuildTime.Name = "lbBuildTime";
            this.lbBuildTime.Size = new System.Drawing.Size(405, 18);
            this.lbBuildTime.TabIndex = 19;
            // 
            // lbRequirement
            // 
            this.lbRequirement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbRequirement.AutoSize = true;
            this.lbRequirement.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRequirement.Location = new System.Drawing.Point(277, 112);
            this.lbRequirement.Name = "lbRequirement";
            this.lbRequirement.Size = new System.Drawing.Size(405, 18);
            this.lbRequirement.TabIndex = 54;
            // 
            // lbCost
            // 
            this.lbCost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCost.AutoSize = true;
            this.lbCost.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCost.Location = new System.Drawing.Point(277, 62);
            this.lbCost.Name = "lbCost";
            this.lbCost.Size = new System.Drawing.Size(405, 25);
            this.lbCost.TabIndex = 11;
            this.lbCost.Text = "0";
            this.lbCost.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgImprovement
            // 
            this.dgImprovement.AllowUserToAddRows = false;
            this.dgImprovement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgImprovement.Location = new System.Drawing.Point(336, 269);
            this.dgImprovement.Name = "dgImprovement";
            this.dgImprovement.Size = new System.Drawing.Size(40, 40);
            this.dgImprovement.TabIndex = 14;
            this.dgImprovement.Visible = false;
            // 
            // dgHouse
            // 
            this.dgHouse.AllowUserToAddRows = false;
            this.dgHouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHouse.Location = new System.Drawing.Point(344, 277);
            this.dgHouse.Name = "dgHouse";
            this.dgHouse.Size = new System.Drawing.Size(40, 40);
            this.dgHouse.TabIndex = 15;
            this.dgHouse.Visible = false;
            // 
            // dgLand
            // 
            this.dgLand.AllowUserToAddRows = false;
            this.dgLand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLand.Location = new System.Drawing.Point(352, 285);
            this.dgLand.Name = "dgLand";
            this.dgLand.Size = new System.Drawing.Size(40, 40);
            this.dgLand.TabIndex = 16;
            this.dgLand.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cost:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(268, 25);
            this.label6.TabIndex = 56;
            this.label6.Text = "Requirement:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(268, 25);
            this.label5.TabIndex = 55;
            this.label5.Text = "Build Time:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbName
            // 
            this.lbName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbName.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lbName, 2);
            this.lbName.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(3, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(679, 25);
            this.lbName.TabIndex = 8;
            this.lbName.Text = "New Land Holding";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbImprovement
            // 
            this.cbImprovement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.cbImprovement, 2);
            this.cbImprovement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbImprovement.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbImprovement.FormattingEnabled = true;
            this.cbImprovement.ImeMode = System.Windows.Forms.ImeMode.On;
            this.cbImprovement.Location = new System.Drawing.Point(3, 28);
            this.cbImprovement.Name = "cbImprovement";
            this.cbImprovement.Size = new System.Drawing.Size(679, 31);
            this.cbImprovement.TabIndex = 4;
            this.cbImprovement.SelectedIndexChanged += new System.EventHandler(this.CbImprovement_SelectedIndexChanged);
            // 
            // lbBenefits
            // 
            this.lbBenefits.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBenefits.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lbBenefits, 2);
            this.lbBenefits.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBenefits.Location = new System.Drawing.Point(3, 155);
            this.lbBenefits.Name = "lbBenefits";
            this.lbBenefits.Size = new System.Drawing.Size(679, 18);
            this.lbBenefits.TabIndex = 20;
            this.lbBenefits.Text = "Benfit";
            // 
            // cbTradeHouse
            // 
            this.cbTradeHouse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTradeHouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTradeHouse.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTradeHouse.FormattingEnabled = true;
            this.cbTradeHouse.ImeMode = System.Windows.Forms.ImeMode.On;
            this.cbTradeHouse.Location = new System.Drawing.Point(3, 201);
            this.cbTradeHouse.Name = "cbTradeHouse";
            this.cbTradeHouse.Size = new System.Drawing.Size(268, 31);
            this.cbTradeHouse.TabIndex = 15;
            this.cbTradeHouse.SelectedIndexChanged += new System.EventHandler(this.CbTradeHouse_SelectedIndexChanged);
            // 
            // lbTradeHouse
            // 
            this.lbTradeHouse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTradeHouse.AutoSize = true;
            this.lbTradeHouse.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTradeHouse.Location = new System.Drawing.Point(3, 173);
            this.lbTradeHouse.Name = "lbTradeHouse";
            this.lbTradeHouse.Size = new System.Drawing.Size(268, 25);
            this.lbTradeHouse.TabIndex = 56;
            this.lbTradeHouse.Text = "House:";
            this.lbTradeHouse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // chbBuilt
            // 
            this.chbBuilt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chbBuilt.AutoSize = true;
            this.chbBuilt.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbBuilt.Location = new System.Drawing.Point(277, 238);
            this.chbBuilt.Name = "chbBuilt";
            this.chbBuilt.Padding = new System.Windows.Forms.Padding(100, 0, 100, 0);
            this.chbBuilt.Size = new System.Drawing.Size(405, 22);
            this.chbBuilt.TabIndex = 57;
            this.chbBuilt.Text = "Built";
            this.chbBuilt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chbBuilt.UseVisualStyleBackColor = true;
            // 
            // btBuy
            // 
            this.btBuy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btBuy.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuy.Location = new System.Drawing.Point(276, 265);
            this.btBuy.Margin = new System.Windows.Forms.Padding(2);
            this.btBuy.MaximumSize = new System.Drawing.Size(0, 40);
            this.btBuy.Name = "btBuy";
            this.btBuy.Size = new System.Drawing.Size(407, 40);
            this.btBuy.TabIndex = 51;
            this.btBuy.Text = "Buy";
            this.btBuy.UseVisualStyleBackColor = true;
            this.btBuy.Click += new System.EventHandler(this.BtBuy_Click);
            // 
            // cbTradeLand
            // 
            this.cbTradeLand.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTradeLand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTradeLand.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTradeLand.FormattingEnabled = true;
            this.cbTradeLand.ImeMode = System.Windows.Forms.ImeMode.On;
            this.cbTradeLand.Location = new System.Drawing.Point(277, 201);
            this.cbTradeLand.Name = "cbTradeLand";
            this.cbTradeLand.Size = new System.Drawing.Size(405, 31);
            this.cbTradeLand.TabIndex = 15;
            this.cbTradeLand.SelectedIndexChanged += new System.EventHandler(this.cbTradeLand_SelectedIndexChanged);
            // 
            // lbTradeLand
            // 
            this.lbTradeLand.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTradeLand.AutoSize = true;
            this.lbTradeLand.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTradeLand.Location = new System.Drawing.Point(277, 173);
            this.lbTradeLand.Name = "lbTradeLand";
            this.lbTradeLand.Size = new System.Drawing.Size(405, 25);
            this.lbTradeLand.TabIndex = 56;
            this.lbTradeLand.Text = "Land: Trade Value 2";
            this.lbTradeLand.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.lbDescription, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btBuy, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.cbTradeLand, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.chbBuilt, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.cbImprovement, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbTradeLand, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.cbTradeHouse, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.lbCost, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbBuildTime, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbTradeHouse, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.lbRequirement, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbBenefits, 0, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 12;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(685, 307);
            this.tableLayoutPanel1.TabIndex = 58;
            // 
            // lbDescription
            // 
            this.lbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDescription.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lbDescription, 2);
            this.lbDescription.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescription.Location = new System.Drawing.Point(3, 137);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(679, 18);
            this.lbDescription.TabIndex = 59;
            this.lbDescription.Text = "Benfit";
            // 
            // dgTrade1
            // 
            this.dgTrade1.AllowUserToAddRows = false;
            this.dgTrade1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTrade1.Location = new System.Drawing.Point(335, 206);
            this.dgTrade1.Name = "dgTrade1";
            this.dgTrade1.Size = new System.Drawing.Size(40, 40);
            this.dgTrade1.TabIndex = 59;
            this.dgTrade1.Visible = false;
            // 
            // dgTrade2
            // 
            this.dgTrade2.AllowUserToAddRows = false;
            this.dgTrade2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTrade2.Location = new System.Drawing.Point(343, 214);
            this.dgTrade2.Name = "dgTrade2";
            this.dgTrade2.Size = new System.Drawing.Size(40, 40);
            this.dgTrade2.TabIndex = 60;
            this.dgTrade2.Visible = false;
            // 
            // NewWealthImprovementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(711, 452);
            this.Controls.Add(this.dgTrade2);
            this.Controls.Add(this.dgTrade1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dgLand);
            this.Controls.Add(this.dgHouse);
            this.Controls.Add(this.dgImprovement);
            this.Name = "NewWealthImprovementForm";
            this.Text = "NewWealthImprovement";
            ((System.ComponentModel.ISupportInitialize)(this.dgImprovement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgHouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgLand)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTrade1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTrade2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbCost;
        private System.Windows.Forms.Label lbBuildTime;
        private System.Windows.Forms.Label lbRequirement;
        private System.Windows.Forms.DataGridView dgImprovement;
        private System.Windows.Forms.DataGridView dgHouse;
        private System.Windows.Forms.DataGridView dgLand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btBuy;
        private System.Windows.Forms.ComboBox cbTradeLand;
        private System.Windows.Forms.CheckBox chbBuilt;
        private System.Windows.Forms.ComboBox cbImprovement;
        private System.Windows.Forms.Label lbTradeLand;
        private System.Windows.Forms.ComboBox cbTradeHouse;
        private System.Windows.Forms.Label lbTradeHouse;
        private System.Windows.Forms.Label lbBenefits;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.DataGridView dgTrade1;
        private System.Windows.Forms.DataGridView dgTrade2;
    }
}