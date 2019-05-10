namespace WindowsFormsApp1.Forms
{
    partial class NewLandFeatureForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.cbLandFeature = new System.Windows.Forms.ComboBox();
            this.lbName = new System.Windows.Forms.Label();
            this.btBuy = new System.Windows.Forms.Button();
            this.rtbNote = new System.Windows.Forms.RichTextBox();
            this.dgLandFeature = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLandFeature)).BeginInit();
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
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbName, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbLandFeature, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btBuy, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.rtbNote, 0, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(403, 251);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Notes:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 35);
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
            this.tbName.Location = new System.Drawing.Point(84, 60);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(316, 29);
            this.tbName.TabIndex = 11;
            // 
            // cbLandFeature
            // 
            this.cbLandFeature.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.cbLandFeature, 4);
            this.cbLandFeature.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLandFeature.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLandFeature.FormattingEnabled = true;
            this.cbLandFeature.ImeMode = System.Windows.Forms.ImeMode.On;
            this.cbLandFeature.Items.AddRange(new object[] {
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
            this.cbLandFeature.Location = new System.Drawing.Point(3, 23);
            this.cbLandFeature.Name = "cbLandFeature";
            this.cbLandFeature.Size = new System.Drawing.Size(397, 31);
            this.cbLandFeature.TabIndex = 4;
            this.cbLandFeature.SelectedIndexChanged += new System.EventHandler(this.cbLandFeature_SelectedIndexChanged);
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
            this.lbName.Size = new System.Drawing.Size(397, 20);
            this.lbName.TabIndex = 8;
            this.lbName.Text = "New Land Feature";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btBuy
            // 
            this.btBuy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btBuy.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuy.Location = new System.Drawing.Point(323, 199);
            this.btBuy.Margin = new System.Windows.Forms.Padding(2);
            this.btBuy.MaximumSize = new System.Drawing.Size(0, 40);
            this.btBuy.Name = "btBuy";
            this.btBuy.Size = new System.Drawing.Size(78, 40);
            this.btBuy.TabIndex = 51;
            this.btBuy.Text = "Buy";
            this.btBuy.UseVisualStyleBackColor = true;
            this.btBuy.Click += new System.EventHandler(this.btBuy_Click);
            // 
            // rtbNote
            // 
            this.rtbNote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.rtbNote, 4);
            this.rtbNote.Enabled = false;
            this.rtbNote.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbNote.Location = new System.Drawing.Point(3, 120);
            this.rtbNote.Name = "rtbNote";
            this.rtbNote.Size = new System.Drawing.Size(397, 74);
            this.rtbNote.TabIndex = 52;
            this.rtbNote.Text = "";
            // 
            // dgLandFeature
            // 
            this.dgLandFeature.AllowUserToAddRows = false;
            this.dgLandFeature.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLandFeature.Location = new System.Drawing.Point(655, 240);
            this.dgLandFeature.Name = "dgLandFeature";
            this.dgLandFeature.Size = new System.Drawing.Size(40, 40);
            this.dgLandFeature.TabIndex = 11;
            this.dgLandFeature.Visible = false;
            // 
            // NewLandFeatureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 275);
            this.Controls.Add(this.dgLandFeature);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "NewLandFeatureForm";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLandFeature)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ComboBox cbLandFeature;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button btBuy;
        private System.Windows.Forms.RichTextBox rtbNote;
        private System.Windows.Forms.DataGridView dgLandFeature;
    }
}