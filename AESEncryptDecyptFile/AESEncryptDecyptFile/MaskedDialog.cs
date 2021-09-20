using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AESEncryptDecryptFile
{
    class MaskedDialog : Form
    {
        static MaskedDialog mask;
        static Form frmContainer;

        private Form dialog;
        private UserControl ucDialog;

        private MaskedDialog(Form parent, Form dialog)
        {
            this.dialog = dialog;
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = System.Drawing.Color.Black;
            this.Opacity = 0.50;
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.Manual;
            this.Size = parent.ClientSize;
            this.Location = parent.PointToScreen(System.Drawing.Point.Empty);
            parent.Move += AdjustPosition;
            parent.SizeChanged += AdjustPosition;
        }

        private MaskedDialog(Form parent, UserControl ucDialog)
        {
            this.ucDialog = ucDialog;
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = System.Drawing.Color.Black;
            this.Opacity = 0.50;
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.Manual;
            this.Size = parent.ClientSize;
            this.Location = parent.PointToScreen(System.Drawing.Point.Empty);
            parent.Move += AdjustPosition;
            parent.SizeChanged += AdjustPosition;
        }

        private void AdjustPosition(object sender, EventArgs e)
        {
            Form parent = sender as Form;
            this.Location = parent.PointToScreen(System.Drawing.Point.Empty);
            this.ClientSize = parent.ClientSize;
        }

        public static DialogResult ShowDialog(Form parent, Form dialog)
        {
            mask = new MaskedDialog(parent, dialog);
            dialog.StartPosition = FormStartPosition.CenterParent;
            mask.MdiParent = parent.MdiParent;
            mask.Show();
            DialogResult result = dialog.ShowDialog(mask);
            mask.Close();

            return result;
        }

        public static DialogResult ShowDialog(Form parent, UserControl dialog)
        {
            mask = new MaskedDialog(parent, dialog);
            frmContainer = new Form();
            frmContainer.ShowInTaskbar = false;
            frmContainer.FormBorderStyle = FormBorderStyle.None;
            frmContainer.StartPosition = FormStartPosition.CenterScreen;
            frmContainer.Height = dialog.Height;
            frmContainer.Width = dialog.Width;

            frmContainer.Controls.Add(dialog);
            mask.MdiParent = parent.MdiParent;
            mask.Show();
            DialogResult result = frmContainer.ShowDialog(mask);
            frmContainer.Close();
            mask.Close();

            return result;
        }

        public static void CloseDialog()
        {
            if (frmContainer != null)
            {
                frmContainer.Close();
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();

            // MaskedDialog
            this.ClientSize = new System.Drawing.Size(783, 490);
            this.Name = "MaskedDialog";
            this.FormClosing += new FormClosingEventHandler(this.MaskedDialog_Closing);
            this.Load += new EventHandler(this.MaskedDialog_Load);

            this.ResumeLayout(false);
        }

        private void MaskedDialog_Load(object sender, EventArgs e)
        {
            
        }

        private void MaskedDialog_Closing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
