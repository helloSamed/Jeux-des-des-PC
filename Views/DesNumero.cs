using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jeux_des_des.BusinessLayer;
namespace Jeux_des_des.Views
{
    public partial class DesNumero : Form
    {
        private DesManagement dm = new DesManagement();
        public DesNumero()
        {
            InitializeComponent();
        }

     
        public void NumberChanger(Button btn,int n)
        {
            //object[] luvut = { 1,2,3,4,5,6,8,9,10,11,12,13,14,15,16,17,18,19,20 };
         

            btn.Text = ""+dm.randomNumero(n);
            Thread.Sleep(500);
        }
        private void DesNumero_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "2")
            {
                button2.Visible = true;
                button3.Visible = false;
            }
            else if (comboBox1.Text == "1")
            {
                button3.Visible = false;
                button2.Visible = false;

            }
            else
            {
                button2.Visible = true;
                button3.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NumberChanger(button1,((int)comboBox2.SelectedIndex));
            NumberChanger(button2, ((int)comboBox2.SelectedIndex));
            NumberChanger(button3, ((int)comboBox2.SelectedIndex));
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
