using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGrupal
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            Form lol = new Form1();
            lol.Show();
            this.Close();
        }

        private void btnc1_Click(object sender, EventArgs e)
        {
            Form lol = new Form1();
            lol.Show();
            this.Close();
        }

        private void btnc2_Click(object sender, EventArgs e)
        {
            Form lol = new Form1();
            lol.Show();
            this.Close();
        }
    }
}
