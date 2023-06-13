using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revisão
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Divisao dv = new Divisao();
            dv.ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void rdbt_masculino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string sexo = "";

            if(rdbt_feminino.Checked )
            {
                sexo = rdbt_feminino.Text;
            }
            else if(rdbt_masculino.Checked)
            {
                sexo = rdbt_masculino.Text;
            }
        }
    }
}
