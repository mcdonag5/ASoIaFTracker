namespace WindowsFormsApp1.Forms
{
    partial class NewLandForm
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
            this.dgLand = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgLand)).BeginInit();
            this.SuspendLayout();
            // 
            // dgLand
            // 
            this.dgLand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLand.Location = new System.Drawing.Point(382, 398);
            this.dgLand.Name = "dgLand";
            this.dgLand.Size = new System.Drawing.Size(33, 26);
            this.dgLand.TabIndex = 0;
            this.dgLand.Visible = false;
            // 
            // NewLandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 436);
            this.Controls.Add(this.dgLand);
            this.Name = "NewLandForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.NewLandForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgLand)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgLand;
    }
}