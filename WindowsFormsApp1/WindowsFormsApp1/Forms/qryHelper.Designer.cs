namespace WindowsFormsApp1.Forms
{
    partial class qryHelper
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btSendQry = new System.Windows.Forms.Button();
            this.btColumnNumbers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(286, 333);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(304, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(484, 333);
            this.dataGridView1.TabIndex = 1;
            // 
            // btSendQry
            // 
            this.btSendQry.Location = new System.Drawing.Point(12, 351);
            this.btSendQry.Name = "btSendQry";
            this.btSendQry.Size = new System.Drawing.Size(75, 23);
            this.btSendQry.TabIndex = 2;
            this.btSendQry.Text = "Send Qry";
            this.btSendQry.UseVisualStyleBackColor = true;
            this.btSendQry.Click += new System.EventHandler(this.btSendQry_Click);
            // 
            // btColumnNumbers
            // 
            this.btColumnNumbers.Location = new System.Drawing.Point(685, 351);
            this.btColumnNumbers.Name = "btColumnNumbers";
            this.btColumnNumbers.Size = new System.Drawing.Size(103, 23);
            this.btColumnNumbers.TabIndex = 3;
            this.btColumnNumbers.Text = "Column numbers";
            this.btColumnNumbers.UseVisualStyleBackColor = true;
            this.btColumnNumbers.Click += new System.EventHandler(this.btColumnNumbers_Click);
            // 
            // qryHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 390);
            this.Controls.Add(this.btColumnNumbers);
            this.Controls.Add(this.btSendQry);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "qryHelper";
            this.Text = "qryHelper";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btSendQry;
        private System.Windows.Forms.Button btColumnNumbers;
    }
}