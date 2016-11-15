namespace SendMail
{
    partial class FrmMain
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
            this.lbTo = new System.Windows.Forms.Label();
            this.lbSubject = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.lbMatkhau = new System.Windows.Forms.Label();
            this.lbMes = new System.Windows.Forms.Label();
            this.lbAttach = new System.Windows.Forms.Label();
            this.txbMess = new System.Windows.Forms.TextBox();
            this.txbTo = new System.Windows.Forms.TextBox();
            this.txbSubject = new System.Windows.Forms.TextBox();
            this.txbUser = new System.Windows.Forms.TextBox();
            this.txbPass = new System.Windows.Forms.TextBox();
            this.txbAttach = new System.Windows.Forms.TextBox();
            this.btSend = new System.Windows.Forms.Button();
            this.btAttachFile = new System.Windows.Forms.Button();
            this.btMailList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTo
            // 
            this.lbTo.AutoSize = true;
            this.lbTo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTo.Location = new System.Drawing.Point(67, 91);
            this.lbTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTo.Name = "lbTo";
            this.lbTo.Size = new System.Drawing.Size(28, 19);
            this.lbTo.TabIndex = 1;
            this.lbTo.Text = "To";
            // 
            // lbSubject
            // 
            this.lbSubject.AutoSize = true;
            this.lbSubject.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubject.Location = new System.Drawing.Point(69, 151);
            this.lbSubject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSubject.Name = "lbSubject";
            this.lbSubject.Size = new System.Drawing.Size(61, 19);
            this.lbSubject.TabIndex = 2;
            this.lbSubject.Text = "Subject";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Location = new System.Drawing.Point(67, 221);
            this.lbUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(116, 19);
            this.lbUser.TabIndex = 3;
            this.lbUser.Text = "Tên đăng nhập";
            // 
            // lbMatkhau
            // 
            this.lbMatkhau.AutoSize = true;
            this.lbMatkhau.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMatkhau.Location = new System.Drawing.Point(68, 284);
            this.lbMatkhau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMatkhau.Name = "lbMatkhau";
            this.lbMatkhau.Size = new System.Drawing.Size(73, 19);
            this.lbMatkhau.TabIndex = 4;
            this.lbMatkhau.Text = "Mật khẩu";
            // 
            // lbMes
            // 
            this.lbMes.AutoSize = true;
            this.lbMes.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMes.Location = new System.Drawing.Point(68, 446);
            this.lbMes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMes.Name = "lbMes";
            this.lbMes.Size = new System.Drawing.Size(68, 19);
            this.lbMes.TabIndex = 5;
            this.lbMes.Text = "Message";
            // 
            // lbAttach
            // 
            this.lbAttach.AutoSize = true;
            this.lbAttach.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAttach.Location = new System.Drawing.Point(70, 364);
            this.lbAttach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAttach.Name = "lbAttach";
            this.lbAttach.Size = new System.Drawing.Size(54, 19);
            this.lbAttach.TabIndex = 6;
            this.lbAttach.Text = "Attach";
            // 
            // txbMess
            // 
            this.txbMess.Location = new System.Drawing.Point(76, 482);
            this.txbMess.Multiline = true;
            this.txbMess.Name = "txbMess";
            this.txbMess.Size = new System.Drawing.Size(601, 220);
            this.txbMess.TabIndex = 7;
            this.txbMess.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbMess_KeyDown);
            // 
            // txbTo
            // 
            this.txbTo.Location = new System.Drawing.Point(189, 81);
            this.txbTo.Name = "txbTo";
            this.txbTo.ReadOnly = true;
            this.txbTo.Size = new System.Drawing.Size(488, 27);
            this.txbTo.TabIndex = 8;
            // 
            // txbSubject
            // 
            this.txbSubject.Location = new System.Drawing.Point(189, 143);
            this.txbSubject.Name = "txbSubject";
            this.txbSubject.Size = new System.Drawing.Size(488, 27);
            this.txbSubject.TabIndex = 8;
            this.txbSubject.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbSubject_KeyDown);
            // 
            // txbUser
            // 
            this.txbUser.Location = new System.Drawing.Point(190, 213);
            this.txbUser.Name = "txbUser";
            this.txbUser.Size = new System.Drawing.Size(488, 27);
            this.txbUser.TabIndex = 8;
            this.txbUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbUser_KeyDown);
            // 
            // txbPass
            // 
            this.txbPass.Location = new System.Drawing.Point(190, 276);
            this.txbPass.Name = "txbPass";
            this.txbPass.PasswordChar = '*';
            this.txbPass.Size = new System.Drawing.Size(488, 27);
            this.txbPass.TabIndex = 8;
            this.txbPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbPass_KeyDown);
            // 
            // txbAttach
            // 
            this.txbAttach.Location = new System.Drawing.Point(190, 356);
            this.txbAttach.Name = "txbAttach";
            this.txbAttach.Size = new System.Drawing.Size(488, 27);
            this.txbAttach.TabIndex = 8;
            this.txbAttach.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbAttach_KeyDown);
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(182, 735);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(127, 38);
            this.btSend.TabIndex = 9;
            this.btSend.Text = "Send";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // btAttachFile
            // 
            this.btAttachFile.Location = new System.Drawing.Point(705, 357);
            this.btAttachFile.Name = "btAttachFile";
            this.btAttachFile.Size = new System.Drawing.Size(108, 25);
            this.btAttachFile.TabIndex = 10;
            this.btAttachFile.Text = "Attach";
            this.btAttachFile.UseVisualStyleBackColor = true;
            this.btAttachFile.Click += new System.EventHandler(this.btAttachFile_Click);
            // 
            // btMailList
            // 
            this.btMailList.Location = new System.Drawing.Point(705, 83);
            this.btMailList.Name = "btMailList";
            this.btMailList.Size = new System.Drawing.Size(107, 36);
            this.btMailList.TabIndex = 11;
            this.btMailList.Text = "Mail List";
            this.btMailList.UseVisualStyleBackColor = true;
            this.btMailList.Click += new System.EventHandler(this.btMailList_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 865);
            this.Controls.Add(this.btMailList);
            this.Controls.Add(this.btAttachFile);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.txbAttach);
            this.Controls.Add(this.txbPass);
            this.Controls.Add(this.txbUser);
            this.Controls.Add(this.txbSubject);
            this.Controls.Add(this.txbTo);
            this.Controls.Add(this.txbMess);
            this.Controls.Add(this.lbAttach);
            this.Controls.Add(this.lbMes);
            this.Controls.Add(this.lbMatkhau);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.lbSubject);
            this.Controls.Add(this.lbTo);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMain_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTo;
        private System.Windows.Forms.Label lbSubject;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label lbMatkhau;
        private System.Windows.Forms.Label lbMes;
        private System.Windows.Forms.Label lbAttach;
        private System.Windows.Forms.TextBox txbMess;
        private System.Windows.Forms.TextBox txbTo;
        private System.Windows.Forms.TextBox txbSubject;
        private System.Windows.Forms.TextBox txbUser;
        private System.Windows.Forms.TextBox txbPass;
        private System.Windows.Forms.TextBox txbAttach;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.Button btAttachFile;
        private System.Windows.Forms.Button btMailList;
    }
}

