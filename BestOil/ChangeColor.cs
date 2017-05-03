using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestOil
{
    public partial class ChangeColor : Form
    {
        private Form1 MyOwner;
        public ChangeColor()
        {
            InitializeComponent();
        }

        private void ChangeColor_Load(object sender, EventArgs e)
        {
            MyOwner = Owner as Form1;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(int.Parse(this.trackBar1.Value.ToString()), int.Parse(this.trackBar2.Value.ToString()), int.Parse(this.trackBar3.Value.ToString()));
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(int.Parse(this.trackBar1.Value.ToString()), int.Parse(this.trackBar2.Value.ToString()), int.Parse(this.trackBar3.Value.ToString()));

        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(int.Parse(this.trackBar1.Value.ToString()), int.Parse(this.trackBar2.Value.ToString()), int.Parse(this.trackBar3.Value.ToString()));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                MyOwner.BackColor = this.BackColor;
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
