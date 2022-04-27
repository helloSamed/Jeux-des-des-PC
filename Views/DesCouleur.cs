using System.Threading;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jeux_des_des.BusinessLayer;
namespace Jeux_des_des.Views
{
    public partial class DesCouleur : Form
    {
        readonly DesManagement dm = new DesManagement();
        public DesCouleur()
        {
            InitializeComponent();
            button2.Visible = false;
            button3.Visible = false;
        }
        public void ButtonColorChanger(Button btn)
        {
        
            int Result = (int)dm.randomNumero((int)comboBox2.SelectedIndex);
            if ( Result== 1)
            {
                btn.BackColor = Color.Black;
            }
            else if (Result == 2)
            {
                btn.BackColor = Color.Blue;
            }
            else if (Result == 3)
            {
                btn.BackColor = Color.Green;
            }
            else if (Result == 4)
            {
                btn.BackColor = Color.Red;
            }   else if (Result == 5)
            {
                btn.BackColor = Color.White;
            }   else if (Result == 6)
            {
                btn.BackColor = Color.Pink;
            }   else if (Result == 7)
            {
                btn.BackColor = Color.Purple;
            }   else if (Result == 8)
            {
                btn.BackColor = Color.Azure;
            }   else if (Result == 9)
            {
                btn.BackColor = Color.BlueViolet;
            }   else if (Result == 10)
            {
                btn.BackColor = Color.DarkGreen;
            }
            Thread.Sleep(500);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ButtonColorChanger(button1);


        }

        private void DesCouleur_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ButtonColorChanger(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ButtonColorChanger(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ButtonColorChanger(button1);
         
            ButtonColorChanger(button2);
            
            ButtonColorChanger(button3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text=="2")
            {
                button2.Visible = true;
                button3.Visible = false;
            }
            else if(comboBox1.Text=="1")
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

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
