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
    public partial class Manager : Form
    {

        Rol rol;
        Vaardigheid vaardigheid;
        Naam naam;
        Persoonlijkheden persoonlijkheden;
        Rating rating;

        public Manager(Rol rol, Vaardigheid vaardigheid, Naam naam, Persoonlijkheden persoonlijkheden, Rating rating)
        {
            InitializeComponent();
            this.rol = rol;
            this.vaardigheid = vaardigheid;
            this.naam = naam;
            this.persoonlijkheden = persoonlijkheden;
            this.rating = rating;
            LbRol.Text = rol.ToString();
            LbNaam.Text = naam.ToString();
            LbVaardigheid.Text = vaardigheid.ToString();
            LbPers.Text = persoonlijkheden.ToString();
            LbRating.Text = rating.ToString();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Manager_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if(GBMedewerker.Visible == false)
            {
                GBMedewerker.Visible = true;
            }
            else
            {
                GBMedewerker.Visible = false;
            }
        }
    }
}
