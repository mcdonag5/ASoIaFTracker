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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rtbNotes = new System.Windows.Forms.RichTextBox();
            this.lbBenfits = new System.Windows.Forms.Label();
            this.lbDesc = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbCost = new System.Windows.Forms.Label();
            this.lbTypeName = new System.Windows.Forms.Label();
            this.cbInfluence = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgInfluence = new System.Windows.Forms.DataGridView();
            this.dgInfluenceImprovemnt = new System.Windows.Forms.DataGridView();
            this.lbName2 = new System.Windows.Forms.Label();
            this.lbName1 = new System.Windows.Forms.Label();
            this.lbDesc1 = new System.Windows.Forms.Label();
            this.lbDesc2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInfluence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgInfluenceImprovemnt)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(647, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
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
            this.tableLayoutPanel1.Controls.Add(this.cbInfluence, 0, 0);
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(623, 555);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // rtbNotes
            // 
            this.rtbNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.rtbNotes, 2);
            this.rtbNotes.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbNotes.Location = new System.Drawing.Point(3, 237);
            this.rtbNotes.Name = "rtbNotes";
            this.rtbNotes.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbNotes.Size = new System.Drawing.Size(617, 100);
            this.rtbNotes.TabIndex = 6;
            this.rtbNotes.Text = "";
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
            this.lbType.Text = "Influence Holding";
            this.lbType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // cbInfluence
            // 
            this.cbInfluence.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.cbInfluence, 2);
            this.cbInfluence.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInfluence.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbInfluence.FormattingEnabled = true;
            this.cbInfluence.Location = new System.Drawing.Point(3, 3);
            this.cbInfluence.Name = "cbInfluence";
            this.cbInfluence.Size = new System.Drawing.Size(617, 24);
            this.cbInfluence.TabIndex = 2;
            this.cbInfluence.SelectedIndexChanged += new System.EventHandler(this.cbInfluence_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
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
            // dgInfluence
            // 
            this.dgInfluence.AllowUserToAddRows = false;
            this.dgInfluence.AllowUserToDeleteRows = false;
            this.dgInfluence.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgInfluence.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle31.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgInfluence.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle31;
            this.dgInfluence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle32.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgInfluence.DefaultCellStyle = dataGridViewCellStyle32;
            this.dgInfluence.Location = new System.Drawing.Point(304, 282);
            this.dgInfluence.Name = "dgInfluence";
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgInfluence.RowHeadersDefaultCellStyle = dataGridViewCellStyle33;
            this.dgInfluence.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgInfluence.Size = new System.Drawing.Size(38, 32);
            this.dgInfluence.TabIndex = 34;
            this.dgInfluence.Visible = false;
            // 
            // dgInfluenceImprovemnt
            // 
            this.dgInfluenceImprovemnt.AllowUserToAddRows = false;
            this.dgInfluenceImprovemnt.AllowUserToDeleteRows = false;
            this.dgInfluenceImprovemnt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgInfluenceImprovemnt.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle34.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgInfluenceImprovemnt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle34;
            this.dgInfluenceImprovemnt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle35.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle35.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgInfluenceImprovemnt.DefaultCellStyle = dataGridViewCellStyle35;
            this.dgInfluenceImprovemnt.Location = new System.Drawing.Point(623, 317);
            this.dgInfluenceImprovemnt.Name = "dgInfluenceImprovemnt";
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle36.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle36.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgInfluenceImprovemnt.RowHeadersDefaultCellStyle = dataGridViewCellStyle36;
            this.dgInfluenceImprovemnt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgInfluenceImprovemnt.Size = new System.Drawing.Size(38, 32);
            this.dgInfluenceImprovemnt.TabIndex = 35;
            this.dgInfluenceImprovemnt.Visible = false;
            // 
            // lbName2
            // 
            this.lbName2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbName2.AutoSize = true;
            this.lbName2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName2.Location = new System.Drawing.Point(3, 36);
            this.lbName2.Name = "lbName2";
            this.lbName2.Size = new System.Drawing.Size(611, 18);
            this.lbName2.TabIndex = 5;
            this.lbName2.Text = "fnxfnfsgnbfgxnfgnfghsnsfnfgnsfgnsfgns";
            // 
            // lbName1
            // 
            this.lbName1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbName1.AutoSize = true;
            this.lbName1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName1.Location = new System.Drawing.Point(3, 0);
            this.lbName1.Name = "lbName1";
            this.lbName1.Size = new System.Drawing.Size(611, 18);
            this.lbName1.TabIndex = 4;
            this.lbName1.Text = "fnxfnfsgnbfgxnfgnfghsnsfnfgnsfgnsfgns";
            // 
            // lbDesc1
            // 
            this.lbDesc1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDesc1.AutoSize = true;
            this.lbDesc1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDesc1.Location = new System.Drawing.Point(3, 18);
            this.lbDesc1.Name = "lbDesc1";
            this.lbDesc1.Size = new System.Drawing.Size(611, 18);
            this.lbDesc1.TabIndex = 3;
            this.lbDesc1.Text = "fnxfnfsgnbfgxnfgnfghsnsfnfgnsfgnsfgns";
            // 
            // lbDesc2
            // 
            this.lbDesc2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDesc2.AutoSize = true;
            this.lbDesc2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDesc2.Location = new System.Drawing.Point(3, 54);
            this.lbDesc2.Name = "lbDesc2";
            this.lbDesc2.Size = new System.Drawing.Size(611, 46);
            this.lbDesc2.TabIndex = 6;
            this.lbDesc2.Text = "fnxfnfsgnbfgxnfgnfghsnsfnfgnsfgnsfgns";
            // 
            // InfluenceHoldingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 595);
            this.Controls.Add(this.dgInfluenceImprovemnt);
            this.Controls.Add(this.dgInfluence);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "InfluenceHoldingForm";
            this.Text = "InfluenceHoldingForm";
            this.Load += new System.EventHandler(this.InfluenceHoldingForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInfluence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgInfluenceImprovemnt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cbInfluence;
        private System.Windows.Forms.Label lbTypeName;
        private System.Windows.Forms.Label lbCost;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label lbDesc;
        private System.Windows.Forms.Label lbBenfits;
        private System.Windows.Forms.RichTextBox rtbNotes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dgInfluence;
        private System.Windows.Forms.DataGridView dgInfluenceImprovemnt;
        private System.Windows.Forms.Label lbDesc2;
        private System.Windows.Forms.Label lbDesc1;
        private System.Windows.Forms.Label lbName1;
        private System.Windows.Forms.Label lbName2;
    }
}