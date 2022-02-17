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
    
    public partial class Hoofdmenu : Form
    {
        Rol rol = null;

        public Hoofdmenu()
        {
            InitializeComponent();
        }

        private void BtnMan_Click(object sender, EventArgs e)
        {
            Manager Man = new Manager();
            this.Hide();
            Man.ShowDialog();
            this.Show();
        }

        private void BtnMed_Click(object sender, EventArgs e)
        {
            Medewerker Med = new Medewerker(rol);
            this.Hide();
            Med.ShowDialog();
            this.Show();
        }

        private void Hoofdmenu_Load(object sender, EventArgs e)
        {

        }
    }
}
