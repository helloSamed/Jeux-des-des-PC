using System;
using System.Threading;
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
    public partial class DesImage : Form
    {
        readonly DesManagement dm = new DesManagement();
        public DesImage()
        {
            InitializeComponent();
        }

       private void ImageChanger(PictureBox btn)
        {
            
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            int Result = (int)dm.randomNumero((int)comboBox2.SelectedIndex);
            Thread.Sleep(500);
            if (Result== 1)
            {
                btn.BackgroundImage = Properties.Resources.boisson;
            }
            else if (Result == 2)
            {
                btn.BackgroundImage = Properties.Resources.commande;
            }
            else if (Result == 3)
            {
                btn.BackgroundImage = Properties.Resources.commande1;
            }
            else if (Result == 4)
            {
                btn.BackgroundImage = Properties.Resources.PicsArt_04_19_11_06_13;
            }  else if (Result == 5)
            {
                btn.BackgroundImage = Properties.Resources.des;
            }  else if (Result == 6)
            {
                btn.BackgroundImage = Properties.Resources.des1;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "2")
            {
                pictureBox2.Visible = true;
                pictureBox3.Visible = false;
            }
            else if (comboBox1.Text == "1")
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;

            }
            else
            {
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ImageChanger(pictureBox1);
            ImageChanger(pictureBox2);
            ImageChanger(pictureBox3);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void DesImage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
