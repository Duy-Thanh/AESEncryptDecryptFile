using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AESEncryptDecryptFile
{
    public partial class CustomizeTextBox : TextBox
    {
        private Color _bottomBorderColor = Color.Aquamarine;
        private Color _onFocusColor = Color.MediumAquamarine;
        public CustomizeTextBox()
        {
            BorderStyle = BorderStyle.None;
            AutoSize = false;

            // Add a label to control
            Controls.Add(new Label
            {
                Height = 2,
                Dock = DockStyle.Bottom,
                BackColor = _bottomBorderColor
            });

            InitializeComponent();
        }

        [Browsable(false)]
        public new BorderStyle BorderStyle
        {
            get
            {
                return base.BorderStyle;
            }
            set
            {
                base.BorderStyle = value;
            }
        }

        public Color BottomBorderColor
        {
            get
            {
                return _bottomBorderColor;
            }
            set
            {
                _bottomBorderColor = value;
                Controls[0].BackColor = _bottomBorderColor;
            }
        }

        public Color BottomBorderOnFocusColor
        {
            get
            {
                return _onFocusColor;
            }
            set
            {
                _onFocusColor = value;
            }
        }

        private void CustomizeTextBox_Enter(object sender, EventArgs e)
        {
            Controls[0].BackColor = _onFocusColor;
        }

        private void CustomizeTextBox_Leave(object sender, EventArgs e)
        {
            Controls[0].BackColor = _bottomBorderColor;
        }
    }
}
