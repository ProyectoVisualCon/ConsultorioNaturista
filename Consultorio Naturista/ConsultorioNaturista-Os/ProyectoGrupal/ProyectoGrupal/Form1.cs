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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnc_Click(object sender, EventArgs e)
        {
            Form lol = new Form2();
            lol.Show();
            this.Hide();
        }

        private void btnp_Click(object sender, EventArgs e)
        {
            Form lol = new Form3();
            lol.Show();
            this.Hide();
        }
    }
}
