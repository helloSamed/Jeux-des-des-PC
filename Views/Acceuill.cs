using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jeux_des_des.Views;
namespace Jeux_des_des
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DesCouleur d3 = new DesCouleur();
            d3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DesNumero d1=new DesNumero();
            d1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DesImage d2 = new DesImage();
            d2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
