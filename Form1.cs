using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_tinhtong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void so_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
            Double so1, so2, ketqua;
            so1 = Convert.ToDouble(txtso1.Text);
            so2 = Convert.ToDouble(txtso2.Text);
            ketqua = so1 + so2;
            txtkq.Text = ketqua.ToString();
            lblkq.Text = ketqua.ToString();
        }

        private void lblkq_Click(object sender, EventArgs e)
        {
            
        }
    }
}
