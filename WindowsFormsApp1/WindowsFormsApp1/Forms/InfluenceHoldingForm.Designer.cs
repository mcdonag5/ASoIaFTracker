namespace WindowsFormsApp1.Forms
{
    partial class InfluenceHoldingForm
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbLandHolding = new System.Windows.Forms.ComboBox();
            this.lbTypeName = new System.Windows.Forms.Label();
            this.lbCost = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbType = new System.Windows.Forms.Label();
            this.lbDesc = new System.Windows.Forms.Label();
            this.lbBenfits = new System.Windows.Forms.Label();
            this.rtbNotes = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbDesc1 = new System.Windows.Forms.Label();
            this.lbName1 = new System.Windows.Forms.Label();
            this.lbName2 = new System.Windows.Forms.Label();
            this.lbDesc2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(647, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.rtbNotes, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lbBenfits, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbDesc, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbType, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbName, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbCost, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbTypeName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbLandHolding, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(623, 555);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // cbLandHolding
            // 
            this.cbLandHolding.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.cbLandHolding, 2);
            this.cbLandHolding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLandHolding.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLandHolding.FormattingEnabled = true;
            this.cbLandHolding.Location = new System.Drawing.Point(3, 3);
            this.cbLandHolding.Name = "cbLandHolding";
            this.cbLandHolding.Size = new System.Drawing.Size(617, 24);
            this.cbLandHolding.TabIndex = 2;
            // 
            // lbTypeName
            // 
            this.lbTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTypeName.AutoSize = true;
            this.lbTypeName.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTypeName.Location = new System.Drawing.Point(3, 30);
            this.lbTypeName.Name = "lbTypeName";
            this.lbTypeName.Size = new System.Drawing.Size(305, 25);
            this.lbTypeName.TabIndex = 2;
            this.lbTypeName.Text = "Maester - Maester Dasher";
            this.lbTypeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCost
            // 
            this.lbCost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCost.AutoSize = true;
            this.lbCost.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCost.Location = new System.Drawing.Point(314, 30);
            this.lbCost.Name = "lbCost";
            this.lbCost.Size = new System.Drawing.Size(306, 25);
            this.lbCost.TabIndex = 2;
            this.lbCost.Text = "Cost: 10 Wealth, 5 Defense";
            this.lbCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(3, 58);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(305, 31);
            this.tbName.TabIndex = 4;
            // 
            // lbType
            // 
            this.lbType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbType.AutoSize = true;
            this.lbType.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbType.Location = new System.Drawing.Point(314, 55);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(306, 37);
            this.lbType.TabIndex = 3;
            this.lbType.Text = "Personage";
            this.lbType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDesc
            // 
            this.lbDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDesc.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lbDesc, 2);
            this.lbDesc.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDesc.Location = new System.Drawing.Point(3, 92);
            this.lbDesc.Name = "lbDesc";
            this.lbDesc.Size = new System.Drawing.Size(617, 18);
            this.lbDesc.TabIndex = 3;
            this.lbDesc.Text = "fnxfnfsgnbfgxnfgnfghsnsfnfgnsfgnsfgns";
            // 
            // lbBenfits
            // 
            this.lbBenfits.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBenfits.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lbBenfits, 2);
            this.lbBenfits.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBenfits.Location = new System.Drawing.Point(3, 110);
            this.lbBenfits.Name = "lbBenfits";
            this.lbBenfits.Size = new System.Drawing.Size(617, 18);
            this.lbBenfits.TabIndex = 4;
            this.lbBenfits.Text = "fnxfnfsgnbfgxnfgnfghsnsfnfgnsfgnsfgns";
            // 
            // rtbNotes
            // 
            this.rtbNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.rtbNotes, 2);
            this.rtbNotes.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbNotes.Location = new System.Drawing.Point(3, 237);
            this.rtbNotes.Name = "rtbNotes";
            this.rtbNotes.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbNotes.Size = new System.Drawing.Size(617, 315);
            this.rtbNotes.TabIndex = 6;
            this.rtbNotes.Text = "";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lbDesc2, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lbDesc1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbName1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbName2, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 131);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(617, 100);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // lbDesc1
            // 
            this.lbDesc1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDesc1.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.lbDesc1, 2);
            this.lbDesc1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDesc1.Location = new System.Drawing.Point(3, 18);
            this.lbDesc1.Name = "lbDesc1";
            this.lbDesc1.Size = new System.Drawing.Size(611, 18);
            this.lbDesc1.TabIndex = 3;
            this.lbDesc1.Text = "fnxfnfsgnbfgxnfgnfghsnsfnfgnsfgnsfgns";
            // 
            // lbName1
            // 
            this.lbName1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbName1.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.lbName1, 2);
            this.lbName1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName1.Location = new System.Drawing.Point(3, 0);
            this.lbName1.Name = "lbName1";
            this.lbName1.Size = new System.Drawing.Size(611, 18);
            this.lbName1.TabIndex = 4;
            this.lbName1.Text = "fnxfnfsgnbfgxnfgnfghsnsfnfgnsfgnsfgns";
            // 
            // lbName2
            // 
            this.lbName2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbName2.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.lbName2, 2);
            this.lbName2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName2.Location = new System.Drawing.Point(3, 36);
            this.lbName2.Name = "lbName2";
            this.lbName2.Size = new System.Drawing.Size(611, 18);
            this.lbName2.TabIndex = 5;
            this.lbName2.Text = "fnxfnfsgnbfgxnfgnfghsnsfnfgnsfgnsfgns";
            // 
            // lbDesc2
            // 
            this.lbDesc2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDesc2.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.lbDesc2, 2);
            this.lbDesc2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDesc2.Location = new System.Drawing.Point(3, 54);
            this.lbDesc2.Name = "lbDesc2";
            this.lbDesc2.Size = new System.Drawing.Size(611, 18);
            this.lbDesc2.TabIndex = 6;
            this.lbDesc2.Text = "fnxfnfsgnbfgxnfgnfghsnsfnfgnsfgnsfgns";
            // 
            // InfluenceHoldingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 595);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "InfluenceHoldingForm";
            this.Text = "InfluenceHoldingForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cbLandHolding;
        private System.Windows.Forms.Label lbTypeName;
        private System.Windows.Forms.Label lbCost;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label lbDesc;
        private System.Windows.Forms.Label lbBenfits;
        private System.Windows.Forms.RichTextBox rtbNotes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbDesc2;
        private System.Windows.Forms.Label lbDesc1;
        private System.Windows.Forms.Label lbName1;
        private System.Windows.Forms.Label lbName2;
    }
}