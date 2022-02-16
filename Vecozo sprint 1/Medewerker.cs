using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vecozo_sprint_1
{

    public partial class Medewerker : Form
    {
        Image SterVol = Vecozo_sprint_1.Properties.Resources.ster_vol;
        Image SterLeeg = Vecozo_sprint_1.Properties.Resources.ster;
        public Medewerker()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 F = new Form1();
            this.Hide();
            F.Show();
        }
        
        private void Ster_Enter(object sender, EventArgs e)
        {
            PictureBox Ster = (PictureBox)sender;
            Ster.Image = SterVol;
            Ster1.Image = SterVol;

            if (Ster == Ster5)
            {
                Ster4.Image = SterVol;
                Ster3.Image = SterVol;
                Ster2.Image = SterVol;

            }
            if (Ster == Ster4)
            {
                Ster3.Image = SterVol;
                Ster2.Image = SterVol;
            }
            if (Ster == Ster3)
            {
                Ster2.Image = SterVol;
            }
        }

        private void Ster_Leave(object sender, EventArgs e)
        {
            Ster1.Image = SterLeeg;
            Ster2.Image = SterLeeg;
            Ster3.Image = SterLeeg;
            Ster4.Image = SterLeeg;
            Ster5.Image = SterLeeg;
        }

        private void Ster_Click(object sender, EventArgs e)
        {
            if(TxtRating.Text != "")
            {

                TxtRating.Text = "";
            }
            else
            {
                MessageBox.Show("Vul je vaardigheid in!");
            }
        }
    }
}

