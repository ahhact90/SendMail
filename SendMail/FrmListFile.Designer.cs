namespace SendMail
{
    partial class FrmListFile
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
            this.btOpenFile = new System.Windows.Forms.Button();
            this.lstBoxFile = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btOpenFile
            // 
            this.btOpenFile.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btOpenFile.Location = new System.Drawing.Point(51, 23);
            this.btOpenFile.Name = "btOpenFile";
            this.btOpenFile.Size = new System.Drawing.Size(135, 78);
            this.btOpenFile.TabIndex = 2;
            this.btOpenFile.Text = "OPEN FILE";
            this.btOpenFile.UseVisualStyleBackColor = true;
            this.btOpenFile.Click += new System.EventHandler(this.btOpenFile_Click);
            // 
            // lstBoxFile
            // 
            this.lstBoxFile.FormattingEnabled = true;
            this.lstBoxFile.Location = new System.Drawing.Point(51, 107);
            this.lstBoxFile.Name = "lstBoxFile";
            this.lstBoxFile.Size = new System.Drawing.Size(551, 303);
            this.lstBoxFile.TabIndex = 3;
            this.lstBoxFile.SelectedIndexChanged += new System.EventHandler(this.lstBoxFile_SelectedIndexChanged);
            // 
            // FrmListFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 492);
            this.Controls.Add(this.lstBoxFile);
            this.Controls.Add(this.btOpenFile);
            this.Name = "FrmListFile";
            this.Text = "FrmListFile";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btOpenFile;
        private System.Windows.Forms.ListBox lstBoxFile;
    }
}