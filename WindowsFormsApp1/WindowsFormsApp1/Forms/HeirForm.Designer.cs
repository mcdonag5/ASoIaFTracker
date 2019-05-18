namespace WindowsFormsApp1.Forms
{
    partial class HeirForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeirForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rtbNotes = new System.Windows.Forms.RichTextBox();
            this.lbTypeName = new System.Windows.Forms.Label();
            this.lbCost = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.cbHeir = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.dgHeir = new System.Windows.Forms.DataGridView();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgHeir)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.rtbNotes, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbTypeName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbCost, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbName, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbHeir, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(469, 268);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // rtbNotes
            // 
            this.rtbNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.rtbNotes, 2);
            this.rtbNotes.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbNotes.Location = new System.Drawing.Point(3, 102);
            this.rtbNotes.Name = "rtbNotes";
            this.rtbNotes.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbNotes.Size = new System.Drawing.Size(463, 163);
            this.rtbNotes.TabIndex = 8;
            this.rtbNotes.Text = "";
            // 
            // lbTypeName
            // 
            this.lbTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTypeName.AutoSize = true;
            this.lbTypeName.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTypeName.Location = new System.Drawing.Point(3, 37);
            this.lbTypeName.Name = "lbTypeName";
            this.lbTypeName.Size = new System.Drawing.Size(228, 25);
            this.lbTypeName.TabIndex = 5;
            this.lbTypeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCost
            // 
            this.lbCost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCost.AutoSize = true;
            this.lbCost.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCost.Location = new System.Drawing.Point(237, 37);
            this.lbCost.Name = "lbCost";
            this.lbCost.Size = new System.Drawing.Size(229, 25);
            this.lbCost.TabIndex = 6;
            this.lbCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.tbName, 2);
            this.tbName.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(3, 65);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(463, 31);
            this.tbName.TabIndex = 7;
            // 
            // cbHeir
            // 
            this.cbHeir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.cbHeir, 2);
            this.cbHeir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHeir.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHeir.FormattingEnabled = true;
            this.cbHeir.ImeMode = System.Windows.Forms.ImeMode.On;
            this.cbHeir.Items.AddRange(new object[] {
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
            this.cbHeir.Location = new System.Drawing.Point(3, 3);
            this.cbHeir.Name = "cbHeir";
            this.cbHeir.Size = new System.Drawing.Size(463, 31);
            this.cbHeir.TabIndex = 4;
            this.cbHeir.SelectedIndexChanged += new System.EventHandler(this.CbHeir_SelectedIndexChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNew,
            this.tsbDelete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(493, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // dgHeir
            // 
            this.dgHeir.AllowUserToAddRows = false;
            this.dgHeir.AllowUserToDeleteRows = false;
            this.dgHeir.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgHeir.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgHeir.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgHeir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgHeir.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgHeir.Location = new System.Drawing.Point(227, 138);
            this.dgHeir.Name = "dgHeir";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgHeir.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgHeir.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgHeir.Size = new System.Drawing.Size(38, 32);
            this.dgHeir.TabIndex = 34;
            this.dgHeir.Visible = false;
            // 
            // tsbNew
            // 
            this.tsbNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbNew.Image = ((System.Drawing.Image)(resources.GetObject("tsbNew.Image")));
            this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbNew.Size = new System.Drawing.Size(70, 22);
            this.tsbNew.Text = "New Heir";
            this.tsbNew.Click += new System.EventHandler(this.tsbNew_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbDelete.Size = new System.Drawing.Size(79, 22);
            this.tsbDelete.Text = "Delete Heir";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // HeirForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 308);
            this.Controls.Add(this.dgHeir);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "HeirForm";
            this.Text = "HeirForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HeirForm_FormClosing);
            this.Load += new System.EventHandler(this.HeirForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgHeir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ComboBox cbHeir;
        private System.Windows.Forms.Label lbTypeName;
        private System.Windows.Forms.Label lbCost;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.RichTextBox rtbNotes;
        private System.Windows.Forms.DataGridView dgHeir;
    }
}