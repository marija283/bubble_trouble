using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bubble_Trouble
{
    public partial class Pause : Form
    {
        public Pause()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Pause_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == char.ToLower((char)Keys.R)) 
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            if (e.KeyChar == (char)Keys.R)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void Pause_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
