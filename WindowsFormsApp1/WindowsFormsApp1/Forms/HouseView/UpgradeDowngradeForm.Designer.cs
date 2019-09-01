namespace WindowsFormsApp1.Forms.HouseView
{
    partial class UpgradeDowngradeForm
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
            this.lbDescription = new System.Windows.Forms.Label();
            this.lbSpacesDetails = new System.Windows.Forms.Label();
            this.lbSpaces = new System.Windows.Forms.Label();
            this.lbCost = new System.Windows.Forms.Label();
            this.btUpDown = new System.Windows.Forms.Button();
            this.cbHolding = new System.Windows.Forms.ComboBox();
            this.lbCostDetails = new System.Windows.Forms.Label();
            this.dgCurrent = new System.Windows.Forms.DataGridView();
            this.dgNewList = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCurrent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgNewList)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 141F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lbDescription, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbSpacesDetails, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbSpaces, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbCost, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btUpDown, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cbHolding, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbCostDetails, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(631, 188);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbDescription
            // 
            this.lbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDescription.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lbDescription, 2);
            this.lbDescription.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescription.Location = new System.Drawing.Point(4, 106);
            this.lbDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(623, 24);
            this.lbDescription.TabIndex = 88;
            this.lbDescription.Text = "10 Land";
            this.lbDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbSpacesDetails
            // 
            this.lbSpacesDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSpacesDetails.AutoSize = true;
            this.lbSpacesDetails.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSpacesDetails.Location = new System.Drawing.Point(145, 75);
            this.lbSpacesDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSpacesDetails.Name = "lbSpacesDetails";
            this.lbSpacesDetails.Size = new System.Drawing.Size(482, 31);
            this.lbSpacesDetails.TabIndex = 88;
            this.lbSpacesDetails.Text = "10 Land";
            this.lbSpacesDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbSpaces
            // 
            this.lbSpaces.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSpaces.AutoSize = true;
            this.lbSpaces.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSpaces.Location = new System.Drawing.Point(4, 75);
            this.lbSpaces.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSpaces.Name = "lbSpaces";
            this.lbSpaces.Size = new System.Drawing.Size(133, 31);
            this.lbSpaces.TabIndex = 87;
            this.lbSpaces.Text = "Spaces:";
            this.lbSpaces.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbCost
            // 
            this.lbCost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCost.AutoSize = true;
            this.lbCost.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCost.Location = new System.Drawing.Point(4, 44);
            this.lbCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCost.Name = "lbCost";
            this.lbCost.Size = new System.Drawing.Size(133, 31);
            this.lbCost.TabIndex = 86;
            this.lbCost.Text = "Cost:";
            this.lbCost.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btUpDown
            // 
            this.btUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.btUpDown, 2);
            this.btUpDown.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpDown.Location = new System.Drawing.Point(542, 134);
            this.btUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.btUpDown.Name = "btUpDown";
            this.btUpDown.Size = new System.Drawing.Size(85, 37);
            this.btUpDown.TabIndex = 77;
            this.btUpDown.Text = "Create";
            this.btUpDown.UseVisualStyleBackColor = true;
            // 
            // cbHolding
            // 
            this.cbHolding.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.cbHolding, 2);
            this.cbHolding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHolding.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHolding.FormattingEnabled = true;
            this.cbHolding.Location = new System.Drawing.Point(4, 4);
            this.cbHolding.Margin = new System.Windows.Forms.Padding(4);
            this.cbHolding.Name = "cbHolding";
            this.cbHolding.Size = new System.Drawing.Size(623, 35);
            this.cbHolding.TabIndex = 2;
            this.cbHolding.SelectedIndexChanged += new System.EventHandler(this.cbHolding_SelectedIndexChanged);
            // 
            // lbCostDetails
            // 
            this.lbCostDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCostDetails.AutoSize = true;
            this.lbCostDetails.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCostDetails.Location = new System.Drawing.Point(145, 44);
            this.lbCostDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCostDetails.Name = "lbCostDetails";
            this.lbCostDetails.Size = new System.Drawing.Size(482, 31);
            this.lbCostDetails.TabIndex = 87;
            this.lbCostDetails.Text = "10 Land";
            this.lbCostDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgCurrent
            // 
            this.dgCurrent.AllowUserToAddRows = false;
            this.dgCurrent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCurrent.Location = new System.Drawing.Point(301, 82);
            this.dgCurrent.Margin = new System.Windows.Forms.Padding(4);
            this.dgCurrent.Name = "dgCurrent";
            this.dgCurrent.Size = new System.Drawing.Size(53, 49);
            this.dgCurrent.TabIndex = 17;
            this.dgCurrent.Visible = false;
            // 
            // dgNewList
            // 
            this.dgNewList.AllowUserToAddRows = false;
            this.dgNewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNewList.Location = new System.Drawing.Point(309, 90);
            this.dgNewList.Margin = new System.Windows.Forms.Padding(4);
            this.dgNewList.Name = "dgNewList";
            this.dgNewList.Size = new System.Drawing.Size(53, 49);
            this.dgNewList.TabIndex = 18;
            this.dgNewList.Visible = false;
            // 
            // UpgradeDowngradeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 212);
            this.Controls.Add(this.dgNewList);
            this.Controls.Add(this.dgCurrent);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UpgradeDowngradeForm";
            this.Text = "UpgradeDowngradeForm";
            this.Load += new System.EventHandler(this.UpgradeDowngradeForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCurrent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgNewList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cbHolding;
        private System.Windows.Forms.Button btUpDown;
        private System.Windows.Forms.Label lbCost;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label lbSpacesDetails;
        private System.Windows.Forms.Label lbSpaces;
        private System.Windows.Forms.Label lbCostDetails;
        private System.Windows.Forms.DataGridView dgCurrent;
        private System.Windows.Forms.DataGridView dgNewList;
    }
}