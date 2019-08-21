namespace WindowsFormsApp1.Forms
{
    partial class ViewHoldings
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cbHoldingType = new System.Windows.Forms.ComboBox();
            this.cbDoubleHoldingType = new System.Windows.Forms.ComboBox();
            this.cbDoubleHoldingName = new System.Windows.Forms.ComboBox();
            this.cbSoloHoldingName = new System.Windows.Forms.ComboBox();
            this.dgHoldings = new System.Windows.Forms.DataGridView();
            this.lbCost = new System.Windows.Forms.Label();
            this.lbCostDetails = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.lbBuildTime = new System.Windows.Forms.Label();
            this.lbBuildTimeDetails = new System.Windows.Forms.Label();
            this.lbDisciplineModifier = new System.Windows.Forms.Label();
            this.lbKeyAbilities = new System.Windows.Forms.Label();
            this.lbDisciplineModifierDetail = new System.Windows.Forms.Label();
            this.lbKeyAbilitiesDetails = new System.Windows.Forms.Label();
            this.lbBaseMovement = new System.Windows.Forms.Label();
            this.lbBaseMovementDetails = new System.Windows.Forms.Label();
            this.lbRequirement = new System.Windows.Forms.Label();
            this.lbRequirementDetails = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgHoldings)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lbRequirementDetails, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.lbRequirement, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.lbBaseMovementDetails, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lbBaseMovement, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.lbKeyAbilitiesDetails, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lbDisciplineModifierDetail, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbKeyAbilities, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lbDisciplineModifier, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbBuildTimeDetails, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbBuildTime, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cbHoldingType, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbDoubleHoldingType, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbDoubleHoldingName, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbSoloHoldingName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbCost, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbCostDetails, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbDescription, 0, 9);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 30);
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 400);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // cbHoldingType
            // 
            this.cbHoldingType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.cbHoldingType, 2);
            this.cbHoldingType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHoldingType.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHoldingType.FormattingEnabled = true;
            this.cbHoldingType.ImeMode = System.Windows.Forms.ImeMode.On;
            this.cbHoldingType.Items.AddRange(new object[] {
            "Land",
            "Land Features",
            "Defense",
            "Unit Type",
            "Wealth",
            "Influence"});
            this.cbHoldingType.Location = new System.Drawing.Point(3, 3);
            this.cbHoldingType.Name = "cbHoldingType";
            this.cbHoldingType.Size = new System.Drawing.Size(794, 31);
            this.cbHoldingType.TabIndex = 12;
            this.cbHoldingType.SelectedIndexChanged += new System.EventHandler(this.cbHoldingType_SelectedIndexChanged);
            // 
            // cbDoubleHoldingType
            // 
            this.cbDoubleHoldingType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDoubleHoldingType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDoubleHoldingType.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDoubleHoldingType.FormattingEnabled = true;
            this.cbDoubleHoldingType.ImeMode = System.Windows.Forms.ImeMode.On;
            this.cbDoubleHoldingType.Items.AddRange(new object[] {
            "Estate",
            "Lifestyle",
            "Personage",
            "Settlement"});
            this.cbDoubleHoldingType.Location = new System.Drawing.Point(3, 77);
            this.cbDoubleHoldingType.Name = "cbDoubleHoldingType";
            this.cbDoubleHoldingType.Size = new System.Drawing.Size(214, 31);
            this.cbDoubleHoldingType.TabIndex = 82;
            this.cbDoubleHoldingType.SelectedIndexChanged += new System.EventHandler(this.cbDoubleHoldingType_SelectedIndexChanged);
            // 
            // cbDoubleHoldingName
            // 
            this.cbDoubleHoldingName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDoubleHoldingName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDoubleHoldingName.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDoubleHoldingName.FormattingEnabled = true;
            this.cbDoubleHoldingName.ImeMode = System.Windows.Forms.ImeMode.On;
            this.cbDoubleHoldingName.Items.AddRange(new object[] {
            "Estate",
            "Lifestyle",
            "Personage",
            "Settlement"});
            this.cbDoubleHoldingName.Location = new System.Drawing.Point(223, 77);
            this.cbDoubleHoldingName.Name = "cbDoubleHoldingName";
            this.cbDoubleHoldingName.Size = new System.Drawing.Size(574, 31);
            this.cbDoubleHoldingName.TabIndex = 83;
            this.cbDoubleHoldingName.SelectedIndexChanged += new System.EventHandler(this.cbDoubleHoldingName_SelectedIndexChanged);
            // 
            // cbSoloHoldingName
            // 
            this.cbSoloHoldingName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.cbSoloHoldingName, 2);
            this.cbSoloHoldingName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSoloHoldingName.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSoloHoldingName.FormattingEnabled = true;
            this.cbSoloHoldingName.ImeMode = System.Windows.Forms.ImeMode.On;
            this.cbSoloHoldingName.Items.AddRange(new object[] {
            "Estate",
            "Lifestyle",
            "Personage",
            "Settlement"});
            this.cbSoloHoldingName.Location = new System.Drawing.Point(3, 40);
            this.cbSoloHoldingName.Name = "cbSoloHoldingName";
            this.cbSoloHoldingName.Size = new System.Drawing.Size(794, 31);
            this.cbSoloHoldingName.TabIndex = 84;
            this.cbSoloHoldingName.SelectedIndexChanged += new System.EventHandler(this.cbSoloHoldingName_SelectedIndexChanged);
            // 
            // dgHoldings
            // 
            this.dgHoldings.AllowUserToAddRows = false;
            this.dgHoldings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHoldings.Location = new System.Drawing.Point(568, 523);
            this.dgHoldings.Name = "dgHoldings";
            this.dgHoldings.Size = new System.Drawing.Size(40, 40);
            this.dgHoldings.TabIndex = 15;
            this.dgHoldings.Visible = false;
            // 
            // lbCost
            // 
            this.lbCost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCost.AutoSize = true;
            this.lbCost.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCost.Location = new System.Drawing.Point(3, 111);
            this.lbCost.Name = "lbCost";
            this.lbCost.Size = new System.Drawing.Size(214, 25);
            this.lbCost.TabIndex = 85;
            this.lbCost.Text = "Cost:";
            this.lbCost.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbCostDetails
            // 
            this.lbCostDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCostDetails.AutoSize = true;
            this.lbCostDetails.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCostDetails.Location = new System.Drawing.Point(223, 111);
            this.lbCostDetails.Name = "lbCostDetails";
            this.lbCostDetails.Size = new System.Drawing.Size(574, 25);
            this.lbCostDetails.TabIndex = 86;
            this.lbCostDetails.Text = "10 Land";
            this.lbCostDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbDescription
            // 
            this.lbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDescription.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lbDescription, 2);
            this.lbDescription.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescription.Location = new System.Drawing.Point(3, 261);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(794, 18);
            this.lbDescription.TabIndex = 87;
            this.lbDescription.Text = "10 Land";
            this.lbDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbBuildTime
            // 
            this.lbBuildTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBuildTime.AutoSize = true;
            this.lbBuildTime.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBuildTime.Location = new System.Drawing.Point(3, 136);
            this.lbBuildTime.Name = "lbBuildTime";
            this.lbBuildTime.Size = new System.Drawing.Size(214, 25);
            this.lbBuildTime.TabIndex = 86;
            this.lbBuildTime.Text = "Build Time:";
            this.lbBuildTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbBuildTimeDetails
            // 
            this.lbBuildTimeDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBuildTimeDetails.AutoSize = true;
            this.lbBuildTimeDetails.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBuildTimeDetails.Location = new System.Drawing.Point(223, 136);
            this.lbBuildTimeDetails.Name = "lbBuildTimeDetails";
            this.lbBuildTimeDetails.Size = new System.Drawing.Size(574, 25);
            this.lbBuildTimeDetails.TabIndex = 87;
            this.lbBuildTimeDetails.Text = "10d6 months";
            this.lbBuildTimeDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbDisciplineModifier
            // 
            this.lbDisciplineModifier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDisciplineModifier.AutoSize = true;
            this.lbDisciplineModifier.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDisciplineModifier.Location = new System.Drawing.Point(3, 161);
            this.lbDisciplineModifier.Name = "lbDisciplineModifier";
            this.lbDisciplineModifier.Size = new System.Drawing.Size(214, 25);
            this.lbDisciplineModifier.TabIndex = 87;
            this.lbDisciplineModifier.Text = "Discipline Modifier:";
            this.lbDisciplineModifier.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbKeyAbilities
            // 
            this.lbKeyAbilities.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbKeyAbilities.AutoSize = true;
            this.lbKeyAbilities.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKeyAbilities.Location = new System.Drawing.Point(3, 186);
            this.lbKeyAbilities.Name = "lbKeyAbilities";
            this.lbKeyAbilities.Size = new System.Drawing.Size(214, 25);
            this.lbKeyAbilities.TabIndex = 87;
            this.lbKeyAbilities.Text = "Key Abilities:";
            this.lbKeyAbilities.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbDisciplineModifierDetail
            // 
            this.lbDisciplineModifierDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDisciplineModifierDetail.AutoSize = true;
            this.lbDisciplineModifierDetail.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDisciplineModifierDetail.Location = new System.Drawing.Point(223, 161);
            this.lbDisciplineModifierDetail.Name = "lbDisciplineModifierDetail";
            this.lbDisciplineModifierDetail.Size = new System.Drawing.Size(574, 25);
            this.lbDisciplineModifierDetail.TabIndex = 88;
            this.lbDisciplineModifierDetail.Text = "10d6 months";
            this.lbDisciplineModifierDetail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbKeyAbilitiesDetails
            // 
            this.lbKeyAbilitiesDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbKeyAbilitiesDetails.AutoSize = true;
            this.lbKeyAbilitiesDetails.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKeyAbilitiesDetails.Location = new System.Drawing.Point(223, 186);
            this.lbKeyAbilitiesDetails.Name = "lbKeyAbilitiesDetails";
            this.lbKeyAbilitiesDetails.Size = new System.Drawing.Size(574, 25);
            this.lbKeyAbilitiesDetails.TabIndex = 88;
            this.lbKeyAbilitiesDetails.Text = "10d6 months";
            this.lbKeyAbilitiesDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbBaseMovement
            // 
            this.lbBaseMovement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBaseMovement.AutoSize = true;
            this.lbBaseMovement.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBaseMovement.Location = new System.Drawing.Point(3, 211);
            this.lbBaseMovement.Name = "lbBaseMovement";
            this.lbBaseMovement.Size = new System.Drawing.Size(214, 25);
            this.lbBaseMovement.TabIndex = 88;
            this.lbBaseMovement.Text = "Base Movement:";
            this.lbBaseMovement.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbBaseMovementDetails
            // 
            this.lbBaseMovementDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBaseMovementDetails.AutoSize = true;
            this.lbBaseMovementDetails.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBaseMovementDetails.Location = new System.Drawing.Point(223, 211);
            this.lbBaseMovementDetails.Name = "lbBaseMovementDetails";
            this.lbBaseMovementDetails.Size = new System.Drawing.Size(574, 25);
            this.lbBaseMovementDetails.TabIndex = 89;
            this.lbBaseMovementDetails.Text = "10d6 months";
            this.lbBaseMovementDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbRequirement
            // 
            this.lbRequirement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbRequirement.AutoSize = true;
            this.lbRequirement.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRequirement.Location = new System.Drawing.Point(3, 236);
            this.lbRequirement.Name = "lbRequirement";
            this.lbRequirement.Size = new System.Drawing.Size(214, 25);
            this.lbRequirement.TabIndex = 89;
            this.lbRequirement.Text = "Requirement:";
            this.lbRequirement.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbRequirementDetails
            // 
            this.lbRequirementDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbRequirementDetails.AutoSize = true;
            this.lbRequirementDetails.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRequirementDetails.Location = new System.Drawing.Point(223, 236);
            this.lbRequirementDetails.Name = "lbRequirementDetails";
            this.lbRequirementDetails.Size = new System.Drawing.Size(574, 25);
            this.lbRequirementDetails.TabIndex = 90;
            this.lbRequirementDetails.Text = "10d6 months";
            this.lbRequirementDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ViewHoldings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 670);
            this.Controls.Add(this.dgHoldings);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ViewHoldings";
            this.Text = "View Holdings";
            this.Load += new System.EventHandler(this.ViewHoldings_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgHoldings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ComboBox cbHoldingType;
        private System.Windows.Forms.ComboBox cbDoubleHoldingType;
        private System.Windows.Forms.ComboBox cbDoubleHoldingName;
        private System.Windows.Forms.ComboBox cbSoloHoldingName;
        private System.Windows.Forms.DataGridView dgHoldings;
        private System.Windows.Forms.Label lbCost;
        private System.Windows.Forms.Label lbCostDetails;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label lbBuildTimeDetails;
        private System.Windows.Forms.Label lbBuildTime;
        private System.Windows.Forms.Label lbKeyAbilitiesDetails;
        private System.Windows.Forms.Label lbDisciplineModifierDetail;
        private System.Windows.Forms.Label lbKeyAbilities;
        private System.Windows.Forms.Label lbDisciplineModifier;
        private System.Windows.Forms.Label lbBaseMovementDetails;
        private System.Windows.Forms.Label lbBaseMovement;
        private System.Windows.Forms.Label lbRequirementDetails;
        private System.Windows.Forms.Label lbRequirement;
    }
}