using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace HexToTextProgram
{
    public partial class HexToText : Form
    {
        public HexToText()
        {
            InitializeComponent();
        }

        private void butPaste_Click(object sender, EventArgs e)
        {
            lbStatus.Text = "";
            txtHexInput.Text = Clipboard.GetText();
        }

        private void butCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtTextOuput.Text);
            lbStatus.Text = "Text coppied";
        }

        private void txtHexInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtHexInput.Text))
                {
                    lbStatus.Text = "Status";
                }
                else
                {
                    String hexInput = txtHexInput.Text;
                    Byte[] data = ByteArrFromHex(hexInput);

                    txtTextOuput.Text = Encoding.UTF8.GetString(data);
                    lbStatus.Text = "Convert completed";
                }
            }
            catch (Exception ex)
            {
                lbStatus.Text = ex.Message;
            }
        }

        public static byte[] ByteArrFromHex(string hex)
        {
            hex = Regex.Replace(hex, "\\-|\\s+", "");
            byte[] raw = new byte[hex.Length / 2];
            for (int i = 0; i < raw.Length; i++)
            {
                raw[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
            }
            return raw;

        }
    }
}
