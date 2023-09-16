using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Дет3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kit1.Visible = true;
            kit2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kit3.Visible = true;
            kit4.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kit5.Visible = true;
            kit6.Visible = true;
        }
    }
}
