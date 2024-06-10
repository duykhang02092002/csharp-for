using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_for
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            double so;
            so = Convert.ToDouble(txt1.Text);
            int gt = 1;
            for (int i = 1; i <= so; i++)
            {
                gt = gt * i;//gt*=i;
            }
            txtgt.Text = gt.ToString();
        }
    }
}
