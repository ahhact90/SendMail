using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net.Mail;
using System.Net;
using System.IO;



namespace SendMail
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        Attachment attach = null;
        private void btSend_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                attach = null;
                try
                {
                    FileInfo file = new FileInfo(txbAttach.Text);
                    attach = new Attachment(txbAttach.Text);
                }
                catch (Exception)
                {

                    throw;
                }

                StreamReader sr = new StreamReader(txbTo.Text);

                string mail;
                while ((mail = sr.ReadLine()) != null)
                {
                    SentMail(txbUser.Text, mail, txbSubject.Text, txbMess.Text, attach);
                }
            }
            );
            thread.Start();


        }
        /// <summary>
        /// Gui mail voi cac thong tin truyen vao
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="subject"></param>
        /// <param name="message"></param>
        /// <param name="file"></param>
        void SentMail(string from, string to, string subject, string message, Attachment file = null)
        {
            MailMessage mess = new MailMessage(from, to, subject, message);
            if (attach != null)
            {
                mess.Attachments.Add(attach);
            }
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential(txbUser.Text, txbPass.Text);

            client.Send(mess);
        }
        /// <summary>
        /// Đính kèm file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAttachFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txbAttach.Text = dialog.FileName;
            }
        }

        private void btMailList_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txbTo.Text = dialog.FileName;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txbSubject_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Enter (return) was pressed.
                // ... Call a custom method when user presses this key.
                txbUser.Focus();
            }
        }

        private void txbUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Enter (return) was pressed.
                // ... Call a custom method when user presses this key.
                txbPass.Focus();
            }
        }

        private void txbPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Enter (return) was pressed.
                // ... Call a custom method when user presses this key.

                txbAttach.Focus();
            }
        }

        private void txbAttach_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Enter (return) was pressed.

                txbMess.Focus();
            }
        }

        private void txbMess_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btSend.Focus();
            }
        }
        /// <summary>
        /// Bật thuộc tính keypriview của from đó lên cho nó là true là được
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Control)
            {

                if (e.KeyCode.Equals(Keys.S))//= Ctrl + S
                {
                    btSend_Click(sender, e);
                    MessageBox.Show("Đã gửi mail thành công");
                }
                //if (e.KeyCode.Equals(Keys.F2))//= phím F2
                //{
                //    btnSua_Click(sender, e);
                //}
                //if (e.KeyCode.Equals(Keys.Delete))//= phím Delete
                //{
                //    btnXoa_Click(sender, e);
                //}
                //if (e.KeyCode.Equals(Keys.Escape))//= phím Esc
                //{
                //    btnThoat_Click(sender, e);
                //}
            }

        }

        //private void btSend_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.S && e.Control)
        //    {
        //        Thread thread = new Thread(() =>
        //        {
        //            attach = null;
        //            try
        //            {
        //                FileInfo file = new FileInfo(txbAttach.Text);
        //                attach = new Attachment(txbAttach.Text);
        //            }
        //            catch (Exception)
        //            {

        //                throw;
        //            }

        //            StreamReader sr = new StreamReader(txbTo.Text);

        //            string mail;
        //            while ((mail = sr.ReadLine()) != null)
        //            {
        //                SentMail(txbUser.Text, mail, txbSubject.Text, txbMess.Text, attach);
        //            }
        //        }
        //    );
        //        thread.Start();
        //    }
        //}
    }
}



