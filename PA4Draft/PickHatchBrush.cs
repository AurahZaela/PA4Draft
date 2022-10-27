using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA4Draft
{
    public partial class PickHatchBrush : Form
    {
        public PickHatchBrush()
        {
            InitializeComponent();
            pickedColor1 = SystemColors.ButtonFace;
            pickedColor2 = SystemColors.ButtonFace;
        }

        private void PickHatchBrush_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult d = colorDialog1.ShowDialog();
            if (d == DialogResult.OK)
                pickedColor1 = colorDialog1.Color;
            
        }
    }
}
