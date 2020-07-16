using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IpTools_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioWhoisRu_CheckedChanged(object sender, EventArgs e)
        {
            if (radioWhoisRu.Checked == true)
            {
                radioNicRu.Checked = false;
            }
            else
            {
                radioNicRu.Checked = true;
            }
        }
    }
}
