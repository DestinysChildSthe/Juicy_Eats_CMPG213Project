namespace Juicy_Eats_CMPG213Project
{
    partial class frmFireEmployees
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
            this.cmbSelect = new System.Windows.Forms.ComboBox();
            this.lblSelect = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnFire = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbSelect
            // 
            this.cmbSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelect.FormattingEnabled = true;
            this.cmbSelect.Location = new System.Drawing.Point(120, 123);
            this.cmbSelect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbSelect.Name = "cmbSelect";
            this.cmbSelect.Size = new System.Drawing.Size(284, 37);
            this.cmbSelect.TabIndex = 0;
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelect.Location = new System.Drawing.Point(114, 88);
            this.lblSelect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(202, 29);
            this.lblSelect.TabIndex = 1;
            this.lblSelect.Text = "Select Employee:";
            this.lblSelect.Click += new System.EventHandler(this.lblSelect_Click);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(56, 14);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(397, 40);
            this.lblHeading.TabIndex = 11;
            this.lblHeading.Text = "Employee Termination";
            // 
            // btnFire
            // 
            this.btnFire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFire.Location = new System.Drawing.Point(160, 203);
            this.btnFire.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFire.Name = "btnFire";
            this.btnFire.Size = new System.Drawing.Size(224, 46);
            this.btnFire.TabIndex = 12;
            this.btnFire.Text = "Fire Employee";
            this.btnFire.UseVisualStyleBackColor = true;
            this.btnFire.Click += new System.EventHandler(this.btnFire_Click);
            // 
            // frmFireEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 377);
            this.Controls.Add(this.btnFire);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.cmbSelect);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmFireEmployees";
            this.Text = "frmFireEmployees";
            this.Load += new System.EventHandler(this.frmFireEmployees_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSelect;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnFire;
    }
}