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

        public Manager(Rol rol, Vaardigheid vaardigheid, Naam naam)
        {
            InitializeComponent();
            this.rol = rol;
            this.vaardigheid = vaardigheid;
            this.naam = naam;
            LbRol.Text = rol.ToString();
            LbNaam.Text = naam.ToString();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            /*Hoofdmenu F = new Hoofdmenu();
            this.Hide();
            F.Show();*/
            this.Close();
        }

        private void Manager_Load(object sender, EventArgs e)
        {

        }
    }
}
