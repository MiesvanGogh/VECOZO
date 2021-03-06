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
        List<PictureBox> pictureBoxes = new List<PictureBox>();
        Rol rol;
        Vaardigheid vaardigheid;
        Naam naam;
        Persoonlijkheden persoonlijkheden;
        Rating rating;
        public Medewerker(Rol rol, Vaardigheid vaardigheid, Naam naam, Persoonlijkheden persoonlijkheden, Rating rating)
        {
            foreach(PictureBox pictureBox in pictureBoxes)
            {
                if(pictureBox.Tag.ToString() == "Ster")
                {
                    pictureBoxes.Add(pictureBox);
                }
            }
        }

        public Medewerker()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
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
            //Ster_Enter(sender, e);
            //zorgen dat de handlers uitgaan die we willen.
        }

        private void BtnOpslaan_Click(object sender, EventArgs e)
        {
                if (TxtRating.Text != "" && RatingNum.Value > 0)
                {
                    rol = new Rol(BoxRol.Text);
                    vaardigheid = new Vaardigheid(TxtRating.Text);
                    naam = new Naam(TxtNaam.Text);
                    persoonlijkheden = new Persoonlijkheden(TxtPers.Text);
                    rating = new Rating(RatingNum.Value.ToString());
                    TxtRating.Text = "";
                    TxtPers.Text = "";
                    BoxRol.Text = "";
                    TxtNaam.Text = "";
                    MessageBox.Show("Mies");
                }
                else
                {
                    MessageBox.Show("Vul je vaardigheid in!");
                }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Manager Man = new Manager(rol, vaardigheid, naam, persoonlijkheden, rating);
            this.Hide();
            Man.ShowDialog();
            this.Show();
        }
        private void BoxRol_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void Medewerker_Load(object sender, EventArgs e)
        {
            List<Rol> rollen = new List<Rol>();
            rollen.Add(new Rol(""));
            rollen.Add(new Rol("Projectleider"));
            rollen.Add(new Rol("Projectlid"));
            rollen.Add(new Rol("Onderzoeker"));
            BoxRol.DataSource = rollen;
        }
    }
}

